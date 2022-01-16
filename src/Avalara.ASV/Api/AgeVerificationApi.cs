/*
 Avalara API Client Library
 * Avalara Shipping Verification for Beverage Alcohol
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *
 * The version of SDK  : 22.1.0
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.ASV.Client;
using Avalara.ASV.Model;

namespace Avalara.ASV.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgeVerificationApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age.
        /// </summary>
        /// <remarks>
        /// The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </remarks>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <returns>AgeVerifyResult</returns>
        AgeVerifyResult VerifyAge(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?));

        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age.
        /// </summary>
        /// <remarks>
        /// The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </remarks>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <returns>ApiResponse of AgeVerifyResult</returns>
        ApiResponse<AgeVerifyResult> VerifyAgeWithHttpInfo(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAgeVerificationApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age.
        /// </summary>
        /// <remarks>
        /// The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </remarks>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AgeVerifyResult</returns>
        System.Threading.Tasks.Task<AgeVerifyResult> VerifyAgeAsync(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age.
        /// </summary>
        /// <remarks>
        /// The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </remarks>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AgeVerifyResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgeVerifyResult>> VerifyAgeWithHttpInfoAsync(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AgeVerificationApi : IAgeVerificationApiSync, IAgeVerificationApiAsync
    {
        private Avalara.ASV.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeVerificationApi"/> class
        /// </summary>
        public AgeVerificationApi()
        {
            this.ExceptionFactory = Avalara.ASV.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgeVerificationApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public AgeVerificationApi(Avalara.ASV.Client.ApiClient client)
        {
             SetConfiguration(client);
             this.ExceptionFactory = Avalara.ASV.Client.Configuration.DefaultExceptionFactory;
        }       

        /// <summary>
        /// The client for accessing this underlying API.
        /// </summary>
        private Avalara.ASV.Client.ApiClient Client { get; set; }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        private Avalara.ASV.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        private Avalara.ASV.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Set the API client.
        /// </summary>
        /// <param name="client">The client interface for API access.</param>
        public void SetApiClient(Avalara.ASV.Client.ApiClient client)
        {
            SetConfiguration(client);
        }

        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age. The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </summary>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <returns>AgeVerifyResult</returns>
        public AgeVerifyResult VerifyAge(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?))
        {
            CheckClient();
            Avalara.ASV.Client.ApiResponse<AgeVerifyResult> localVarResponse = VerifyAgeWithHttpInfo(ageVerifyRequest, simulatedFailureCode);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age. The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </summary>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <returns>ApiResponse of AgeVerifyResult</returns>
        public Avalara.ASV.Client.ApiResponse<AgeVerifyResult> VerifyAgeWithHttpInfo(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?))
        {
            // verify the required parameter 'ageVerifyRequest' is set
            if (ageVerifyRequest == null)
                throw new Avalara.ASV.Client.ApiException(400, "Missing required parameter 'ageVerifyRequest' when calling AgeVerificationApi->VerifyAge");

            Avalara.ASV.Client.RequestOptions localVarRequestOptions = new Avalara.ASV.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.ASV.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.ASV.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (simulatedFailureCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.ASV.Client.ClientUtils.ParameterToMultiMap("", "simulatedFailureCode", simulatedFailureCode));
            }
            localVarRequestOptions.Data = ageVerifyRequest;

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.ASV.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
			// make the HTTP request
            var localVarResponse = this.Client.Post<AgeVerifyResult>("/api/v2/ageverification/verify", localVarRequestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyAge", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age. The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </summary>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AgeVerifyResult</returns>
        public async System.Threading.Tasks.Task<AgeVerifyResult> VerifyAgeAsync(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
             CheckClient();
            Avalara.ASV.Client.ApiResponse<AgeVerifyResult> localVarResponse = await VerifyAgeWithHttpInfoAsync(ageVerifyRequest, simulatedFailureCode, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Determines whether an individual meets or exceeds the minimum legal drinking age. The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*
        /// </summary>
        /// <exception cref="Avalara.ASV.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ageVerifyRequest">Information about the individual whose age is being verified.</param>
        /// <param name="simulatedFailureCode">(Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AgeVerifyResult)</returns>
        public async System.Threading.Tasks.Task<Avalara.ASV.Client.ApiResponse<AgeVerifyResult>> VerifyAgeWithHttpInfoAsync(AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = default(AgeVerifyFailureCode?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'ageVerifyRequest' is set
            if (ageVerifyRequest == null)
                throw new Avalara.ASV.Client.ApiException(400, "Missing required parameter 'ageVerifyRequest' when calling AgeVerificationApi->VerifyAge");


            Avalara.ASV.Client.RequestOptions localVarRequestOptions = new Avalara.ASV.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.ASV.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.ASV.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (simulatedFailureCode != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.ASV.Client.ClientUtils.ParameterToMultiMap("", "simulatedFailureCode", simulatedFailureCode));
            }
            localVarRequestOptions.Data = ageVerifyRequest;

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.ASV.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
			localVarRequestOptions.HeaderParameters.Add("X-Avalara-Client","22.1.0");
            var localVarResponse = await this.Client.PostAsync<AgeVerifyResult>("/api/v2/ageverification/verify", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyAge", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set the configuration object in APIClient
        /// </summary>        
        private void SetConfiguration(ApiClient client)
        {
            if (client == null) throw new ArgumentNullException("ApiClient");
            if (client.Configuration == null) throw new ArgumentNullException("ApiClient.Configuration");

            this.Client = client;
            this.Client.SdkVersion = "22.1.0";
            this.Configuration = client.Configuration;
        }
        /// <summary>
        /// Check if APIClient is set
        /// </summary>
        /// <value>An instance of the Configuration</value>
        private void CheckClient()
        {
            if (this.Client == null) throw new ArgumentNullException("ApiClient is not set");
            if (this.Client.Configuration == null) throw new ArgumentNullException("ApiClient.Configuration is not set");
        }
    }

    
}