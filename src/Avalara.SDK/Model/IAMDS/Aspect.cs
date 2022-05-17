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
    /// Representation of an Aspect
    /// </summary>
    [DataContract]
    public partial class Aspect :  IEquatable<Aspect>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Aspect" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Aspect() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Aspect" /> class.
        /// </summary>
        /// <param name="_namespace">Unique namespace that identifies the System (required).</param>
        /// <param name="identifier">Unique Identifier of the object (required).</param>
        /// <param name="displayName">Name of the object, used for display purposes.</param>
        /// <param name="location">URL to access the object.</param>
        public Aspect(string _namespace = default(string), string identifier = default(string), string displayName = default(string), string location = default(string))
        {
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for Aspect and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }

            // to ensure "identifier" is required (not null)
            if (identifier == null)
            {
                throw new InvalidDataException("identifier is a required property for Aspect and cannot be null");
            }
            else
            {
                this.Identifier = identifier;
            }

            this.DisplayName = displayName;
            this.Location = location;
        }

        /// <summary>
        /// Unique namespace that identifies the System
        /// </summary>
        /// <value>Unique namespace that identifies the System</value>
        [DataMember(Name="namespace", EmitDefaultValue=true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Unique Identifier of the object
        /// </summary>
        /// <value>Unique Identifier of the object</value>
        [DataMember(Name="identifier", EmitDefaultValue=true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Name of the object, used for display purposes
        /// </summary>
        /// <value>Name of the object, used for display purposes</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// URL to access the object
        /// </summary>
        /// <value>URL to access the object</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Aspect {\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
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
            return this.Equals(input as Aspect);
        }

        /// <summary>
        /// Returns true if Aspect instances are equal
        /// </summary>
        /// <param name="input">Instance of Aspect to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Aspect input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
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
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                return hashCode;
            }
        }
    }

}
