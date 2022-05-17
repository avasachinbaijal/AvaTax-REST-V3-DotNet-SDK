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
 * @version    2.4.33
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
    public interface IUserApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a user.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned user ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns>User</returns>
        User CreateUser(string avalaraVersion = default(string), string xCorrelationId = default(string), User user = default(User));

        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>
        /// Deletes the specified user.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        void DeleteUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string));

        /// <summary>
        /// Retrieve a user.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user which the current ID has access to.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>User</returns>
        User GetUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string));

        /// <summary>
        /// Your GET endpoint
        /// </summary>
        /// <remarks>
        /// Retrieve a list of acconts that the user is associated with.  Filterable properties:   * displayName * organization/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>TenantList</returns>
        TenantList GetUserTenants(string userId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// List all users which the current user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all users the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
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
        /// <returns>UserList</returns>
        UserList ListUsers(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Update the fields within the message body on the user.
        /// </summary>
        /// <remarks>
        /// Updates a user, only applying the changes delivered in the payload. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns></returns>
        void PatchUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User));

        /// <summary>
        /// Update all fields on a user.
        /// </summary>
        /// <remarks>
        /// Replaces the specified user with the user in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns></returns>
        void ReplaceUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User));

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create a user.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned user ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> CreateUserAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a user.
        /// </summary>
        /// <remarks>
        /// Deletes the specified user.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieve a user.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific user which the current ID has access to.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        System.Threading.Tasks.Task<User> GetUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Your GET endpoint
        /// </summary>
        /// <remarks>
        /// Retrieve a list of acconts that the user is associated with.  Filterable properties:   * displayName * organization/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantList</returns>
        System.Threading.Tasks.Task<TenantList> GetUserTenantsAsync(string userId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all users which the current user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all users the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
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
        /// <returns>Task of UserList</returns>
        System.Threading.Tasks.Task<UserList> ListUsersAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update the fields within the message body on the user.
        /// </summary>
        /// <remarks>
        /// Updates a user, only applying the changes delivered in the payload. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update all fields on a user.
        /// </summary>
        /// <remarks>
        /// Replaces the specified user with the user in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReplaceUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserApi : IUserApiSync, IUserApiAsync
    {
        private const string requiredScopes = "_SAMPLE_SCOPES_";
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public UserApi(Avalara.SDK.Client.ApiClient client)
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
        /// Create a user. The response contains the same object as posted and fills in the newly assigned user ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns>User</returns>
        public User CreateUser(string avalaraVersion = default(string), string xCorrelationId = default(string), User user = default(User))
        {
            Avalara.SDK.Client.ApiResponse<User> localVarResponse = CreateUserWithHttpInfo(avalaraVersion, xCorrelationId, user);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a user. The response contains the same object as posted and fills in the newly assigned user ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns>ApiResponse of User</returns>
        private Avalara.SDK.Client.ApiResponse<User> CreateUserWithHttpInfo(string avalaraVersion = default(string), string xCorrelationId = default(string), User user = default(User))
        {
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
            localVarRequestOptions.Data = user;

            // make the HTTP request
            var localVarResponse = this.Client.Post<User>("/users", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a user. The response contains the same object as posted and fills in the newly assigned user ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> CreateUserAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<User> localVarResponse = await CreateUserWithHttpInfoAsync(avalaraVersion, xCorrelationId, user, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a user. The response contains the same object as posted and fills in the newly assigned user ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<User>> CreateUserWithHttpInfoAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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
            localVarRequestOptions.Data = user;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<User>("/users", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user. Deletes the specified user.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        public void DeleteUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            DeleteUserWithHttpInfo(userId, avalaraVersion, xCorrelationId, ifMatch);
        }

        /// <summary>
        /// Delete a user. Deletes the specified user.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeleteUserWithHttpInfo(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->DeleteUser");

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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            var localVarResponse = this.Client.Delete<Object>("/users/{user-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user. Deletes the specified user.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteUserWithHttpInfoAsync(userId, avalaraVersion, xCorrelationId, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a user. Deletes the specified user.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeleteUserWithHttpInfoAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->DeleteUser");


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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
			var localVarResponse = await this.Client.DeleteAsync<Object>("/users/{user-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a user. Retrieves a specific user which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>User</returns>
        public User GetUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            Avalara.SDK.Client.ApiResponse<User> localVarResponse = GetUserWithHttpInfo(userId, avalaraVersion, xCorrelationId, ifNoneMatch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a user. Retrieves a specific user which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>ApiResponse of User</returns>
        private Avalara.SDK.Client.ApiResponse<User> GetUserWithHttpInfo(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUser");

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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            var localVarResponse = this.Client.Get<User>("/users/{user-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Retrieve a user. Retrieves a specific user which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of User</returns>
        public async System.Threading.Tasks.Task<User> GetUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<User> localVarResponse = await GetUserWithHttpInfoAsync(userId, avalaraVersion, xCorrelationId, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve a user. Retrieves a specific user which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (User)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<User>> GetUserWithHttpInfoAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUser");


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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<User>("/users/{user-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Your GET endpoint Retrieve a list of acconts that the user is associated with.  Filterable properties:   * displayName * organization/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>TenantList</returns>
        public TenantList GetUserTenants(string userId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<TenantList> localVarResponse = GetUserTenantsWithHttpInfo(userId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Your GET endpoint Retrieve a list of acconts that the user is associated with.  Filterable properties:   * displayName * organization/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of TenantList</returns>
        private Avalara.SDK.Client.ApiResponse<TenantList> GetUserTenantsWithHttpInfo(string userId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserTenants");

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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            var localVarResponse = this.Client.Get<TenantList>("/users/{user-id}/tenants", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserTenants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Your GET endpoint Retrieve a list of acconts that the user is associated with.  Filterable properties:   * displayName * organization/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TenantList</returns>
        public async System.Threading.Tasks.Task<TenantList> GetUserTenantsAsync(string userId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<TenantList> localVarResponse = await GetUserTenantsWithHttpInfoAsync(userId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Your GET endpoint Retrieve a list of acconts that the user is associated with.  Filterable properties:   * displayName * organization/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TenantList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<TenantList>> GetUserTenantsWithHttpInfoAsync(string userId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->GetUserTenants");


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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<TenantList>("/users/{user-id}/tenants", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserTenants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all users which the current user has access to. Retrieve a list of all users the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
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
        /// <returns>UserList</returns>
        public UserList ListUsers(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<UserList> localVarResponse = ListUsersWithHttpInfo(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all users which the current user has access to. Retrieve a list of all users the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
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
        /// <returns>ApiResponse of UserList</returns>
        private Avalara.SDK.Client.ApiResponse<UserList> ListUsersWithHttpInfo(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
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
            var localVarResponse = this.Client.Get<UserList>("/users", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all users which the current user has access to. Retrieve a list of all users the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
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
        /// <returns>Task of UserList</returns>
        public async System.Threading.Tasks.Task<UserList> ListUsersAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<UserList> localVarResponse = await ListUsersWithHttpInfoAsync(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all users which the current user has access to. Retrieve a list of all users the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
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
        /// <returns>Task of ApiResponse (UserList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<UserList>> ListUsersWithHttpInfoAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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
			var localVarResponse = await this.Client.GetAsync<UserList>("/users", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields within the message body on the user. Updates a user, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns></returns>
        public void PatchUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User))
        {
            PatchUserWithHttpInfo(userId, avalaraVersion, xCorrelationId, ifMatch, user);
        }

        /// <summary>
        /// Update the fields within the message body on the user. Updates a user, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> PatchUserWithHttpInfo(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->PatchUser");

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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            localVarRequestOptions.Data = user;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/users/{user-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields within the message body on the user. Updates a user, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PatchUserWithHttpInfoAsync(userId, avalaraVersion, xCorrelationId, ifMatch, user, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the fields within the message body on the user. Updates a user, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> PatchUserWithHttpInfoAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->PatchUser");


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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            localVarRequestOptions.Data = user;

            // make the HTTP request
			var localVarResponse = await this.Client.PatchAsync<Object>("/users/{user-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a user. Replaces the specified user with the user in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns></returns>
        public void ReplaceUser(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User))
        {
            ReplaceUserWithHttpInfo(userId, avalaraVersion, xCorrelationId, ifMatch, user);
        }

        /// <summary>
        /// Update all fields on a user. Replaces the specified user with the user in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> ReplaceUserWithHttpInfo(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->ReplaceUser");

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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            localVarRequestOptions.Data = user;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/users/{user-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceUser", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a user. Replaces the specified user with the user in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReplaceUserAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ReplaceUserWithHttpInfoAsync(userId, avalaraVersion, xCorrelationId, ifMatch, user, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update all fields on a user. Replaces the specified user with the user in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="userId">Id for the user to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> ReplaceUserWithHttpInfoAsync(string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), User user = default(User), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling UserApi->ReplaceUser");


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

            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
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
            localVarRequestOptions.Data = user;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/users/{user-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceUser", localVarResponse);
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
            this.Client.SdkVersion = "2.4.33";
        }
        
    }

    
}
