/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara Shipping Verification only
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
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

namespace Avalara.SDK.Model.AgeVerification
{
    /// <summary>
    /// The Request for the /ageVerification/verify endpoint. Describes information about the person whose age is being verified.
    /// </summary>
    [DataContract]
    public partial class AgeVerifyRequest :  IEquatable<AgeVerifyRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeVerifyRequest" /> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="address">address.</param>
        /// <param name="dOB">The value should be ISO-8601 compliant (e.g. 2020-07-21)..</param>
        public AgeVerifyRequest(string firstName = default(string), string lastName = default(string), AgeVerifyRequestAddress address = default(AgeVerifyRequestAddress), string dOB = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.DOB = dOB;
        }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public AgeVerifyRequestAddress Address { get; set; }

        /// <summary>
        /// The value should be ISO-8601 compliant (e.g. 2020-07-21).
        /// </summary>
        /// <value>The value should be ISO-8601 compliant (e.g. 2020-07-21).</value>
        [DataMember(Name="DOB", EmitDefaultValue=false)]
        public string DOB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AgeVerifyRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  DOB: ").Append(DOB).Append("\n");
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
            return this.Equals(input as AgeVerifyRequest);
        }

        /// <summary>
        /// Returns true if AgeVerifyRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AgeVerifyRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgeVerifyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.DOB == input.DOB ||
                    (this.DOB != null &&
                    this.DOB.Equals(input.DOB))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.DOB != null)
                    hashCode = hashCode * 59 + this.DOB.GetHashCode();
                return hashCode;
            }
        }
    }

}
