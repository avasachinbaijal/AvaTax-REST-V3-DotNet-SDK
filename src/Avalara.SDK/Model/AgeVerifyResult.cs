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
 * @version    2.4.7.2
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

namespace Avalara.SDK.Model
{
    /// <summary>
    /// The Result of a call to the /ageVerification/verify endpoint.
    /// </summary>
    [DataContract(Name = "AgeVerifyResult")]
    public partial class AgeVerifyResult : IEquatable<AgeVerifyResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgeVerifyResult" /> class.
        /// </summary>
        /// <param name="isOfAge">Describes whether the individual meets or exceeds the minimum legal drinking age..</param>
        /// <param name="failureCodes">A list of failure codes describing why a *false* age determination was made..</param>
        public AgeVerifyResult(bool isOfAge = default(bool), List<AgeVerifyResult> failureCodes = default(List<AgeVerifyResult>))
        {
            this.IsOfAge = isOfAge;
            this.FailureCodes = failureCodes;
        }

        /// <summary>
        /// Describes whether the individual meets or exceeds the minimum legal drinking age.
        /// </summary>
        /// <value>Describes whether the individual meets or exceeds the minimum legal drinking age.</value>
        [DataMember(Name = "isOfAge", EmitDefaultValue = true)]
        public bool IsOfAge { get; set; }

        /// <summary>
        /// A list of failure codes describing why a *false* age determination was made.
        /// </summary>
        /// <value>A list of failure codes describing why a *false* age determination was made.</value>
        [DataMember(Name = "failureCodes", EmitDefaultValue = false)]
        public List<AgeVerifyResult> FailureCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgeVerifyResult {\n");
            sb.Append("  IsOfAge: ").Append(IsOfAge).Append("\n");
            sb.Append("  FailureCodes: ").Append(FailureCodes).Append("\n");
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
            return this.Equals(input as AgeVerifyResult);
        }

        /// <summary>
        /// Returns true if AgeVerifyResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AgeVerifyResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgeVerifyResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsOfAge == input.IsOfAge ||
                    this.IsOfAge.Equals(input.IsOfAge)
                ) && 
                (
                    this.FailureCodes == input.FailureCodes ||
                    this.FailureCodes != null &&
                    input.FailureCodes != null &&
                    this.FailureCodes.SequenceEqual(input.FailureCodes)
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
                hashCode = (hashCode * 59) + this.IsOfAge.GetHashCode();
                if (this.FailureCodes != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCodes.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
