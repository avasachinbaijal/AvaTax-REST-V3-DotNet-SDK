using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalara.SDK.Model;
using Newtonsoft.Json;
using RestSharp;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// This class supports Client Crendetials OAuth2 grant type
    /// </summary>
    public class OAuth2ClientCredentials : IOAuth
    {
        private const string GRANT_TYPE = "client_credentials";
        /// <summary>
        /// Constructor to initiate Client Crendetials OAuth2 flow
        /// </summary>
        /// <param name="tokenURL"></param>
        /// <param name="clientID"></param>
        /// <param name="clientSecret"></param>
        /// <param name="requiredScopes"></param>
        public OAuth2ClientCredentials(string tokenURL=default(string) , string clientID = default(string), 
            string clientSecret = default(string), string requiredScopes= default(string))
        {
            this.TokenURL = tokenURL;
            this.ClientID = clientID;
            this.ClientSecret = clientSecret;
            this.RequiredScopes = requiredScopes;
            
        }
        /// <summary>
        /// Authorization Server URL for oAuth2 flow
        /// </summary>
        public string AuthorizationURL { get; set; }
        /// <summary>
        /// Token Server URL for oAuth2 flow
        /// </summary>
        public string TokenURL { get; set; }
        /// <summary>
        /// ClientID for oAuth2 flow
        /// </summary>
        public string ClientID { get; set; }
        /// <summary>
        /// ClientSecret for oAuth2 flow
        /// </summary>
        public string ClientSecret { get; set; }
        /// <summary>
        /// List of RequiredScopes
        /// </summary>
        public string RequiredScopes { get; set; }
        /// <summary>
        /// Other Properties to be used for authentication
        /// </summary>
        public Dictionary<string, string> ParameterCollection { get; set; }
        /// <summary>
        /// Method Return the access token
        /// </summary>
        public string GetAccessToken()
        {
            try
            {
                if (TokenURL.IsNullorEmpty())
                {
                    throw new ArgumentException("Token URL is not set in the configuration");
                }
                if (ClientID.IsNullorEmpty())
                {
                    throw new ArgumentException("Client ID is not set in the configuration");
                }
                if (ClientSecret.IsNullorEmpty())
                {
                    throw new ArgumentException("Client Secret is not set in the configuration");
                }
                if (RequiredScopes.IsNullorEmpty())
                {
                    throw new ArgumentException("Scope cannot be empty");
                }

                var client = new RestClient(TokenURL);
                var request = new RestRequest();

                request.Method = Method.POST;
                request.AddHeader("Accept", "application/json");

                request.AddParameter("client_id", ClientID, ParameterType.GetOrPost);
                request.AddParameter("grant_type", "client_credentials", ParameterType.GetOrPost);
                request.AddParameter("client_secret", ClientSecret, ParameterType.GetOrPost);
                request.AddParameter("scope", string.Join(" ", RequiredScopes), ParameterType.GetOrPost);


                var response = client.Execute(request);
                var content = response.Content; // raw content as string 
                int statusCode = (int)response.StatusCode;
                if (statusCode>199  && statusCode < 300)
                {
                    Token tokenObj = JsonConvert.DeserializeObject<Token>(content);
                    return tokenObj.access_token;
                }
                else
                {
                    RestClientError errorObj = JsonConvert.DeserializeObject<RestClientError>(content);
                    throw new Exception(errorObj.errorSummary);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
