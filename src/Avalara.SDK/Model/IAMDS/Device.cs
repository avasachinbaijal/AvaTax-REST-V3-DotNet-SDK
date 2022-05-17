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
    /// Representation of a Device
    /// </summary>
    [DataContract]
    public partial class Device :  IEquatable<Device>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Device() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="displayName">Name of the Device, used for display purposes (required).</param>
        /// <param name="tenant">tenant (required).</param>
        /// <param name="identity">Identity of the device, for example, a public X.509 certificate (required).</param>
        /// <param name="active">A Boolean value indicating the Device&#39;s administrative status.</param>
        /// <param name="grants">List of grants associated with the Device.</param>
        /// <param name="groups">List of groups to which the Device belongs.</param>
        /// <param name="meta">meta.</param>
        /// <param name="aspects">Identifier of the Resource (if any) in other systems.</param>
        /// <param name="tags">User defined tags in the form of key:value pair.</param>
        public Device(string displayName = default(string), Reference tenant = default(Reference), string identity = default(string), bool active = default(bool), List<Reference> grants = default(List<Reference>), List<Reference> groups = default(List<Reference>), InstanceMeta meta = default(InstanceMeta), List<Aspect> aspects = default(List<Aspect>), List<Tag> tags = default(List<Tag>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for Device and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "tenant" is required (not null)
            if (tenant == null)
            {
                throw new InvalidDataException("tenant is a required property for Device and cannot be null");
            }
            else
            {
                this.Tenant = tenant;
            }

            // to ensure "identity" is required (not null)
            if (identity == null)
            {
                throw new InvalidDataException("identity is a required property for Device and cannot be null");
            }
            else
            {
                this.Identity = identity;
            }

            this.Active = active;
            this.Grants = grants;
            this.Groups = groups;
            this.Meta = meta;
            this.Aspects = aspects;
            this.Tags = tags;
        }

        /// <summary>
        /// Name of the Device, used for display purposes
        /// </summary>
        /// <value>Name of the Device, used for display purposes</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Tenant
        /// </summary>
        [DataMember(Name="tenant", EmitDefaultValue=true)]
        public Reference Tenant { get; set; }

        /// <summary>
        /// Identity of the device, for example, a public X.509 certificate
        /// </summary>
        /// <value>Identity of the device, for example, a public X.509 certificate</value>
        [DataMember(Name="identity", EmitDefaultValue=true)]
        public string Identity { get; set; }

        /// <summary>
        /// A Boolean value indicating the Device&#39;s administrative status
        /// </summary>
        /// <value>A Boolean value indicating the Device&#39;s administrative status</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// List of grants associated with the Device
        /// </summary>
        /// <value>List of grants associated with the Device</value>
        [DataMember(Name="grants", EmitDefaultValue=false)]
        public List<Reference> Grants { get; set; }

        /// <summary>
        /// List of groups to which the Device belongs
        /// </summary>
        /// <value>List of groups to which the Device belongs</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<Reference> Groups { get; set; }

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
            sb.Append("class Device {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Tenant: ").Append(Tenant).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Grants: ").Append(Grants).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="input">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device input)
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
                    this.Tenant == input.Tenant ||
                    (this.Tenant != null &&
                    this.Tenant.Equals(input.Tenant))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Grants == input.Grants ||
                    this.Grants != null &&
                    input.Grants != null &&
                    this.Grants.SequenceEqual(input.Grants)
                ) && 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this.Tenant != null)
                    hashCode = hashCode * 59 + this.Tenant.GetHashCode();
                if (this.Identity != null)
                    hashCode = hashCode * 59 + this.Identity.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Grants != null)
                    hashCode = hashCode * 59 + this.Grants.GetHashCode();
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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
