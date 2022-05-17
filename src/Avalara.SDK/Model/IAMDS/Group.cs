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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Avalara.SDK.Client.OpenAPIDateConverter;

namespace Avalara.SDK.Model.IAMDS
{
    /// <summary>
    /// Representation of a Group that can contain other principals
    /// </summary>
    [DataContract]
    public partial class Group :  IEquatable<Group>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Group() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Group" /> class.
        /// </summary>
        /// <param name="externalId">Identifier for the group in external systems (clients). The external systems manage this.</param>
        /// <param name="displayName">Name of the group, unique within the Tenant (required).</param>
        /// <param name="tenant">tenant (required).</param>
        /// <param name="members">List of members belonging to the group.</param>
        /// <param name="grants">List of grants assigned to the Group.</param>
        /// <param name="meta">meta.</param>
        /// <param name="aspects">Identifier of the Resource (if any) in other systems.</param>
        /// <param name="tags">User defined tags in the form of key:value pair.</param>
        public Group(string externalId = default(string), string displayName = default(string), Reference tenant = default(Reference), List<Object> members = default(List<Object>), List<Reference> grants = default(List<Reference>), InstanceMeta meta = default(InstanceMeta), List<Aspect> aspects = default(List<Aspect>), List<Tag> tags = default(List<Tag>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for Group and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "tenant" is required (not null)
            if (tenant == null)
            {
                throw new InvalidDataException("tenant is a required property for Group and cannot be null");
            }
            else
            {
                this.Tenant = tenant;
            }

            this.ExternalId = externalId;
            this.Members = members;
            this.Grants = grants;
            this.Meta = meta;
            this.Aspects = aspects;
            this.Tags = tags;
        }

        /// <summary>
        /// Identifier for the group in external systems (clients). The external systems manage this
        /// </summary>
        /// <value>Identifier for the group in external systems (clients). The external systems manage this</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Name of the group, unique within the Tenant
        /// </summary>
        /// <value>Name of the group, unique within the Tenant</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=true)]
        public Reference Tenant { get; set; }

        /// <summary>
        /// List of members belonging to the group
        /// </summary>
        /// <value>List of members belonging to the group</value>
        [DataMember(Name="members", EmitDefaultValue=false)]
        public List<Object> Members { get; set; }

        /// <summary>
        /// List of grants assigned to the Group
        /// </summary>
        /// <value>List of grants assigned to the Group</value>
        [DataMember(Name="grants", EmitDefaultValue=false)]
        public List<Reference> Grants { get; set; }

        /// <summary>
        /// Unique identifier for the Object
        /// </summary>
        /// <value>Unique identifier for the Object</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public InstanceMeta Meta { get; set; }

        /// <summary>
        /// Identifier of the Resource (if any) in other systems
        /// </summary>
        /// <value>Identifier of the Resource (if any) in other systems</value>
        [DataMember(Name="aspects", EmitDefaultValue=false)]
        public List<Aspect> Aspects { get; set; }

        /// <summary>
        /// User defined tags in the form of key:value pair
        /// </summary>
        /// <value>User defined tags in the form of key:value pair</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Group {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Grants: ").Append(Grants).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Aspects: ").Append(Aspects).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Group);
        }

        /// <summary>
        /// Returns true if Group instances are equal
        /// </summary>
        /// <param name="input">Instance of Group to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Group input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.Members == input.Members ||
                    this.Members != null &&
                    input.Members != null &&
                    this.Members.SequenceEqual(input.Members)
                ) && 
                (
                    this.Grants == input.Grants ||
                    this.Grants != null &&
                    input.Grants != null &&
                    this.Grants.SequenceEqual(input.Grants)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Aspects == input.Aspects ||
                    this.Aspects != null &&
                    input.Aspects != null &&
                    this.Aspects.SequenceEqual(input.Aspects)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.Members != null)
                    hashCode = hashCode * 59 + this.Members.GetHashCode();
                if (this.Grants != null)
                    hashCode = hashCode * 59 + this.Grants.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Aspects != null)
                    hashCode = hashCode * 59 + this.Aspects.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }

}
