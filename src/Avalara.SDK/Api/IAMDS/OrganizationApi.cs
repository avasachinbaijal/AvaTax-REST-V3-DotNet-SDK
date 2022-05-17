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
    public interface IOrganizationApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Create an organization.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned organization ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns>Organization</returns>
        Organization CreateOrganizations(string avalaraVersion = default(string), string xCorrelationId = default(string), Organization organization = default(Organization));

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// Deletes the specified organization.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        void DeleteOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string));

        /// <summary>
        /// Get an organization.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific organization which the current ID has access to.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>Organization</returns>
        Organization GetOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string));

        /// <summary>
        /// Get all apps within an organization.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of applications associated with an organization.  Filterable properties:   * displayName * type * tenants/identifier * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>AppList</returns>
        AppList ListOrganizationApps(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Get all tenants within an organization.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all tenants within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>TenantList</returns>
        TenantList ListOrganizationTenants(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Get all users within an organization.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all users within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>UserList</returns>
        UserList ListOrganizationUsers(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// List all organizations which the user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all organizations the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
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
        /// <returns>OrganizationList</returns>
        OrganizationList ListOrganizations(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Update the fields present in the message body on the organization.
        /// </summary>
        /// <remarks>
        /// Updates an organization, only applying the changes delivered in the payload. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns></returns>
        void PatchOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization));

        /// <summary>
        /// Update all fields on an organization.
        /// </summary>
        /// <remarks>
        /// Replaces the specified organization with the organization in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns></returns>
        void ReplaceOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization));

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrganizationApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Create an organization.
        /// </summary>
        /// <remarks>
        /// The response contains the same object as posted and fills in the newly assigned organization ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> CreateOrganizationsAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete an organization.
        /// </summary>
        /// <remarks>
        /// Deletes the specified organization.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get an organization.
        /// </summary>
        /// <remarks>
        /// Retrieves a specific organization which the current ID has access to.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Organization</returns>
        System.Threading.Tasks.Task<Organization> GetOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all apps within an organization.
        /// </summary>
        /// <remarks>
        /// Retrieves a list of applications associated with an organization.  Filterable properties:   * displayName * type * tenants/identifier * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppList</returns>
        System.Threading.Tasks.Task<AppList> ListOrganizationAppsAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all tenants within an organization.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all tenants within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
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
        System.Threading.Tasks.Task<TenantList> ListOrganizationTenantsAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all users within an organization.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all users within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
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
        System.Threading.Tasks.Task<UserList> ListOrganizationUsersAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// List all organizations which the user has access to.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all organizations the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
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
        /// <returns>Task of OrganizationList</returns>
        System.Threading.Tasks.Task<OrganizationList> ListOrganizationsAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update the fields present in the message body on the organization.
        /// </summary>
        /// <remarks>
        /// Updates an organization, only applying the changes delivered in the payload. 
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update all fields on an organization.
        /// </summary>
        /// <remarks>
        /// Replaces the specified organization with the organization in the body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReplaceOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrganizationApi : IOrganizationApiSync, IOrganizationApiAsync
    {
        private const string requiredScopes = "_SAMPLE_SCOPES_";
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public OrganizationApi(Avalara.SDK.Client.ApiClient client)
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
        /// Create an organization. The response contains the same object as posted and fills in the newly assigned organization ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns>Organization</returns>
        public Organization CreateOrganizations(string avalaraVersion = default(string), string xCorrelationId = default(string), Organization organization = default(Organization))
        {
            Avalara.SDK.Client.ApiResponse<Organization> localVarResponse = CreateOrganizationsWithHttpInfo(avalaraVersion, xCorrelationId, organization);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an organization. The response contains the same object as posted and fills in the newly assigned organization ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        private Avalara.SDK.Client.ApiResponse<Organization> CreateOrganizationsWithHttpInfo(string avalaraVersion = default(string), string xCorrelationId = default(string), Organization organization = default(Organization))
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
            localVarRequestOptions.Data = organization;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Organization>("/organizations", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrganizations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create an organization. The response contains the same object as posted and fills in the newly assigned organization ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> CreateOrganizationsAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Organization> localVarResponse = await CreateOrganizationsWithHttpInfoAsync(avalaraVersion, xCorrelationId, organization, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create an organization. The response contains the same object as posted and fills in the newly assigned organization ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Organization>> CreateOrganizationsWithHttpInfoAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.Data = organization;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Organization>("/organizations", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateOrganizations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an organization. Deletes the specified organization.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        public void DeleteOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            DeleteOrganizationWithHttpInfo(organizationId, avalaraVersion, xCorrelationId, ifMatch);
        }

        /// <summary>
        /// Delete an organization. Deletes the specified organization.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeleteOrganizationWithHttpInfo(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->DeleteOrganization");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            var localVarResponse = this.Client.Delete<Object>("/organizations/{organization-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete an organization. Deletes the specified organization.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteOrganizationWithHttpInfoAsync(organizationId, avalaraVersion, xCorrelationId, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete an organization. Deletes the specified organization.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeleteOrganizationWithHttpInfoAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->DeleteOrganization");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
			var localVarResponse = await this.Client.DeleteAsync<Object>("/organizations/{organization-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an organization. Retrieves a specific organization which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>Organization</returns>
        public Organization GetOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            Avalara.SDK.Client.ApiResponse<Organization> localVarResponse = GetOrganizationWithHttpInfo(organizationId, avalaraVersion, xCorrelationId, ifNoneMatch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an organization. Retrieves a specific organization which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>ApiResponse of Organization</returns>
        private Avalara.SDK.Client.ApiResponse<Organization> GetOrganizationWithHttpInfo(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->GetOrganization");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            var localVarResponse = this.Client.Get<Organization>("/organizations/{organization-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get an organization. Retrieves a specific organization which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Organization</returns>
        public async System.Threading.Tasks.Task<Organization> GetOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Organization> localVarResponse = await GetOrganizationWithHttpInfoAsync(organizationId, avalaraVersion, xCorrelationId, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get an organization. Retrieves a specific organization which the current ID has access to.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Organization)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Organization>> GetOrganizationWithHttpInfoAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->GetOrganization");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<Organization>("/organizations/{organization-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all apps within an organization. Retrieves a list of applications associated with an organization.  Filterable properties:   * displayName * type * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>AppList</returns>
        public AppList ListOrganizationApps(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<AppList> localVarResponse = ListOrganizationAppsWithHttpInfo(organizationId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all apps within an organization. Retrieves a list of applications associated with an organization.  Filterable properties:   * displayName * type * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of AppList</returns>
        private Avalara.SDK.Client.ApiResponse<AppList> ListOrganizationAppsWithHttpInfo(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ListOrganizationApps");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            var localVarResponse = this.Client.Get<AppList>("/organizations/{organization-id}/apps", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizationApps", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all apps within an organization. Retrieves a list of applications associated with an organization.  Filterable properties:   * displayName * type * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AppList</returns>
        public async System.Threading.Tasks.Task<AppList> ListOrganizationAppsAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<AppList> localVarResponse = await ListOrganizationAppsWithHttpInfoAsync(organizationId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all apps within an organization. Retrieves a list of applications associated with an organization.  Filterable properties:   * displayName * type * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AppList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<AppList>> ListOrganizationAppsWithHttpInfoAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ListOrganizationApps");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<AppList>("/organizations/{organization-id}/apps", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizationApps", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all tenants within an organization. Retrieve a list of all tenants within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>TenantList</returns>
        public TenantList ListOrganizationTenants(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<TenantList> localVarResponse = ListOrganizationTenantsWithHttpInfo(organizationId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all tenants within an organization. Retrieve a list of all tenants within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of TenantList</returns>
        private Avalara.SDK.Client.ApiResponse<TenantList> ListOrganizationTenantsWithHttpInfo(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ListOrganizationTenants");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            var localVarResponse = this.Client.Get<TenantList>("/organizations/{organization-id}/tenants", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizationTenants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all tenants within an organization. Retrieve a list of all tenants within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
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
        public async System.Threading.Tasks.Task<TenantList> ListOrganizationTenantsAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<TenantList> localVarResponse = await ListOrganizationTenantsWithHttpInfoAsync(organizationId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all tenants within an organization. Retrieve a list of all tenants within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
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
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<TenantList>> ListOrganizationTenantsWithHttpInfoAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ListOrganizationTenants");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<TenantList>("/organizations/{organization-id}/tenants", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizationTenants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all users within an organization. Retrieve a list of all users within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>UserList</returns>
        public UserList ListOrganizationUsers(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<UserList> localVarResponse = ListOrganizationUsersWithHttpInfo(organizationId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all users within an organization. Retrieve a list of all users within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of UserList</returns>
        private Avalara.SDK.Client.ApiResponse<UserList> ListOrganizationUsersWithHttpInfo(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ListOrganizationUsers");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            var localVarResponse = this.Client.Get<UserList>("/organizations/{organization-id}/users", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizationUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all users within an organization. Retrieve a list of all users within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
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
        public async System.Threading.Tasks.Task<UserList> ListOrganizationUsersAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<UserList> localVarResponse = await ListOrganizationUsersWithHttpInfoAsync(organizationId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all users within an organization. Retrieve a list of all users within the organization which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * emails/value * active * userName
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId"></param>
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
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<UserList>> ListOrganizationUsersWithHttpInfoAsync(string organizationId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ListOrganizationUsers");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<UserList>("/organizations/{organization-id}/users", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizationUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all organizations which the user has access to. Retrieve a list of all organizations the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
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
        /// <returns>OrganizationList</returns>
        public OrganizationList ListOrganizations(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<OrganizationList> localVarResponse = ListOrganizationsWithHttpInfo(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all organizations which the user has access to. Retrieve a list of all organizations the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
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
        /// <returns>ApiResponse of OrganizationList</returns>
        private Avalara.SDK.Client.ApiResponse<OrganizationList> ListOrganizationsWithHttpInfo(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
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
            var localVarResponse = this.Client.Get<OrganizationList>("/organizations", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// List all organizations which the user has access to. Retrieve a list of all organizations the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
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
        /// <returns>Task of OrganizationList</returns>
        public async System.Threading.Tasks.Task<OrganizationList> ListOrganizationsAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<OrganizationList> localVarResponse = await ListOrganizationsWithHttpInfoAsync(filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List all organizations which the user has access to. Retrieve a list of all organizations the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName
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
        /// <returns>Task of ApiResponse (OrganizationList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<OrganizationList>> ListOrganizationsWithHttpInfoAsync(string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
			var localVarResponse = await this.Client.GetAsync<OrganizationList>("/organizations", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListOrganizations", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields present in the message body on the organization. Updates an organization, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns></returns>
        public void PatchOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization))
        {
            PatchOrganizationWithHttpInfo(organizationId, avalaraVersion, xCorrelationId, ifMatch, organization);
        }

        /// <summary>
        /// Update the fields present in the message body on the organization. Updates an organization, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> PatchOrganizationWithHttpInfo(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->PatchOrganization");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            localVarRequestOptions.Data = organization;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/organizations/{organization-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields present in the message body on the organization. Updates an organization, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PatchOrganizationWithHttpInfoAsync(organizationId, avalaraVersion, xCorrelationId, ifMatch, organization, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the fields present in the message body on the organization. Updates an organization, only applying the changes delivered in the payload. 
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> PatchOrganizationWithHttpInfoAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->PatchOrganization");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            localVarRequestOptions.Data = organization;

            // make the HTTP request
			var localVarResponse = await this.Client.PatchAsync<Object>("/organizations/{organization-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on an organization. Replaces the specified organization with the organization in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns></returns>
        public void ReplaceOrganization(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization))
        {
            ReplaceOrganizationWithHttpInfo(organizationId, avalaraVersion, xCorrelationId, ifMatch, organization);
        }

        /// <summary>
        /// Update all fields on an organization. Replaces the specified organization with the organization in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> ReplaceOrganizationWithHttpInfo(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ReplaceOrganization");

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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            localVarRequestOptions.Data = organization;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/organizations/{organization-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceOrganization", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on an organization. Replaces the specified organization with the organization in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReplaceOrganizationAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ReplaceOrganizationWithHttpInfoAsync(organizationId, avalaraVersion, xCorrelationId, ifMatch, organization, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update all fields on an organization. Replaces the specified organization with the organization in the body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">Id for the organization to get</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="organization"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> ReplaceOrganizationWithHttpInfoAsync(string organizationId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Organization organization = default(Organization), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'organizationId' when calling OrganizationApi->ReplaceOrganization");


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

            localVarRequestOptions.PathParameters.Add("organization-id", Avalara.SDK.Client.ClientUtils.ParameterToString(organizationId)); // path parameter
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
            localVarRequestOptions.Data = organization;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/organizations/{organization-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceOrganization", localVarResponse);
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
