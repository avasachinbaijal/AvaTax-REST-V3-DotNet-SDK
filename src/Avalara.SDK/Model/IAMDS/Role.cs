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
    /// Representation of a Role
    /// </summary>
    [DataContract]
    public partial class Role :  IEquatable<Role>
    {
        /// <summary>
        /// Determines the role ownership
        /// </summary>
        /// <value>Determines the role ownership</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum System for value: System
            /// </summary>
            [EnumMember(Value = "System")]
            System = 1,

            /// <summary>
            /// Enum Custom for value: Custom
            /// </summary>
            [EnumMember(Value = "Custom")]
            Custom = 2

        }

        /// <summary>
        /// Determines the role ownership
        /// </summary>
        /// <value>Determines the role ownership</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Role() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="displayName">Name of the Role (required).</param>
        /// <param name="description">Description of the Role.</param>
        /// <param name="system">system (required).</param>
        /// <param name="type">Determines the role ownership (required).</param>
        /// <param name="permissions">List of associated permissions, identified by the permission name (required).</param>
        /// <param name="meta">meta.</param>
        /// <param name="aspects">Identifier of the Resource (if any) in other systems.</param>
        /// <param name="tags">User defined tags in the form of key:value pair.</param>
        public Role(string displayName = default(string), string description = default(string), Reference system = default(Reference), TypeEnum type = default(TypeEnum), List<string> permissions = default(List<string>), InstanceMeta meta = default(InstanceMeta), List<Aspect> aspects = default(List<Aspect>), List<Tag> tags = default(List<Tag>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for Role and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "system" is required (not null)
            if (system == null)
            {
                throw new InvalidDataException("system is a required property for Role and cannot be null");
            }
            else
            {
                this.System = system;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for Role and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "permissions" is required (not null)
            if (permissions == null)
            {
                throw new InvalidDataException("permissions is a required property for Role and cannot be null");
            }
            else
            {
                this.Permissions = permissions;
            }

            this.Description = description;
            this.Meta = meta;
            this.Aspects = aspects;
            this.Tags = tags;
        }

        /// <summary>
        /// Name of the Role
        /// </summary>
        /// <value>Name of the Role</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Description of the Role
        /// </summary>
        /// <value>Description of the Role</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets System
        /// </summary>
        [DataMember(Name="system", EmitDefaultValue=true)]
        public Reference System { get; set; }


        /// <summary>
        /// List of associated permissions, identified by the permission name
        /// </summary>
        /// <value>List of associated permissions, identified by the permission name</value>
        [DataMember(Name="permissions", EmitDefaultValue=true)]
        public List<string> Permissions { get; set; }

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
            sb.Append("class Role {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as Role);
        }

        /// <summary>
        /// Returns true if Role instances are equal
        /// </summary>
        /// <param name="input">Instance of Role to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Role input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.System == input.System ||
                    (this.System != null &&
                    this.System.Equals(input.System))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.System != null)
                    hashCode = hashCode * 59 + this.System.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
