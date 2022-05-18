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
    /// An App represents any software package that intends to interact with Avalara Compliance Cloud
    /// </summary>
    [DataContract]
    public partial class App :  IEquatable<App>
    {
        /// <summary>
        /// Type of application
        /// </summary>
        /// <value>Type of application</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Spa for value: spa
            /// </summary>
            [EnumMember(Value = "spa")]
            Spa = 1,

            /// <summary>
            /// Enum Web for value: web
            /// </summary>
            [EnumMember(Value = "web")]
            Web = 2,

            /// <summary>
            /// Enum Native for value: native
            /// </summary>
            [EnumMember(Value = "native")]
            Native = 3

        }

        /// <summary>
        /// Type of application
        /// </summary>
        /// <value>Type of application</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected App() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="displayName">Name of the App/Service (required).</param>
        /// <param name="type">Type of application (required).</param>
        /// <param name="organization">organization (required).</param>
        /// <param name="isTenantAgnostic">Whether the App is allowed to access information across all Tenants within its Organization (default to false).</param>
        /// <param name="isOrgAgnostic">Whether the App is allowed to access information across all Organizations and Tenants (default to false).</param>
        /// <param name="tenants">tenants.</param>
        /// <param name="redirectUris">Defines the registered redirect URIs for the app - determines where tokens are sent after authentication.</param>
        /// <param name="grants">List of grants associated with the App.</param>
        /// <param name="meta">meta.</param>
        /// <param name="aspects">Identifier of the Resource (if any) in other systems.</param>
        /// <param name="tags">User defined tags in the form of key:value pair.</param>
        public App(string displayName = default(string), TypeEnum type = default(TypeEnum), Reference organization = default(Reference), bool isTenantAgnostic = false, bool isOrgAgnostic = false, List<Object> tenants = default(List<Object>), List<string> redirectUris = default(List<string>), List<Reference> grants = default(List<Reference>), InstanceMeta meta = default(InstanceMeta), List<Aspect> aspects = default(List<Aspect>), List<Tag> tags = default(List<Tag>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new InvalidDataException("displayName is a required property for App and cannot be null");
            }
            else
            {
                this.DisplayName = displayName;
            }

            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for App and cannot be null");
            }
            else
            {
                this.Type = type;
            }

            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new InvalidDataException("organization is a required property for App and cannot be null");
            }
            else
            {
                this.Organization = organization;
            }

            // use default value if no "isTenantAgnostic" provided
            if (isTenantAgnostic == null)
            {
                this.IsTenantAgnostic = false;
            }
            else
            {
                this.IsTenantAgnostic = isTenantAgnostic;
            }
            // use default value if no "isOrgAgnostic" provided
            if (isOrgAgnostic == null)
            {
                this.IsOrgAgnostic = false;
            }
            else
            {
                this.IsOrgAgnostic = isOrgAgnostic;
            }
            this.Tenants = tenants;
            this.RedirectUris = redirectUris;
            this.Grants = grants;
            this.Meta = meta;
            this.Aspects = aspects;
            this.Tags = tags;
        }

        /// <summary>
        /// Name of the App/Service
        /// </summary>
        /// <value>Name of the App/Service</value>
        [DataMember(Name="displayName", EmitDefaultValue=true)]
        public string DisplayName { get; set; }


        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=true)]
        public Reference Organization { get; set; }

        /// <summary>
        /// Whether the App is allowed to access information across all Tenants within its Organization
        /// </summary>
        /// <value>Whether the App is allowed to access information across all Tenants within its Organization</value>
        [DataMember(Name="isTenantAgnostic", EmitDefaultValue=false)]
        public bool IsTenantAgnostic { get; set; }

        /// <summary>
        /// Whether the App is allowed to access information across all Organizations and Tenants
        /// </summary>
        /// <value>Whether the App is allowed to access information across all Organizations and Tenants</value>
        [DataMember(Name="isOrgAgnostic", EmitDefaultValue=false)]
        public bool IsOrgAgnostic { get; set; }

        /// <summary>
        /// Gets or Sets Tenants
        /// </summary>
        [DataMember(Name="tenants", EmitDefaultValue=false)]
        public List<Object> Tenants { get; set; }

        /// <summary>
        /// The clientId used for OAuth flows
        /// </summary>
        /// <value>The clientId used for OAuth flows</value>
        [DataMember(Name="clientId", EmitDefaultValue=false)]
        public string ClientId { get; private set; }

        /// <summary>
        /// Defines the registered redirect URIs for the app - determines where tokens are sent after authentication
        /// </summary>
        /// <value>Defines the registered redirect URIs for the app - determines where tokens are sent after authentication</value>
        [DataMember(Name="redirectUris", EmitDefaultValue=false)]
        public List<string> RedirectUris { get; set; }

        /// <summary>
        /// List of grants associated with the App
        /// </summary>
        /// <value>List of grants associated with the App</value>
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
            sb.Append("class App {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  IsTenantAgnostic: ").Append(IsTenantAgnostic).Append("\n");
            sb.Append("  IsOrgAgnostic: ").Append(IsOrgAgnostic).Append("\n");
            sb.Append("  Tenants: ").Append(Tenants).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  RedirectUris: ").Append(RedirectUris).Append("\n");
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
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="input">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.IsTenantAgnostic == input.IsTenantAgnostic ||
                    (this.IsTenantAgnostic != null &&
                    this.IsTenantAgnostic.Equals(input.IsTenantAgnostic))
                ) && 
                (
                    this.IsOrgAgnostic == input.IsOrgAgnostic ||
                    (this.IsOrgAgnostic != null &&
                    this.IsOrgAgnostic.Equals(input.IsOrgAgnostic))
                ) && 
                (
                    this.Tenants == input.Tenants ||
                    this.Tenants != null &&
                    input.Tenants != null &&
                    this.Tenants.SequenceEqual(input.Tenants)
                ) && 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.RedirectUris == input.RedirectUris ||
                    this.RedirectUris != null &&
                    input.RedirectUris != null &&
                    this.RedirectUris.SequenceEqual(input.RedirectUris)
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
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.IsTenantAgnostic != null)
                    hashCode = hashCode * 59 + this.IsTenantAgnostic.GetHashCode();
                if (this.IsOrgAgnostic != null)
                    hashCode = hashCode * 59 + this.IsOrgAgnostic.GetHashCode();
                if (this.Tenants != null)
                    hashCode = hashCode * 59 + this.Tenants.GetHashCode();
                if (this.ClientId != null)
                    hashCode = hashCode * 59 + this.ClientId.GetHashCode();
                if (this.RedirectUris != null)
                    hashCode = hashCode * 59 + this.RedirectUris.GetHashCode();
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
