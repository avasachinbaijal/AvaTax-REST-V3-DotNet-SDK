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
    public interface IPermissionApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a permission.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned permission ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns>Permission</returns>
        Permission CreatePermission(string avalaraVersion = default(string), string xCorrelationId = default(string), Permission permission = default(Permission));

        /// <summary>
        /// Delete a permission.
        /// </summary>
        /// <remarks>
        /// Deletes the permission by ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        void DeletePermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string));

        /// <summary>
        /// Retrieve a permission.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified permission.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>Permission</returns>
        Permission GetPermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string));

        /// <summary>
        /// Get all permissions which the user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permissions the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * resource/identifier * name
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
        /// <returns>PermissionList</returns>
        PermissionList ListPermissions(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Update the fields present in the message body on the permission.
        /// </summary>
        /// <remarks>
        /// Updates only the fields passed in for the specified permission.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns></returns>
        void PatchPermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission));

        /// <summary>
        /// Update all fields on a permission.
        /// </summary>
        /// <remarks>
        /// Replaces the specified permission with the permission in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns></returns>
        void ReplacePermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission));

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPermissionApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a permission.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned permission ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Permission</returns>
        System.Threading.Tasks.Task<Permission> CreatePermissionAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a permission.
        /// </summary>
        /// <remarks>
        /// Deletes the permission by ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a permission.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified permission.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Permission</returns>
        System.Threading.Tasks.Task<Permission> GetPermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all permissions which the user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all permissions the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * resource/identifier * name
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
        /// <returns>Task of PermissionList</returns>
        System.Threading.Tasks.Task<PermissionList> ListPermissionsAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update the fields present in the message body on the permission.
        /// </summary>
        /// <remarks>
        /// Updates only the fields passed in for the specified permission.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchPermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update all fields on a permission.
        /// </summary>
        /// <remarks>
        /// Replaces the specified permission with the permission in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReplacePermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PermissionApi : IPermissionApiSync, IPermissionApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public PermissionApi(Avalara.SDK.Client.ApiClient client)
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
        /// Create a permission. The response contains the same object as posted and fills in the newly assigned permission ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns>Permission</returns>
        public Permission CreatePermission(string avalaraVersion = default(string), string xCorrelationId = default(string), Permission permission = default(Permission))
        {
            Avalara.SDK.Client.ApiResponse<Permission> localVarResponse = CreatePermissionWithHttpInfo(avalaraVersion, xCorrelationId, permission);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a permission. The response contains the same object as posted and fills in the newly assigned permission ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns>ApiResponse of Permission</returns>
        private Avalara.SDK.Client.ApiResponse<Permission> CreatePermissionWithHttpInfo(string avalaraVersion = default(string), string xCorrelationId = default(string), Permission permission = default(Permission))
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
            localVarRequestOptions.Data = permission;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Permission>("/permissions", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a permission. The response contains the same object as posted and fills in the newly assigned permission ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Permission</returns>
        public async System.Threading.Tasks.Task<Permission> CreatePermissionAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Permission> localVarResponse = await CreatePermissionWithHttpInfoAsync(avalaraVersion, xCorrelationId, permission, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a permission. The response contains the same object as posted and fills in the newly assigned permission ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Permission)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Permission>> CreatePermissionWithHttpInfoAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.Data = permission;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Permission>("/permissions", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreatePermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a permission. Deletes the permission by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        public void DeletePermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            DeletePermissionWithHttpInfo(permissionId, avalaraVersion, xCorrelationId, ifMatch);
        }

        /// <summary>
        /// Delete a permission. Deletes the permission by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeletePermissionWithHttpInfo(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->DeletePermission");

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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/permissions/{permission-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a permission. Deletes the permission by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeletePermissionWithHttpInfoAsync(permissionId, avalaraVersion, xCorrelationId, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a permission. Deletes the permission by ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeletePermissionWithHttpInfoAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->DeletePermission");


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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/permissions/{permission-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeletePermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a permission. Retrieves the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>Permission</returns>
        public Permission GetPermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            Avalara.SDK.Client.ApiResponse<Permission> localVarResponse = GetPermissionWithHttpInfo(permissionId, avalaraVersion, xCorrelationId, ifNoneMatch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a permission. Retrieves the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>ApiResponse of Permission</returns>
        private Avalara.SDK.Client.ApiResponse<Permission> GetPermissionWithHttpInfo(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->GetPermission");

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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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

            // make the HTTP request
            var localVarResponse = this.Client.Get<Permission>("/permissions/{permission-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a permission. Retrieves the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Permission</returns>
        public async System.Threading.Tasks.Task<Permission> GetPermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Permission> localVarResponse = await GetPermissionWithHttpInfoAsync(permissionId, avalaraVersion, xCorrelationId, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a permission. Retrieves the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Permission)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Permission>> GetPermissionWithHttpInfoAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->GetPermission");


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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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

            // make the HTTP request
			var localVarResponse = await this.Client.GetAsync<Permission>("/permissions/{permission-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetPermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all permissions which the user has access to. Retrieve a list of all permissions the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * resource/identifier * name
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
        /// <returns>PermissionList</returns>
        public PermissionList ListPermissions(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<PermissionList> localVarResponse = ListPermissionsWithHttpInfo(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all permissions which the user has access to. Retrieve a list of all permissions the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * resource/identifier * name
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
        /// <returns>ApiResponse of PermissionList</returns>
        private Avalara.SDK.Client.ApiResponse<PermissionList> ListPermissionsWithHttpInfo(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
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
            var localVarResponse = this.Client.Get<PermissionList>("/permissions", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPermissions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all permissions which the user has access to. Retrieve a list of all permissions the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * resource/identifier * name
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
        /// <returns>Task of PermissionList</returns>
        public async System.Threading.Tasks.Task<PermissionList> ListPermissionsAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<PermissionList> localVarResponse = await ListPermissionsWithHttpInfoAsync(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all permissions which the user has access to. Retrieve a list of all permissions the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * resource/identifier * name
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
        /// <returns>Task of ApiResponse (PermissionList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<PermissionList>> ListPermissionsWithHttpInfoAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
			var localVarResponse = await this.Client.GetAsync<PermissionList>("/permissions", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPermissions", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields present in the message body on the permission. Updates only the fields passed in for the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns></returns>
        public void PatchPermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission))
        {
            PatchPermissionWithHttpInfo(permissionId, avalaraVersion, xCorrelationId, ifMatch, permission);
        }

        /// <summary>
        /// Update the fields present in the message body on the permission. Updates only the fields passed in for the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> PatchPermissionWithHttpInfo(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->PatchPermission");

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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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
            localVarRequestOptions.Data = permission;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/permissions/{permission-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields present in the message body on the permission. Updates only the fields passed in for the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchPermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PatchPermissionWithHttpInfoAsync(permissionId, avalaraVersion, xCorrelationId, ifMatch, permission, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the fields present in the message body on the permission. Updates only the fields passed in for the specified permission.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> PatchPermissionWithHttpInfoAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->PatchPermission");


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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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
            localVarRequestOptions.Data = permission;

            // make the HTTP request
			var localVarResponse = await this.Client.PatchAsync<Object>("/permissions/{permission-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchPermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a permission. Replaces the specified permission with the permission in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns></returns>
        public void ReplacePermission(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission))
        {
            ReplacePermissionWithHttpInfo(permissionId, avalaraVersion, xCorrelationId, ifMatch, permission);
        }

        /// <summary>
        /// Update all fields on a permission. Replaces the specified permission with the permission in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> ReplacePermissionWithHttpInfo(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->ReplacePermission");

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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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
            localVarRequestOptions.Data = permission;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/permissions/{permission-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplacePermission", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a permission. Replaces the specified permission with the permission in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReplacePermissionAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ReplacePermissionWithHttpInfoAsync(permissionId, avalaraVersion, xCorrelationId, ifMatch, permission, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update all fields on a permission. Replaces the specified permission with the permission in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="permissionId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="permission"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> ReplacePermissionWithHttpInfoAsync(string permissionId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Permission permission = default(Permission), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'permissionId' is set
            if (permissionId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'permissionId' when calling PermissionApi->ReplacePermission");


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

            localVarRequestOptions.PathParameters.Add("permission-id", Avalara.SDK.Client.ClientUtils.ParameterToString(permissionId)); // path parameter
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
            localVarRequestOptions.Data = permission;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/permissions/{permission-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplacePermission", localVarResponse);
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
