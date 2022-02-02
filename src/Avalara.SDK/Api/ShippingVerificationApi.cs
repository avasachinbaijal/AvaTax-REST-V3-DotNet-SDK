/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara Shipping Verification only
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @version    2.4.7
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.SDK.Client;
using Avalara.SDK.Model;

namespace Avalara.SDK.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShippingVerificationApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Removes the transaction from consideration when evaluating regulations that span multiple transactions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns></returns>
        void DeregisterShipment(string companyCode, string transactionCode, string documentType = default(string));

        /// <summary>
        /// Registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns></returns>
        void RegisterShipment(string companyCode, string transactionCode, string documentType = default(string));

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ShippingVerifyResult</returns>
        ShippingVerifyResult RegisterShipmentIfCompliant(string companyCode, string transactionCode, string documentType = default(string));

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations.
        /// </summary>
        /// <remarks>
        /// The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: &#39;*DTC*&#39;, &#39;*Retailer DTC*&#39; * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: &#39;*Litre*&#39;, &#39;*Millilitre*&#39;, &#39;*gallon (US fluid)*&#39;, &#39;*quart (US fluid)*&#39;, &#39;*ounce (fluid US customary)*&#39; * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ShippingVerifyResult</returns>
        ShippingVerifyResult VerifyShipment(string companyCode, string transactionCode, string documentType = default(string));

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShippingVerificationApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Removes the transaction from consideration when evaluating regulations that span multiple transactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeregisterShipmentAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RegisterShipmentAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShippingVerifyResult</returns>
        System.Threading.Tasks.Task<ShippingVerifyResult> RegisterShipmentIfCompliantAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations.
        /// </summary>
        /// <remarks>
        /// The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: &#39;*DTC*&#39;, &#39;*Retailer DTC*&#39; * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: &#39;*Litre*&#39;, &#39;*Millilitre*&#39;, &#39;*gallon (US fluid)*&#39;, &#39;*quart (US fluid)*&#39;, &#39;*ounce (fluid US customary)*&#39; * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShippingVerifyResult</returns>
        System.Threading.Tasks.Task<ShippingVerifyResult> VerifyShipmentAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShippingVerificationApi : IShippingVerificationApiSync, IShippingVerificationApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingVerificationApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public ShippingVerificationApi(Avalara.SDK.Client.ApiClient client)
        {
             SetConfiguration(client);
             this.ExceptionFactory = Avalara.SDK.Client.Configuration.DefaultExceptionFactory;
        }       

        /// <summary>
        /// The client for accessing this underlying API.
        /// </summary>
        private Avalara.SDK.Client.ApiClient Client { get; set; }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        private Avalara.SDK.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        private Avalara.SDK.Client.ExceptionFactory ExceptionFactory
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
        /// Removes the transaction from consideration when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns></returns>
        public void DeregisterShipment(string companyCode, string transactionCode, string documentType = default(string))
        {
            DeregisterShipmentWithHttpInfo(companyCode, transactionCode, documentType);
        }

        /// <summary>
        /// Removes the transaction from consideration when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeregisterShipmentWithHttpInfo(string companyCode, string transactionCode, string documentType = default(string))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->DeregisterShipment");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->DeregisterShipment");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
			// make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration", localVarRequestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeregisterShipment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Removes the transaction from consideration when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeregisterShipmentAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeregisterShipmentWithHttpInfoAsync(companyCode, transactionCode, documentType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Removes the transaction from consideration when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeregisterShipmentWithHttpInfoAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->DeregisterShipment");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->DeregisterShipment");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeregisterShipment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns></returns>
        public void RegisterShipment(string companyCode, string transactionCode, string documentType = default(string))
        {
            RegisterShipmentWithHttpInfo(companyCode, transactionCode, documentType);
        }

        /// <summary>
        /// Registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> RegisterShipmentWithHttpInfo(string companyCode, string transactionCode, string documentType = default(string))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->RegisterShipment");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->RegisterShipment");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
			// make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration", localVarRequestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterShipment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RegisterShipmentAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RegisterShipmentWithHttpInfoAsync(companyCode, transactionCode, documentType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> RegisterShipmentWithHttpInfoAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->RegisterShipment");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->RegisterShipment");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterShipment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ShippingVerifyResult</returns>
        public ShippingVerifyResult RegisterShipmentIfCompliant(string companyCode, string transactionCode, string documentType = default(string))
        {
            Avalara.SDK.Client.ApiResponse<ShippingVerifyResult> localVarResponse = RegisterShipmentIfCompliantWithHttpInfo(companyCode, transactionCode, documentType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ApiResponse of ShippingVerifyResult</returns>
        private Avalara.SDK.Client.ApiResponse<ShippingVerifyResult> RegisterShipmentIfCompliantWithHttpInfo(string companyCode, string transactionCode, string documentType = default(string))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->RegisterShipmentIfCompliant");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->RegisterShipmentIfCompliant");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
			// make the HTTP request
            var localVarResponse = this.Client.Put<ShippingVerifyResult>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registerIfCompliant", localVarRequestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterShipmentIfCompliant", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShippingVerifyResult</returns>
        public async System.Threading.Tasks.Task<ShippingVerifyResult> RegisterShipmentIfCompliantAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<ShippingVerifyResult> localVarResponse = await RegisterShipmentIfCompliantWithHttpInfoAsync(companyCode, transactionCode, documentType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShippingVerifyResult)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<ShippingVerifyResult>> RegisterShipmentIfCompliantWithHttpInfoAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->RegisterShipmentIfCompliant");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->RegisterShipmentIfCompliant");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<ShippingVerifyResult>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registerIfCompliant", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RegisterShipmentIfCompliant", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations. The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: &#39;*DTC*&#39;, &#39;*Retailer DTC*&#39; * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: &#39;*Litre*&#39;, &#39;*Millilitre*&#39;, &#39;*gallon (US fluid)*&#39;, &#39;*quart (US fluid)*&#39;, &#39;*ounce (fluid US customary)*&#39; * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ShippingVerifyResult</returns>
        public ShippingVerifyResult VerifyShipment(string companyCode, string transactionCode, string documentType = default(string))
        {
            Avalara.SDK.Client.ApiResponse<ShippingVerifyResult> localVarResponse = VerifyShipmentWithHttpInfo(companyCode, transactionCode, documentType);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations. The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: &#39;*DTC*&#39;, &#39;*Retailer DTC*&#39; * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: &#39;*Litre*&#39;, &#39;*Millilitre*&#39;, &#39;*gallon (US fluid)*&#39;, &#39;*quart (US fluid)*&#39;, &#39;*ounce (fluid US customary)*&#39; * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <returns>ApiResponse of ShippingVerifyResult</returns>
        private Avalara.SDK.Client.ApiResponse<ShippingVerifyResult> VerifyShipmentWithHttpInfo(string companyCode, string transactionCode, string documentType = default(string))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->VerifyShipment");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->VerifyShipment");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }
			// make the HTTP request
            var localVarResponse = this.Client.Get<ShippingVerifyResult>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/verify", localVarRequestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyShipment", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations. The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: &#39;*DTC*&#39;, &#39;*Retailer DTC*&#39; * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: &#39;*Litre*&#39;, &#39;*Millilitre*&#39;, &#39;*gallon (US fluid)*&#39;, &#39;*quart (US fluid)*&#39;, &#39;*ounce (fluid US customary)*&#39; * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShippingVerifyResult</returns>
        public async System.Threading.Tasks.Task<ShippingVerifyResult> VerifyShipmentAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<ShippingVerifyResult> localVarResponse = await VerifyShipmentWithHttpInfoAsync(companyCode, transactionCode, documentType, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Evaluates a transaction against a set of direct-to-consumer shipping regulations. The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: &#39;*DTC*&#39;, &#39;*Retailer DTC*&#39; * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: &#39;*Litre*&#39;, &#39;*Millilitre*&#39;, &#39;*gallon (US fluid)*&#39;, &#39;*quart (US fluid)*&#39;, &#39;*ounce (fluid US customary)*&#39; * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyCode">The company code of the company that recorded the transaction</param>
        /// <param name="transactionCode">The transaction code to retrieve</param>
        /// <param name="documentType">(Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShippingVerifyResult)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<ShippingVerifyResult>> VerifyShipmentWithHttpInfoAsync(string companyCode, string transactionCode, string documentType = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'companyCode' is set
            if (companyCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'companyCode' when calling ShippingVerificationApi->VerifyShipment");

            // verify the required parameter 'transactionCode' is set
            if (transactionCode == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'transactionCode' when calling ShippingVerificationApi->VerifyShipment");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("companyCode", Avalara.SDK.Client.ClientUtils.ParameterToString(companyCode)); // path parameter
            localVarRequestOptions.PathParameters.Add("transactionCode", Avalara.SDK.Client.ClientUtils.ParameterToString(transactionCode)); // path parameter
            if (documentType != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "documentType", documentType));
            }

            // authentication (BasicAuth) required
            // http basic authentication required
            if (!string.IsNullOrEmpty(this.Configuration.Username) || !string.IsNullOrEmpty(this.Configuration.Password))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Basic " + Avalara.SDK.Client.ClientUtils.Base64Encode(this.Configuration.Username + ":" + this.Configuration.Password));
            }
            // authentication (Bearer) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<ShippingVerifyResult>("/api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/verify", localVarRequestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("VerifyShipment", localVarResponse);
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
            this.Client.SdkVersion = "2.4.7";
            this.Configuration = client.Configuration;
        }
        
    }

    
}
