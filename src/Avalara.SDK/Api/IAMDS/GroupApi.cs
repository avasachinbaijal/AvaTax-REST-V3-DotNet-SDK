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
    public interface IGroupApiSync 
    {
        #region Synchronous Operations
        /// <summary>
        /// Add a device to a group.
        /// </summary>
        /// <remarks>
        /// Adds a device to a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void AddDeviceToGroup(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Add a grant to a group.
        /// </summary>
        /// <remarks>
        /// Adds a grant to a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void AddGrantToGroup(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Add a user to a group.
        /// </summary>
        /// <remarks>
        /// Adds a user to a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void AddUserToGroup(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Create a group.
        /// </summary>
        /// <remarks>
        /// On a post, the group ID will not be known since it is assigned by the system. The response contains the group, including ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns>Group</returns>
        Group CreateGroup(string avalaraVersion = default(string), string xCorrelationId = default(string), Group group = default(Group));

        /// <summary>
        /// Delete a group.
        /// </summary>
        /// <remarks>
        /// Deletes the specified group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        void DeleteGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string));

        /// <summary>
        /// Get a group by ID.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>Group</returns>
        Group GetGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string));

        /// <summary>
        /// Get all devices in a group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all devices within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * tenant/identifier * active * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>DeviceList</returns>
        DeviceList ListGroupDevices(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Get all grants in a group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all grants within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * system/identifier * type * role/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>GrantList</returns>
        GrantList ListGroupGrants(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Get all users in a group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all users within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * emails/value * active * userName * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>UserList</returns>
        UserList ListGroupUsers(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Get all groups.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all groups the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * tenants/identifier * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>GroupList</returns>
        GroupList ListGroups(string filter = default(string), string top = default(string), string skip = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string orderBy = default(string), string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Update the fields in the message body on the group.
        /// </summary>
        /// <remarks>
        /// Updates the fields on a group which should change.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns></returns>
        void PatchGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group));

        /// <summary>
        /// Remove a device from a group.
        /// </summary>
        /// <remarks>
        /// Removes a device from a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void RemoveDeviceFromGroup(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Delete a grant from a group.
        /// </summary>
        /// <remarks>
        /// Removes a grant from a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void RemoveGrantFromGroup(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Delete a user from a group.
        /// </summary>
        /// <remarks>
        /// Removes a user from a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        void RemoveUserFromGroup(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string));

        /// <summary>
        /// Update all fields on a group.
        /// </summary>
        /// <remarks>
        /// Updates the group with the data in the request body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns></returns>
        void ReplaceGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group));

        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGroupApiAsync 
    {
        #region Asynchronous Operations
        /// <summary>
        /// Add a device to a group.
        /// </summary>
        /// <remarks>
        /// Adds a device to a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddDeviceToGroupAsync(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Add a grant to a group.
        /// </summary>
        /// <remarks>
        /// Adds a grant to a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddGrantToGroupAsync(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Add a user to a group.
        /// </summary>
        /// <remarks>
        /// Adds a user to a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task AddUserToGroupAsync(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Create a group.
        /// </summary>
        /// <remarks>
        /// On a post, the group ID will not be known since it is assigned by the system. The response contains the group, including ID.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> CreateGroupAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a group.
        /// </summary>
        /// <remarks>
        /// Deletes the specified group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get a group by ID.
        /// </summary>
        /// <remarks>
        /// Retrieves the specified group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        System.Threading.Tasks.Task<Group> GetGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all devices in a group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all devices within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * tenant/identifier * active * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeviceList</returns>
        System.Threading.Tasks.Task<DeviceList> ListGroupDevicesAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all grants in a group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all grants within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * system/identifier * type * role/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GrantList</returns>
        System.Threading.Tasks.Task<GrantList> ListGroupGrantsAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all users in a group.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all users within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * emails/value * active * userName * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
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
        System.Threading.Tasks.Task<UserList> ListGroupUsersAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get all groups.
        /// </summary>
        /// <remarks>
        /// Retrieve a list of all groups the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * tenants/identifier * grants/identifier
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GroupList</returns>
        System.Threading.Tasks.Task<GroupList> ListGroupsAsync(string filter = default(string), string top = default(string), string skip = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string orderBy = default(string), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update the fields in the message body on the group.
        /// </summary>
        /// <remarks>
        /// Updates the fields on a group which should change.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Remove a device from a group.
        /// </summary>
        /// <remarks>
        /// Removes a device from a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveDeviceFromGroupAsync(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a grant from a group.
        /// </summary>
        /// <remarks>
        /// Removes a grant from a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveGrantFromGroupAsync(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Delete a user from a group.
        /// </summary>
        /// <remarks>
        /// Removes a user from a group.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RemoveUserFromGroupAsync(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Update all fields on a group.
        /// </summary>
        /// <remarks>
        /// Updates the group with the data in the request body.
        /// </remarks>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ReplaceGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class GroupApi : IGroupApiSync, IGroupApiAsync
    {
        private Avalara.SDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupApi"/> class
        /// using a Configuration object and client instance.
        /// <param name="client">The client interface for API access.</param>
        /// </summary>
        public GroupApi(Avalara.SDK.Client.ApiClient client)
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
        /// Add a device to a group. Adds a device to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void AddDeviceToGroup(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            AddDeviceToGroupWithHttpInfo(groupId, deviceId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Add a device to a group. Adds a device to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> AddDeviceToGroupWithHttpInfo(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->AddDeviceToGroup");

            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'deviceId' when calling GroupApi->AddDeviceToGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("device-id", Avalara.SDK.Client.ClientUtils.ParameterToString(deviceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/groups/{group-id}/devices/{device-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddDeviceToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a device to a group. Adds a device to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddDeviceToGroupAsync(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AddDeviceToGroupWithHttpInfoAsync(groupId, deviceId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add a device to a group. Adds a device to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> AddDeviceToGroupWithHttpInfoAsync(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->AddDeviceToGroup");

            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'deviceId' when calling GroupApi->AddDeviceToGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("device-id", Avalara.SDK.Client.ClientUtils.ParameterToString(deviceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/groups/{group-id}/devices/{device-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddDeviceToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a grant to a group. Adds a grant to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void AddGrantToGroup(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            AddGrantToGroupWithHttpInfo(groupId, grantId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Add a grant to a group. Adds a grant to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> AddGrantToGroupWithHttpInfo(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->AddGrantToGroup");

            // verify the required parameter 'grantId' is set
            if (grantId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'grantId' when calling GroupApi->AddGrantToGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("grant-id", Avalara.SDK.Client.ClientUtils.ParameterToString(grantId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/groups/{group-id}/grants/{grant-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddGrantToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a grant to a group. Adds a grant to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddGrantToGroupAsync(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AddGrantToGroupWithHttpInfoAsync(groupId, grantId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add a grant to a group. Adds a grant to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> AddGrantToGroupWithHttpInfoAsync(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->AddGrantToGroup");

            // verify the required parameter 'grantId' is set
            if (grantId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'grantId' when calling GroupApi->AddGrantToGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("grant-id", Avalara.SDK.Client.ClientUtils.ParameterToString(grantId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/groups/{group-id}/grants/{grant-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddGrantToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a user to a group. Adds a user to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void AddUserToGroup(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            AddUserToGroupWithHttpInfo(groupId, userId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Add a user to a group. Adds a user to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> AddUserToGroupWithHttpInfo(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->AddUserToGroup");

            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling GroupApi->AddUserToGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/groups/{group-id}/users/{user-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddUserToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Add a user to a group. Adds a user to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task AddUserToGroupAsync(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await AddUserToGroupWithHttpInfoAsync(groupId, userId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Add a user to a group. Adds a user to a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> AddUserToGroupWithHttpInfoAsync(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->AddUserToGroup");

            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling GroupApi->AddUserToGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/groups/{group-id}/users/{user-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddUserToGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a group. On a post, the group ID will not be known since it is assigned by the system. The response contains the group, including ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns>Group</returns>
        public Group CreateGroup(string avalaraVersion = default(string), string xCorrelationId = default(string), Group group = default(Group))
        {
            Avalara.SDK.Client.ApiResponse<Group> localVarResponse = CreateGroupWithHttpInfo(avalaraVersion, xCorrelationId, group);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a group. On a post, the group ID will not be known since it is assigned by the system. The response contains the group, including ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns>ApiResponse of Group</returns>
        private Avalara.SDK.Client.ApiResponse<Group> CreateGroupWithHttpInfo(string avalaraVersion = default(string), string xCorrelationId = default(string), Group group = default(Group))
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
            localVarRequestOptions.Data = group;

            // make the HTTP request
            var localVarResponse = this.Client.Post<Group>("/groups", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Create a group. On a post, the group ID will not be known since it is assigned by the system. The response contains the group, including ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> CreateGroupAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Group> localVarResponse = await CreateGroupWithHttpInfoAsync(avalaraVersion, xCorrelationId, group, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Create a group. On a post, the group ID will not be known since it is assigned by the system. The response contains the group, including ID.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Group>> CreateGroupWithHttpInfoAsync(string avalaraVersion = default(string), string xCorrelationId = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            localVarRequestOptions.Data = group;

            // make the HTTP request
			var localVarResponse = await this.Client.PostAsync<Group>("/groups", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a group. Deletes the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns></returns>
        public void DeleteGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            DeleteGroupWithHttpInfo(groupId, avalaraVersion, xCorrelationId, ifMatch);
        }

        /// <summary>
        /// Delete a group. Deletes the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> DeleteGroupWithHttpInfo(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->DeleteGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            var localVarResponse = this.Client.Delete<Object>("/groups/{group-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a group. Deletes the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteGroupWithHttpInfoAsync(groupId, avalaraVersion, xCorrelationId, ifMatch, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a group. Deletes the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> DeleteGroupWithHttpInfoAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->DeleteGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
			var localVarResponse = await this.Client.DeleteAsync<Object>("/groups/{group-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("DeleteGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a group by ID. Retrieves the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>Group</returns>
        public Group GetGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            Avalara.SDK.Client.ApiResponse<Group> localVarResponse = GetGroupWithHttpInfo(groupId, avalaraVersion, xCorrelationId, ifNoneMatch);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group by ID. Retrieves the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <returns>ApiResponse of Group</returns>
        private Avalara.SDK.Client.ApiResponse<Group> GetGroupWithHttpInfo(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->GetGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            var localVarResponse = this.Client.Get<Group>("/groups/{group-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a group by ID. Retrieves the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Group</returns>
        public async System.Threading.Tasks.Task<Group> GetGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<Group> localVarResponse = await GetGroupWithHttpInfoAsync(groupId, avalaraVersion, xCorrelationId, ifNoneMatch, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get a group by ID. Retrieves the specified group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifNoneMatch">Only return the resource if the ETag is different from the ETag passed in. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Group)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Group>> GetGroupWithHttpInfoAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifNoneMatch = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->GetGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<Group>("/groups/{group-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all devices in a group. Retrieve a list of all devices within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * tenant/identifier * active * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>DeviceList</returns>
        public DeviceList ListGroupDevices(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<DeviceList> localVarResponse = ListGroupDevicesWithHttpInfo(groupId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all devices in a group. Retrieve a list of all devices within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * tenant/identifier * active * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of DeviceList</returns>
        private Avalara.SDK.Client.ApiResponse<DeviceList> ListGroupDevicesWithHttpInfo(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ListGroupDevices");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            var localVarResponse = this.Client.Get<DeviceList>("/groups/{group-id}/devices", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroupDevices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all devices in a group. Retrieve a list of all devices within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * tenant/identifier * active * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of DeviceList</returns>
        public async System.Threading.Tasks.Task<DeviceList> ListGroupDevicesAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<DeviceList> localVarResponse = await ListGroupDevicesWithHttpInfoAsync(groupId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all devices in a group. Retrieve a list of all devices within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * tenant/identifier * active * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (DeviceList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<DeviceList>> ListGroupDevicesWithHttpInfoAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ListGroupDevices");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<DeviceList>("/groups/{group-id}/devices", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroupDevices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all grants in a group. Retrieve a list of all grants within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * system/identifier * type * role/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>GrantList</returns>
        public GrantList ListGroupGrants(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<GrantList> localVarResponse = ListGroupGrantsWithHttpInfo(groupId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all grants in a group. Retrieve a list of all grants within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * system/identifier * type * role/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of GrantList</returns>
        private Avalara.SDK.Client.ApiResponse<GrantList> ListGroupGrantsWithHttpInfo(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ListGroupGrants");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            var localVarResponse = this.Client.Get<GrantList>("/groups/{group-id}/grants", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroupGrants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all grants in a group. Retrieve a list of all grants within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * system/identifier * type * role/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GrantList</returns>
        public async System.Threading.Tasks.Task<GrantList> ListGroupGrantsAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<GrantList> localVarResponse = await ListGroupGrantsWithHttpInfoAsync(groupId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all grants in a group. Retrieve a list of all grants within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * system/identifier * type * role/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GrantList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<GrantList>> ListGroupGrantsWithHttpInfoAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ListGroupGrants");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<GrantList>("/groups/{group-id}/grants", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroupGrants", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all users in a group. Retrieve a list of all users within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * emails/value * active * userName * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>UserList</returns>
        public UserList ListGroupUsers(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<UserList> localVarResponse = ListGroupUsersWithHttpInfo(groupId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all users in a group. Retrieve a list of all users within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * emails/value * active * userName * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of UserList</returns>
        private Avalara.SDK.Client.ApiResponse<UserList> ListGroupUsersWithHttpInfo(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ListGroupUsers");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            var localVarResponse = this.Client.Get<UserList>("/groups/{group-id}/users", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroupUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all users in a group. Retrieve a list of all users within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * emails/value * active * userName * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
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
        public async System.Threading.Tasks.Task<UserList> ListGroupUsersAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<UserList> localVarResponse = await ListGroupUsersWithHttpInfoAsync(groupId, filter, top, skip, orderBy, count, countOnly, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all users in a group. Retrieve a list of all users within a group which the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:  * displayName * emails/value * active * userName * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
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
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<UserList>> ListGroupUsersWithHttpInfoAsync(string groupId, string filter = default(string), string top = default(string), string skip = default(string), string orderBy = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ListGroupUsers");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
			var localVarResponse = await this.Client.GetAsync<UserList>("/groups/{group-id}/users", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroupUsers", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all groups. Retrieve a list of all groups the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>GroupList</returns>
        public GroupList ListGroups(string filter = default(string), string top = default(string), string skip = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string orderBy = default(string), string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            Avalara.SDK.Client.ApiResponse<GroupList> localVarResponse = ListGroupsWithHttpInfo(filter, top, skip, count, countOnly, orderBy, avalaraVersion, xCorrelationId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all groups. Retrieve a list of all groups the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of GroupList</returns>
        private Avalara.SDK.Client.ApiResponse<GroupList> ListGroupsWithHttpInfo(string filter = default(string), string top = default(string), string skip = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string orderBy = default(string), string avalaraVersion = default(string), string xCorrelationId = default(string))
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (countOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", countOnly));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", orderBy));
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
            var localVarResponse = this.Client.Get<GroupList>("/groups", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroups", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get all groups. Retrieve a list of all groups the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of GroupList</returns>
        public async System.Threading.Tasks.Task<GroupList> ListGroupsAsync(string filter = default(string), string top = default(string), string skip = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string orderBy = default(string), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Avalara.SDK.Client.ApiResponse<GroupList> localVarResponse = await ListGroupsWithHttpInfoAsync(filter, top, skip, count, countOnly, orderBy, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get all groups. Retrieve a list of all groups the authenticated user has access to. This list is paged, returning no more than 1000 items at a time.  Filterable properties:   * displayName * tenants/identifier * grants/identifier
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">A filter statement to identify specific records to retrieve. (optional)</param>
        /// <param name="top">If nonzero, return no more than this number of results.  Used with &#x60;$skip&#x60; to provide pagination for large datasets.  Unless otherwise specified, the maximum number of records that can be returned from an API call is 1,000 records. (optional)</param>
        /// <param name="skip">If nonzero, skip this number of results before returning data.  Used with &#x60;$top&#x60; to provide pagination for large datasets. (optional)</param>
        /// <param name="count">If set to &#39;true&#39;, requests the count of items as part of the response. Default: &#39;false&#39;. If the value cannot be (optional)</param>
        /// <param name="countOnly">If set to &#39;true&#39;, requests the count of items as part of the response. No values are returned. Default: &#39;false&#39;. (optional)</param>
        /// <param name="orderBy">A comma separated list of sort statements in the format &#x60;(fieldname) [ASC|DESC]&#x60;, for example &#x60;id ASC&#x60;. (optional)</param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (GroupList)</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<GroupList>> ListGroupsWithHttpInfoAsync(string filter = default(string), string top = default(string), string skip = default(string), bool? count = default(bool?), bool? countOnly = default(bool?), string orderBy = default(string), string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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
            if (count != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "count", count));
            }
            if (countOnly != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "countOnly", countOnly));
            }
            if (orderBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Avalara.SDK.Client.ClientUtils.ParameterToMultiMap("", "$orderBy", orderBy));
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
			var localVarResponse = await this.Client.GetAsync<GroupList>("/groups", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListGroups", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields in the message body on the group. Updates the fields on a group which should change.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns></returns>
        public void PatchGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group))
        {
            PatchGroupWithHttpInfo(groupId, avalaraVersion, xCorrelationId, ifMatch, group);
        }

        /// <summary>
        /// Update the fields in the message body on the group. Updates the fields on a group which should change.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> PatchGroupWithHttpInfo(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->PatchGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            localVarRequestOptions.Data = group;

            // make the HTTP request
            var localVarResponse = this.Client.Patch<Object>("/groups/{group-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update the fields in the message body on the group. Updates the fields on a group which should change.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await PatchGroupWithHttpInfoAsync(groupId, avalaraVersion, xCorrelationId, ifMatch, group, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update the fields in the message body on the group. Updates the fields on a group which should change.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> PatchGroupWithHttpInfoAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->PatchGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            localVarRequestOptions.Data = group;

            // make the HTTP request
			var localVarResponse = await this.Client.PatchAsync<Object>("/groups/{group-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("PatchGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a device from a group. Removes a device from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void RemoveDeviceFromGroup(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            RemoveDeviceFromGroupWithHttpInfo(groupId, deviceId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Remove a device from a group. Removes a device from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> RemoveDeviceFromGroupWithHttpInfo(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->RemoveDeviceFromGroup");

            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'deviceId' when calling GroupApi->RemoveDeviceFromGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("device-id", Avalara.SDK.Client.ClientUtils.ParameterToString(deviceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/groups/{group-id}/devices/{device-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveDeviceFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Remove a device from a group. Removes a device from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveDeviceFromGroupAsync(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RemoveDeviceFromGroupWithHttpInfoAsync(groupId, deviceId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Remove a device from a group. Removes a device from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="deviceId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> RemoveDeviceFromGroupWithHttpInfoAsync(string groupId, string deviceId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->RemoveDeviceFromGroup");

            // verify the required parameter 'deviceId' is set
            if (deviceId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'deviceId' when calling GroupApi->RemoveDeviceFromGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("device-id", Avalara.SDK.Client.ClientUtils.ParameterToString(deviceId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/groups/{group-id}/devices/{device-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveDeviceFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a grant from a group. Removes a grant from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void RemoveGrantFromGroup(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            RemoveGrantFromGroupWithHttpInfo(groupId, grantId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Delete a grant from a group. Removes a grant from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> RemoveGrantFromGroupWithHttpInfo(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->RemoveGrantFromGroup");

            // verify the required parameter 'grantId' is set
            if (grantId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'grantId' when calling GroupApi->RemoveGrantFromGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("grant-id", Avalara.SDK.Client.ClientUtils.ParameterToString(grantId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/groups/{group-id}/grants/{grant-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveGrantFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a grant from a group. Removes a grant from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveGrantFromGroupAsync(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RemoveGrantFromGroupWithHttpInfoAsync(groupId, grantId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a grant from a group. Removes a grant from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="grantId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> RemoveGrantFromGroupWithHttpInfoAsync(string groupId, string grantId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->RemoveGrantFromGroup");

            // verify the required parameter 'grantId' is set
            if (grantId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'grantId' when calling GroupApi->RemoveGrantFromGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("grant-id", Avalara.SDK.Client.ClientUtils.ParameterToString(grantId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/groups/{group-id}/grants/{grant-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveGrantFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user from a group. Removes a user from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns></returns>
        public void RemoveUserFromGroup(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            RemoveUserFromGroupWithHttpInfo(groupId, userId, avalaraVersion, xCorrelationId);
        }

        /// <summary>
        /// Delete a user from a group. Removes a user from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> RemoveUserFromGroupWithHttpInfo(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->RemoveUserFromGroup");

            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling GroupApi->RemoveUserFromGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/groups/{group-id}/users/{user-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveUserFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Delete a user from a group. Removes a user from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RemoveUserFromGroupAsync(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RemoveUserFromGroupWithHttpInfoAsync(groupId, userId, avalaraVersion, xCorrelationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete a user from a group. Removes a user from a group.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="userId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> RemoveUserFromGroupWithHttpInfoAsync(string groupId, string userId, string avalaraVersion = default(string), string xCorrelationId = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->RemoveUserFromGroup");

            // verify the required parameter 'userId' is set
            if (userId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'userId' when calling GroupApi->RemoveUserFromGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
            localVarRequestOptions.PathParameters.Add("user-id", Avalara.SDK.Client.ClientUtils.ParameterToString(userId)); // path parameter
            if (avalaraVersion != null)
            {
                localVarRequestOptions.HeaderParameters.Add("avalara-version", Avalara.SDK.Client.ClientUtils.ParameterToString(avalaraVersion)); // header parameter
            }
            if (xCorrelationId != null)
            {
                localVarRequestOptions.HeaderParameters.Add("X-Correlation-Id", Avalara.SDK.Client.ClientUtils.ParameterToString(xCorrelationId)); // header parameter
            }

            // make the HTTP request
			var localVarResponse = await this.Client.DeleteAsync<Object>("/groups/{group-id}/users/{user-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("RemoveUserFromGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a group. Updates the group with the data in the request body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns></returns>
        public void ReplaceGroup(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group))
        {
            ReplaceGroupWithHttpInfo(groupId, avalaraVersion, xCorrelationId, ifMatch, group);
        }

        /// <summary>
        /// Update all fields on a group. Updates the group with the data in the request body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        private Avalara.SDK.Client.ApiResponse<Object> ReplaceGroupWithHttpInfo(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ReplaceGroup");

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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            localVarRequestOptions.Data = group;

            // make the HTTP request
            var localVarResponse = this.Client.Put<Object>("/groups/{group-id}", localVarRequestOptions, requiredScopes);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceGroup", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Update all fields on a group. Updates the group with the data in the request body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ReplaceGroupAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await ReplaceGroupWithHttpInfoAsync(groupId, avalaraVersion, xCorrelationId, ifMatch, group, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Update all fields on a group. Updates the group with the data in the request body.
        /// </summary>
        /// <exception cref="Avalara.SDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="groupId"></param>
        /// <param name="avalaraVersion">States the version of the API to use. (optional)</param>
        /// <param name="xCorrelationId">Correlation ID to pass into the method. Returned in any response. (optional)</param>
        /// <param name="ifMatch">Only execute the operation if the ETag for the current version of the resource matches the ETag in this header. (optional)</param>
        /// <param name="group"> (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        private async System.Threading.Tasks.Task<Avalara.SDK.Client.ApiResponse<Object>> ReplaceGroupWithHttpInfoAsync(string groupId, string avalaraVersion = default(string), string xCorrelationId = default(string), string ifMatch = default(string), Group group = default(Group), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            //OAuth2 Scopes
            String requiredScopes = "iam TestScope TestScope1";
            // verify the required parameter 'groupId' is set
            if (groupId == null)
                throw new Avalara.SDK.Client.ApiException(400, "Missing required parameter 'groupId' when calling GroupApi->ReplaceGroup");


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

            localVarRequestOptions.PathParameters.Add("group-id", Avalara.SDK.Client.ClientUtils.ParameterToString(groupId)); // path parameter
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
            localVarRequestOptions.Data = group;

            // make the HTTP request
			var localVarResponse = await this.Client.PutAsync<Object>("/groups/{group-id}", localVarRequestOptions, cancellationToken, requiredScopes).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ReplaceGroup", localVarResponse);
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
