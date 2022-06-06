/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * foundation
 *
 * Platform foundation consists of services on top of which the Avalara Compliance Cloud platform is built. These services are foundational and provide functionality such as common organization, tenant and user management for the rest of the compliance platform.
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @version    2.4.34
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Avalara.SDK.Client;
using Avalara.SDK.Model.IAMDS;

namespace Avalara.SDK.Api.IAMDS
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResourceApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a resource.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned resource ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns>Resource</returns>
        Resource CreateResource(string avalaraVersion = default(string), string xCorrelationId = default(string), Resource resource = default(Resource));

        /// <summary>
        /// Delete a resource.
        /// </summary>
        /// <remarks>
        /// Deletes the resource by ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void DeleteResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Retrieve a resource.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified resource.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>Resource</returns>
        Resource GetResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), string ifMatch = default(string));

        /// <summary>
        /// Get a list of all permissions on a resource.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permissions a resource belongs to which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * name
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>PermissionList</returns>
        PermissionList ListResourcePermissions(string resourceId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Get all resources which the user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all resources the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties: * displayName * namespace * system/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ResourceList</returns>
        ResourceList ListResources(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Update the passed in fields from the message on the resource.
        /// </summary>
        /// <remarks>
        /// Updates only the fields passed in for the specified resource.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns></returns>
        void PatchResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource));

        /// <summary>
        /// Update all fields on a resource.
        /// </summary>
        /// <remarks>
        /// Replaces the specified resource with the resource in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns></returns>
        void ReplaceResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource));

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IResourceApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a resource.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned resource ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Resource</returns>
        System.Threading.Tasks.Task<Resource> CreateResourceAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a resource.
        /// </summary>
        /// <remarks>
        /// Deletes the resource by ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a resource.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified resource.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Resource</returns>
        System.Threading.Tasks.Task<Resource> GetResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a list of all permissions on a resource.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permissions a resource belongs to which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * name
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PermissionList</returns>
        System.Threading.Tasks.Task<PermissionList> ListResourcePermissionsAsync(string resourceId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all resources which the user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all resources the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties: * displayName * namespace * system/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceList</returns>
        System.Threading.Tasks.Task<ResourceList> ListResourcesAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update the passed in fields from the message on the resource.
        /// </summary>
        /// <remarks>
        /// Updates only the fields passed in for the specified resource.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update all fields on a resource.
        /// </summary>
        /// <remarks>
        /// Replaces the specified resource with the resource in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReplaceResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ResourceApi : IResourceApiSync, IResourceApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public ResourceApi(Avalara.SDK.Client.ApiClient client)
        {
             SetConfiguration(client);
             this.ExceptionFactory = Avalara.SDK.Client.Configuration.DefaultExceptionFactory;
        }       

        /// <summary>
        /// The client for accessing this underlying API.
        /// </summary>
        private Avalara.SDK.Client.ApiClient Client { get; set; }

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
        /// Create a resource. The response contains the same object as posted and fills in the newly assigned resource ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns>Resource</returns>
        public Resource CreateResource(string avalaraVersion = default(string), string xCorrelationId = default(string), Resource resource = default(Resource))
        {
            Avalara.SDK.Client.ApiResponse<Resource> localVarResponse = CreateResourceWithHttpInfo(avalaraVersion, xCorrelationId, resource);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a resource. The response contains the same object as posted and fills in the newly assigned resource ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns>ApiResponse of Resource</returns>
        private Avalara.SDK.Client.ApiResponse<Resource> CreateResourceWithHttpInfo(string avalaraVersion = default(string), string xCorrelationId = default(string), Resource resource = default(Resource))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            localVarRequestOptions.Data = resource;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Resource>("/resources", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a resource. The response contains the same object as posted and fills in the newly assigned resource ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Resource</returns>
        public async System.Threading.Tasks.Task<Resource> CreateResourceAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Resource> localVarResponse = await CreateResourceWithHttpInfoAsync(avalaraVersion, xCorrelationId, resource, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a resource. The response contains the same object as posted and fills in the newly assigned resource ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Resource)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Resource>> CreateResourceWithHttpInfoAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            localVarRequestOptions.Data = resource;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Resource>("/resources", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a resource. Deletes the resource by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void DeleteResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            DeleteResourceWithHttpInfo(resourceId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Delete a resource. Deletes the resource by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeleteResourceWithHttpInfo(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->DeleteResource");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/resources/{resource-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a resource. Deletes the resource by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteResourceWithHttpInfoAsync(resourceId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a resource. Deletes the resource by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeleteResourceWithHttpInfoAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->DeleteResource");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/resources/{resource-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a resource. Retrieves the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>Resource</returns>
        public Resource GetResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), string ifMatch = default(string))
        {
            Avalara.SDK.Client.ApiResponse<Resource> localVarResponse = GetResourceWithHttpInfo(resourceId, avalaraVersion, xCorrelationId, ifNoneMatch, ifMatch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a resource. Retrieves the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>ApiResponse of Resource</returns>
        private Avalara.SDK.Client.ApiResponse<Resource> GetResourceWithHttpInfo(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), string ifMatch = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->GetResource");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            if (ifNoneMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-None-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifNoneMatch)); // header parameter
            }
            if (ifMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifMatch)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<Resource>("/resources/{resource-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a resource. Retrieves the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Resource</returns>
        public async System.Threading.Tasks.Task<Resource> GetResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Resource> localVarResponse = await GetResourceWithHttpInfoAsync(resourceId, avalaraVersion, xCorrelationId, ifNoneMatch, ifMatch, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a resource. Retrieves the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Resource)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Resource>> GetResourceWithHttpInfoAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->GetResource");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            if (ifNoneMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-None-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifNoneMatch)); // header parameter
            }
            if (ifMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifMatch)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Resource>("/resources/{resource-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of all permissions on a resource. Retrieve a list of all permissions a resource belongs to which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * name
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>PermissionList</returns>
        public PermissionList ListResourcePermissions(string resourceId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<PermissionList> localVarResponse = ListResourcePermissionsWithHttpInfo(resourceId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of all permissions on a resource. Retrieve a list of all permissions a resource belongs to which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * name
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of PermissionList</returns>
        private Avalara.SDK.Client.ApiResponse<PermissionList> ListResourcePermissionsWithHttpInfo(string resourceId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->ListResourcePermissions");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", filter));
            }
            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", orderBy));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (countOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", countOnly));
            }
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PermissionList>("/resources/{resource-id}/permissions", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListResourcePermissions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of all permissions on a resource. Retrieve a list of all permissions a resource belongs to which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * name
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PermissionList</returns>
        public async System.Threading.Tasks.Task<PermissionList> ListResourcePermissionsAsync(string resourceId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<PermissionList> localVarResponse = await ListResourcePermissionsWithHttpInfoAsync(resourceId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of all permissions on a resource. Retrieve a list of all permissions a resource belongs to which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * name
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PermissionList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<PermissionList>> ListResourcePermissionsWithHttpInfoAsync(string resourceId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->ListResourcePermissions");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", filter));
            }
            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", orderBy));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (countOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", countOnly));
            }
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<PermissionList>("/resources/{resource-id}/permissions", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListResourcePermissions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all resources which the user has access to. Retrieve a list of all resources the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties: * displayName * namespace * system/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ResourceList</returns>
        public ResourceList ListResources(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<ResourceList> localVarResponse = ListResourcesWithHttpInfo(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all resources which the user has access to. Retrieve a list of all resources the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties: * displayName * namespace * system/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of ResourceList</returns>
        private Avalara.SDK.Client.ApiResponse<ResourceList> ListResourcesWithHttpInfo(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", filter));
            }
            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", orderBy));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (countOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", countOnly));
            }
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceList>("/resources", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListResources", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all resources which the user has access to. Retrieve a list of all resources the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties: * displayName * namespace * system/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceList</returns>
        public async System.Threading.Tasks.Task<ResourceList> ListResourcesAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<ResourceList> localVarResponse = await ListResourcesWithHttpInfoAsync(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all resources which the user has access to. Retrieve a list of all resources the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties: * displayName * namespace * system/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<ResourceList>> ListResourcesWithHttpInfoAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$filter", filter));
            }
            if (top != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$top", top));
            }
            if (skip != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$skip", skip));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", orderBy));
            }
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (countOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", countOnly));
            }
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<ResourceList>("/resources", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListResources", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the passed in fields from the message on the resource. Updates only the fields passed in for the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns></returns>
        public void PatchResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource))
        {
            PatchResourceWithHttpInfo(resourceId, avalaraVersion, xCorrelationId, ifMatch, resource);
        }

        /// <summary>
        /// Update the passed in fields from the message on the resource. Updates only the fields passed in for the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> PatchResourceWithHttpInfo(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->PatchResource");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            if (ifMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifMatch)); // header parameter
            }
            localVarRequestOptions.Data = resource;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/resources/{resource-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the passed in fields from the message on the resource. Updates only the fields passed in for the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PatchResourceWithHttpInfoAsync(resourceId, avalaraVersion, xCorrelationId, ifMatch, resource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the passed in fields from the message on the resource. Updates only the fields passed in for the specified resource.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> PatchResourceWithHttpInfoAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->PatchResource");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            if (ifMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifMatch)); // header parameter
            }
            localVarRequestOptions.Data = resource;

            // make the HTTP request
			var localVarResponse = await this.Client.PatchAsync<Object>("/resources/{resource-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a resource. Replaces the specified resource with the resource in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns></returns>
        public void ReplaceResource(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource))
        {
            ReplaceResourceWithHttpInfo(resourceId, avalaraVersion, xCorrelationId, ifMatch, resource);
        }

        /// <summary>
        /// Update all fields on a resource. Replaces the specified resource with the resource in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> ReplaceResourceWithHttpInfo(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->ReplaceResource");

            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };

            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            if (ifMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifMatch)); // header parameter
            }
            localVarRequestOptions.Data = resource;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/resources/{resource-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceResource", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a resource. Replaces the specified resource with the resource in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReplaceResourceAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ReplaceResourceWithHttpInfoAsync(resourceId, avalaraVersion, xCorrelationId, ifMatch, resource, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update all fields on a resource. Replaces the specified resource with the resource in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="resourceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="resource"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> ReplaceResourceWithHttpInfoAsync(string resourceId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Resource resource = default(Resource), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'resourceId' is set
            if (resourceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'resourceId' when calling ResourceApi->ReplaceResource");


            Avalara.SDK.Client.RequestOptions localVarRequestOptions = new Avalara.SDK.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "text/plain"
            };


            var localVarContentType = Avalara.SDK.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Avalara.SDK.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("resource-id", Avalara.SDK.Client.ClientUtils.ParameterToString(resourceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }
            if (ifMatch != null)
            {
                localVarRequestOptions.HeaderParameters.Add("If-Match", Avalara.SDK.Client.ClientUtils.ParameterToString(ifMatch)); // header parameter
            }
            localVarRequestOptions.Data = resource;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/resources/{resource-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceResource", localVarResponse);
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
            this.Client.SdkVersion = "2.4.34";
        }
        
    }

    
}
