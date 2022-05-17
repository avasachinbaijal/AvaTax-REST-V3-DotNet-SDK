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
    /// Meta data associated with this object. This information is automatically inserted by the service.
    /// </summary>
    [DataContract]
    public partial class InstanceMeta :  IEquatable<InstanceMeta>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceMeta" /> class.
        /// </summary>
        /// <param name="created">Date and time information when this object was created.</param>
        /// <param name="createdBy">Id of the user/app that created this object.</param>
        /// <param name="lastModified">Date and time information when this object was last modified.</param>
        /// <param name="modifiedBy">Id of the user/app that last modified this object.</param>
        /// <param name="location">The URI of the Resource being returned.</param>
        /// <param name="version">The version of the resource being returned in Etag format.</param>
        public InstanceMeta(DateTime created = default(DateTime), string createdBy = default(string), DateTime lastModified = default(DateTime), string modifiedBy = default(string), string location = default(string), string version = default(string))
        {
            this.Created = created;
            this.CreatedBy = createdBy;
            this.LastModified = lastModified;
            this.ModifiedBy = modifiedBy;
            this.Location = location;
            this._Version = version;
        }

        /// <summary>
        /// Date and time information when this object was created
        /// </summary>
        /// <value>Date and time information when this object was created</value>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// Id of the user/app that created this object
        /// </summary>
        /// <value>Id of the user/app that created this object</value>
        [DataMember(Name="createdBy", EmitDefaultValue=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date and time information when this object was last modified
        /// </summary>
        /// <value>Date and time information when this object was last modified</value>
        [DataMember(Name="lastModified", EmitDefaultValue=false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Id of the user/app that last modified this object
        /// </summary>
        /// <value>Id of the user/app that last modified this object</value>
        [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
        public string ModifiedBy { get; set; }

        /// <summary>
        /// The URI of the Resource being returned
        /// </summary>
        /// <value>The URI of the Resource being returned</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// The version of the resource being returned in Etag format
        /// </summary>
        /// <value>The version of the resource being returned in Etag format</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InstanceMeta {\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as InstanceMeta);
        }

        /// <summary>
        /// Returns true if InstanceMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of InstanceMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstanceMeta input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && 
                (
                    this.LastModified == input.LastModified ||
                    (this.LastModified != null &&
                    this.LastModified.Equals(input.LastModified))
                ) && 
                (
                    this.ModifiedBy == input.ModifiedBy ||
                    (this.ModifiedBy != null &&
                    this.ModifiedBy.Equals(input.ModifiedBy))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this._Version == input._Version ||
                    (this._Version != null &&
                    this._Version.Equals(input._Version))
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
                if (this.Created != null)
                    hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.LastModified != null)
                    hashCode = hashCode * 59 + this.LastModified.GetHashCode();
                if (this.ModifiedBy != null)
                    hashCode = hashCode * 59 + this.ModifiedBy.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this._Version != null)
                    hashCode = hashCode * 59 + this._Version.GetHashCode();
                return hashCode;
            }
        }
    }

}
