/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ErrorEventArgs = Newtonsoft.Json.Serialization.ErrorEventArgs;
using RestSharp;
using RestSharp.Deserializers;
using RestSharpMethod = RestSharp.Method;
using Polly;
using Avalara.SDK.Api;
using Avalara.SDK.Auth;
using System.Runtime.CompilerServices;

namespace Avalara.SDK.Client
{
    /// <summary>
    /// Allows RestSharp to Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
    /// </summary>
    internal class CustomJsonCodec : RestSharp.Serializers.ISerializer, RestSharp.Deserializers.IDeserializer
    {
        private readonly IReadableConfiguration _configuration;
        private static readonly string _contentType = "application/json";
        private readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        public CustomJsonCodec(IReadableConfiguration configuration)
        {
            _configuration = configuration;
        }

        public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
        {
            _serializerSettings = serializerSettings;
            _configuration = configuration;
        }

        /// <summary>
        /// Serialize the object into a JSON string.
        /// </summary>
        /// <param name="obj">Object to be serialized.</param>
        /// <returns>A JSON string.</returns>
        public string Serialize(object obj)
        {
            if (obj != null && obj is Avalara.SDK.Model.AbstractOpenAPISchema)
            {
                // the object to be serialized is an oneOf/anyOf schema
                return ((Avalara.SDK.Model.AbstractOpenAPISchema)obj).ToJson();
            }
            else
            {
                return JsonConvert.SerializeObject(obj, _serializerSettings);
            }
        }

        public T Deserialize<T>(IRestResponse response)
        {
            var result = (T)Deserialize(response, typeof(T));
            return result;
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        internal object Deserialize(IRestResponse response, Type type)
        {
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            // TODO: ? if (type.IsAssignableFrom(typeof(Stream)))
            if (type == typeof(Stream))
            {
                var bytes = response.RawBytes;
                if (response.Headers != null)
                {
                    var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : _configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in response.Headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, bytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(bytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content, null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return Convert.ChangeType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, _serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }

        public string ContentType
        {
            get { return _contentType; }
            set { throw new InvalidOperationException("Not allowed to set content type."); }
        }
    }
    /// <summary>
    /// Provides a default implementation of an Api client (both synchronous and asynchronous implementations),
    /// encapsulating general REST accessor use cases.
    /// </summary>
    public class ApiClient
    {

        /// <summary>
        /// The standard client header for AvaTax API calls
        /// </summary>
        private static readonly string AVALARA_CLIENT_HEADER = "X-Avalara-Client";
        /// <summary>
        /// The standard configuration object
        /// </summary>
        internal Avalara.SDK.Client.IReadableConfiguration Configuration;
        /// <summary>
        /// SDKVersion property - Connot be set by user
        /// </summary>
        internal string SdkVersion;

        private IOAuth OAuthObj;
        private Hashtable hashScopeTable;

        /// <summary>
        /// Initializes a new instance of the ApiClient />
        /// </summary>
        /// <param name="config"></param>
        /// <exception cref="ArgumentException"></exception>
        public ApiClient(IReadableConfiguration config)
        {
            this.Configuration = Avalara.SDK.Client.Configuration.MergeConfigurations(
                Avalara.SDK.Client.GlobalConfiguration.Instance,
                config
            );

            hashScopeTable = new Hashtable();
            CheckConfiguration();

        }
        /// Specifies the settings on a <see cref="JsonSerializer" /> object.
        /// These settings can be adjusted to accommodate custom serialization rules.
        public JsonSerializerSettings SerializerSettings { get; set; } = new JsonSerializerSettings
        {
            // OpenAPI generated types generally hide default constructors.
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy
                {
                    OverrideSpecifiedNames = false
                }
            }
        };

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="requiredScopes">Scope(s) of OAuth2</param>
        private void InterceptRequest(IRestRequest request, string requiredScopes)
        {
            //OAuth2 flow
            if (!this.Configuration.ClientID.IsNullorEmpty())
            {
                string accessKey = GetOAuthAccessToken(requiredScopes);
                if (accessKey.IsNullorEmpty())
                {
                    UpdateOAuthAccessToken(requiredScopes);
                    accessKey = GetOAuthAccessToken(requiredScopes);
                }
                request.AddHeader("Authorization", "Bearer " + accessKey);
            }
            // authentication (BasicAuth) required
            else if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                request.AddHeader("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            else if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                request.AddHeader("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
        }

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        private void InterceptResponse(IRestRequest request, IRestResponse response) { }

        /// <summary>
        /// Constructs the RestSharp version of an http method
        /// </summary>
        /// <param name="method">Swagger Client Custom HttpMethod</param>
        /// <returns>RestSharp's HttpMethod instance.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private RestSharpMethod Method(HttpMethod method)
        {
            RestSharpMethod other;
            switch (method)
            {
                case HttpMethod.Get:
                    other = RestSharpMethod.GET;
                    break;
                case HttpMethod.Post:
                    other = RestSharpMethod.POST;
                    break;
                case HttpMethod.Put:
                    other = RestSharpMethod.PUT;
                    break;
                case HttpMethod.Delete:
                    other = RestSharpMethod.DELETE;
                    break;
                case HttpMethod.Head:
                    other = RestSharpMethod.HEAD;
                    break;
                case HttpMethod.Options:
                    other = RestSharpMethod.OPTIONS;
                    break;
                case HttpMethod.Patch:
                    other = RestSharpMethod.PATCH;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("method", method, null);
            }

            return other;
        }

        /// <summary>
        /// Provides all logic for constructing a new RestSharp <see cref="RestRequest"/>.
        /// At this point, all information for querying the service is known. Here, it is simply
        /// mapped into the RestSharp request.
        /// </summary>
        /// <param name="method">The http verb.</param>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>[private] A new RestRequest instance.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private RestRequest NewRequest(
            HttpMethod method,
            string path,
            RequestOptions options)
        {
            CheckConfiguration();
            if (path == null) throw new ArgumentNullException("path");
            if (options == null) throw new ArgumentNullException("options");

            string clientID = String.Format("{0}; {1}; {2}; {3}; {4}", Configuration.AppName, Configuration.AppVersion,
                "CSharpRestClient", SdkVersion, Configuration.MachineName);

            RestRequest request = new RestRequest(Method(method))
            {
                Resource = path,
                JsonSerializer = new CustomJsonCodec(SerializerSettings, Configuration)
            };
            request.AddHeader(AVALARA_CLIENT_HEADER, clientID);

            if (options.PathParameters != null)
            {
                foreach (var pathParam in options.PathParameters)
                {
                    request.AddParameter(pathParam.Key, pathParam.Value, ParameterType.UrlSegment);
                }
            }

            if (options.QueryParameters != null)
            {
                foreach (var queryParam in options.QueryParameters)
                {
                    foreach (var value in queryParam.Value)
                    {
                        request.AddQueryParameter(queryParam.Key, value);
                    }
                }
            }

            if (Configuration.DefaultHeaders != null)
            {
                foreach (var headerParam in Configuration.DefaultHeaders)
                {
                    request.AddHeader(headerParam.Key, headerParam.Value);
                }
            }

            if (options.HeaderParameters != null)
            {
                foreach (var headerParam in options.HeaderParameters)
                {
                    foreach (var value in headerParam.Value)
                    {
                        request.AddHeader(headerParam.Key, value);
                    }
                }
            }

            if (options.FormParameters != null)
            {
                foreach (var formParam in options.FormParameters)
                {
                    request.AddParameter(formParam.Key, formParam.Value);
                }
            }

            if (options.Data != null)
            {
                if (options.Data is Stream stream)
                {
                    var contentType = "application/octet-stream";
                    if (options.HeaderParameters != null)
                    {
                        var contentTypes = options.HeaderParameters["Content-Type"];
                        contentType = contentTypes[0];
                    }

                    var bytes = ClientUtils.ReadAsBytes(stream);
                    request.AddParameter(contentType, bytes, ParameterType.RequestBody);
                }
                else
                {
                    if (options.HeaderParameters != null)
                    {
                        var contentTypes = options.HeaderParameters["Content-Type"];
                        if (contentTypes == null || contentTypes.Any(header => header.Contains("application/json")))
                        {
                            request.RequestFormat = DataFormat.Json;
                        }
                        else
                        {
                            // TODO: Generated client user should add additional handlers. RestSharp only supports XML and JSON, with XML as default.
                        }
                    }
                    else
                    {
                        // Here, we'll assume JSON APIs are more common. XML can be forced by adding produces/consumes to openapi spec explicitly.
                        request.RequestFormat = DataFormat.Json;
                    }

                    request.AddJsonBody(options.Data);
                }
            }

            if (options.FileParameters != null)
            {
                foreach (var fileParam in options.FileParameters)
                {
                    var bytes = ClientUtils.ReadAsBytes(fileParam.Value);
                    var fileStream = fileParam.Value as FileStream;
                    if (fileStream != null)
                        request.Files.Add(FileParameter.Create(fileParam.Key, bytes, System.IO.Path.GetFileName(fileStream.Name)));
                    else
                        request.Files.Add(FileParameter.Create(fileParam.Key, bytes, "no_file_name_provided"));
                }
            }

            if (options.Cookies != null && options.Cookies.Count > 0)
            {
                foreach (var cookie in options.Cookies)
                {
                    request.AddCookie(cookie.Name, cookie.Value);
                }
            }

            return request;
        }

        private ApiResponse<T> ToApiResponse<T>(IRestResponse<T> response)
        {
            T result = response.Data;
            string rawContent = response.Content;

            var transformed = new ApiResponse<T>(response.StatusCode, new Multimap<string, string>(), result, rawContent)
            {
                ErrorText = response.ErrorMessage,
                Cookies = new List<Cookie>()
            };

            if (response.Headers != null)
            {
                foreach (var responseHeader in response.Headers)
                {
                    transformed.Headers.Add(responseHeader.Name, ClientUtils.ParameterToString(responseHeader.Value));
                }
            }

            if (response.Cookies != null)
            {
                foreach (var responseCookies in response.Cookies)
                {
                    transformed.Cookies.Add(
                        new Cookie(
                            responseCookies.Name,
                            responseCookies.Value,
                            responseCookies.Path,
                            responseCookies.Domain)
                        );
                }
            }

            return transformed;
        }

        private ApiResponse<T> Exec<T>(RestRequest req, IReadableConfiguration configuration, string requiredScopes)
        {
            RestClient client = new RestClient(this.Configuration.BasePath);

            client.ClearHandlers();
            var existingDeserializer = req.JsonSerializer as IDeserializer;
            if (existingDeserializer != null)
            {
                client.AddHandler("application/json", () => existingDeserializer);
                client.AddHandler("text/json", () => existingDeserializer);
                client.AddHandler("text/x-json", () => existingDeserializer);
                client.AddHandler("text/javascript", () => existingDeserializer);
                client.AddHandler("*+json", () => existingDeserializer);
            }
            else
            {
                var customDeserializer = new CustomJsonCodec(SerializerSettings, configuration);
                client.AddHandler("application/json", () => customDeserializer);
                client.AddHandler("text/json", () => customDeserializer);
                client.AddHandler("text/x-json", () => customDeserializer);
                client.AddHandler("text/javascript", () => customDeserializer);
                client.AddHandler("*+json", () => customDeserializer);
            }

            var xmlDeserializer = new XmlDeserializer();
            client.AddHandler("application/xml", () => xmlDeserializer);
            client.AddHandler("text/xml", () => xmlDeserializer);
            client.AddHandler("*+xml", () => xmlDeserializer);
            client.AddHandler("*", () => xmlDeserializer);

            client.Timeout = configuration.Timeout;

            if (configuration.ClientCertificates != null)
            {
                client.ClientCertificates = configuration.ClientCertificates;
            }

            InterceptRequest(req, requiredScopes);

            IRestResponse<T> response = null;

            response = ExecuteRequest<T>(req, client);
            if (response != null && (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden))
            {
                if (!this.Configuration.ClientID.IsNullorEmpty()) //OAuth2 is configured 
                {
                    string authHeader= Convert.ToString(req.Parameters.First(x => x.Type == ParameterType.HttpHeader
                            && x.Name == "Authorization").Value);
                    if (!authHeader.IsNullorEmpty())
                    {
                        string[] authValues = authHeader.Split(' ');
                        if (authValues.Length == 2)
                        {
                            UpdateOAuthAccessToken(requiredScopes, authValues[1]);
                            string accessToken = GetOAuthAccessToken(requiredScopes);
                            req.AddHeader("Authorization", "Bearer " + accessToken);
                            response = ExecuteRequest<T>(req, client);
                        }
                    }
                }
            }

            // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
            if (typeof(Avalara.SDK.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
            {
                try
                {
                    response.Data = (T)typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
                }
                catch (Exception ex)
                {
                    throw ex.InnerException != null ? ex.InnerException : ex;
                }
            }
            else if (typeof(T).Name == "Stream") // for binary response
            {
                response.Data = (T)(object)new MemoryStream(response.RawBytes);
            }

            InterceptResponse(req, response);

            var result = ToApiResponse(response);
            if (response.ErrorMessage != null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies != null && response.Cookies.Count > 0)
            {
                if (result.Cookies == null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies)
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }

        private IRestResponse<T> ExecuteRequest<T>(RestRequest req, RestClient client)
        {
            IRestResponse<T> response = null;

            if (RetryConfiguration.RetryPolicy != null)
            {
                var policy = RetryConfiguration.RetryPolicy;
                var policyResult = policy.ExecuteAndCapture(() => client.Execute(req));
                response = (policyResult.Outcome == OutcomeType.Successful) ? client.Deserialize<T>(policyResult.Result) : new RestResponse<T>
                {
                    Request = req,
                    ErrorException = policyResult.FinalException
                };
            }
            else
            {
                response = client.Execute<T>(req);
            }

            return response;
        }

        private async Task<IRestResponse<T>> ExecuteAsycRequest<T>(RestRequest req, RestClient client, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            IRestResponse<T> response = null;

            if (RetryConfiguration.AsyncRetryPolicy != null)
            {
                var policy = RetryConfiguration.AsyncRetryPolicy;
                var policyResult = await policy.ExecuteAndCaptureAsync((ct) => client.ExecuteAsync(req, ct), cancellationToken).ConfigureAwait(false);
                response = (policyResult.Outcome == OutcomeType.Successful) ? client.Deserialize<T>(policyResult.Result) : new RestResponse<T>
                {
                    Request = req,
                    ErrorException = policyResult.FinalException
                };
            }
            else
            {
                response = await client.ExecuteAsync<T>(req, cancellationToken).ConfigureAwait(false);
            }

            return response;

        }
        private async Task<ApiResponse<T>> ExecAsync<T>(RestRequest req, IReadableConfiguration configuration, System.Threading.CancellationToken cancellationToken, string requiredScopes)
        {
            RestClient client = new RestClient(this.Configuration.BasePath);

            client.ClearHandlers();
            var existingDeserializer = req.JsonSerializer as IDeserializer;
            if (existingDeserializer != null)
            {
                client.AddHandler("application/json", () => existingDeserializer);
                client.AddHandler("text/json", () => existingDeserializer);
                client.AddHandler("text/x-json", () => existingDeserializer);
                client.AddHandler("text/javascript", () => existingDeserializer);
                client.AddHandler("*+json", () => existingDeserializer);
            }
            else
            {
                var customDeserializer = new CustomJsonCodec(SerializerSettings, configuration);
                client.AddHandler("application/json", () => customDeserializer);
                client.AddHandler("text/json", () => customDeserializer);
                client.AddHandler("text/x-json", () => customDeserializer);
                client.AddHandler("text/javascript", () => customDeserializer);
                client.AddHandler("*+json", () => customDeserializer);
            }

            var xmlDeserializer = new XmlDeserializer();
            client.AddHandler("application/xml", () => xmlDeserializer);
            client.AddHandler("text/xml", () => xmlDeserializer);
            client.AddHandler("*+xml", () => xmlDeserializer);
            client.AddHandler("*", () => xmlDeserializer);

            client.Timeout = configuration.Timeout;

            if (configuration.ClientCertificates != null)
            {
                client.ClientCertificates = configuration.ClientCertificates;
            }

            InterceptRequest(req, requiredScopes);

            IRestResponse<T> response = await client.ExecuteAsync<T>(req, cancellationToken).ConfigureAwait(false);
            if (response != null && (response.StatusCode == HttpStatusCode.Unauthorized || response.StatusCode == HttpStatusCode.Forbidden))
            {
                if (!this.Configuration.ClientID.IsNullorEmpty())
                {
                    string authHeader = Convert.ToString(req.Parameters.First(x => x.Type == ParameterType.HttpHeader
                             && x.Name == "Authorization").Value);
                    if (!authHeader.IsNullorEmpty())
                    {
                        string[] authValues = authHeader.Split(' ');
                        if (authValues.Length == 2)
                        {
                            UpdateOAuthAccessToken(requiredScopes, authValues[1]);
                            string accessToken = GetOAuthAccessToken(requiredScopes);
                            req.AddHeader("Authorization", "Bearer " + accessToken);
                            response = await client.ExecuteAsync<T>(req, cancellationToken).ConfigureAwait(false);
                        }
                    }

                }
            }
            // if the response type is oneOf/anyOf, call FromJSON to deserialize the data
            if (typeof(Avalara.SDK.Model.AbstractOpenAPISchema).IsAssignableFrom(typeof(T)))
            {
                response.Data = (T)typeof(T).GetMethod("FromJson").Invoke(null, new object[] { response.Content });
            }
            else if (typeof(T).Name == "Stream") // for binary response
            {
                response.Data = (T)(object)new MemoryStream(response.RawBytes);
            }

            InterceptResponse(req, response);

            var result = ToApiResponse(response);
            if (response.ErrorMessage != null)
            {
                result.ErrorText = response.ErrorMessage;
            }

            if (response.Cookies != null && response.Cookies.Count > 0)
            {
                if (result.Cookies == null) result.Cookies = new List<Cookie>();
                foreach (var restResponseCookie in response.Cookies)
                {
                    var cookie = new Cookie(
                        restResponseCookie.Name,
                        restResponseCookie.Value,
                        restResponseCookie.Path,
                        restResponseCookie.Domain
                    )
                    {
                        Comment = restResponseCookie.Comment,
                        CommentUri = restResponseCookie.CommentUri,
                        Discard = restResponseCookie.Discard,
                        Expired = restResponseCookie.Expired,
                        Expires = restResponseCookie.Expires,
                        HttpOnly = restResponseCookie.HttpOnly,
                        Port = restResponseCookie.Port,
                        Secure = restResponseCookie.Secure,
                        Version = restResponseCookie.Version
                    };

                    result.Cookies.Add(cookie);
                }
            }
            return result;
        }

        private void CheckConfiguration()
        {
            if (Configuration == null)
                throw new ArgumentException("configuration cannot be empty");

            if (Configuration.Environment == null)
                throw new ArgumentException("Environment is not set in the configuration");
            if (Configuration.Environment == AvalaraEnvironment.Other)
            { 
                if (string.IsNullOrEmpty(Configuration.BasePath))
                    throw new ArgumentException("BasePath is not set in the configuration");                
            }

        }

        private string GetOAuthAccessToken(string requiredScopes)
        {
            string accessToken = string.Empty;
            if (this.hashScopeTable.ContainsKey(requiredScopes))
            {
                accessToken = Convert.ToString(hashScopeTable[requiredScopes]);
            }
            return accessToken;
        }
        
        [MethodImpl(MethodImplOptions.Synchronized)]
        private void UpdateOAuthAccessToken(string requiredScopes, string access_token= default(string))
        {
            if (GetOAuthAccessToken(requiredScopes).IsNullorEmpty() ||
                GetOAuthAccessToken(requiredScopes).Equals(access_token) )
            {
                if (this.OAuthObj == null)
                {
                    OAuthObj = new Auth.OAuth2ClientCredentials(tokenURL: this.Configuration.TokenURL,
                            clientID: this.Configuration.ClientID,
                            clientSecret: this.Configuration.ClientSecret,
                            requiredScopes : requiredScopes);
                }
                string accessToken = this.OAuthObj.GetAccessToken();
                if (this.hashScopeTable.ContainsKey(requiredScopes))
                {
                    this.hashScopeTable[requiredScopes] = accessToken;
                }
                else
                {
                    this.hashScopeTable.Add(requiredScopes, accessToken);
                }
            }         
            
        }

        #region IAsynchronousClient
        /// <summary>
        /// Make a HTTP GET request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Get, path, options), config, cancellationToken, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP POST request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Post, path, options), config, cancellationToken, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP PUT request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Put, path, options), config, cancellationToken, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP DELETE request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Delete, path, options), config, cancellationToken, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP HEAD request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Head, path, options), config, cancellationToken, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP OPTION request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Options, path, options), config, cancellationToken, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP PATCH request (async).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="cancellationToken">Token that enables callers to cancel the request.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken), string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return ExecAsync<T>(NewRequest(HttpMethod.Patch, path, options), config, cancellationToken, requiredScopes);
        }
        #endregion IAsynchronousClient

        #region ISynchronousClient
        /// <summary>
        /// Make a HTTP GET request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Get<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Get, path, options), config, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP POST request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Post<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Post, path, options), config, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP PUT request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Put<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Put, path, options), config, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP DELETE request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Delete, path, options), config, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP HEAD request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Head<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Head, path, options), config, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP OPTION request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Options<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Options, path, options), config, requiredScopes);
        }

        /// <summary>
        /// Make a HTTP PATCH request (synchronous).
        /// </summary>
        /// <param name="path">The target path (or resource).</param>
        /// <param name="options">The additional request options.</param>
        /// <param name="requiredScopes">requiredScopes for Oauth2</param>
        /// <returns>A Task containing ApiResponse</returns>
        public ApiResponse<T> Patch<T>(string path, RequestOptions options, string requiredScopes = default(string))
        {
            var config = Configuration ?? GlobalConfiguration.Instance;
            return Exec<T>(NewRequest(HttpMethod.Patch, path, options), config, requiredScopes);
        }
        #endregion ISynchronousClient
    }
}
