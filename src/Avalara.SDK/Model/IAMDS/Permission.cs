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
    /// Representation of a Permission belonging to a System
    /// </summary>
    [DataContract]
    public partial class Permission :  IEquatable<Permission>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Permission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="resource">resource (required).</param>
        /// <param name="access">Access permission type (required).</param>
        /// <param name="meta">meta.</param>
        /// <param name="aspects">Identifier of the Resource (if any) in other systems.</param>
        /// <param name="tags">User defined tags in the form of key:value pair.</param>
        public Permission(Reference resource = default(Reference), string access = default(string), InstanceMeta meta = default(InstanceMeta), List<Aspect> aspects = default(List<Aspect>), List<Tag> tags = default(List<Tag>))
        {
            // to ensure "resource" is required (not null)
            if (resource == null)
            {
                throw new InvalidDataException("resource is a required property for Permission and cannot be null");
            }
            else
            {
                this.Resource = resource;
            }

            // to ensure "access" is required (not null)
            if (access == null)
            {
                throw new InvalidDataException("access is a required property for Permission and cannot be null");
            }
            else
            {
                this.Access = access;
            }

            this.Meta = meta;
            this.Aspects = aspects;
            this.Tags = tags;
        }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name="resource", EmitDefaultValue=true)]
        public Reference Resource { get; set; }

        /// <summary>
        /// Access permission type
        /// </summary>
        /// <value>Access permission type</value>
        [DataMember(Name="access", EmitDefaultValue=true)]
        public string Access { get; set; }

        /// <summary>
        /// Name of the permission, used in roles and grants
        /// </summary>
        /// <value>Name of the permission, used in roles and grants</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; private set; }

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
            sb.Append("class Permission {\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Permission);
        }

        /// <summary>
        /// Returns true if Permission instances are equal
        /// </summary>
        /// <param name="input">Instance of Permission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Permission input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.Access != null)
                    hashCode = hashCode * 59 + this.Access.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
