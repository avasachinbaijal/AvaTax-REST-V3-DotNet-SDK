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
 * @version    2.4.7.1
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
    /// ShippingVerifyResultLines
    /// </summary>
    [DataContract(Name = "ShippingVerifyResult_lines")]
    public partial class ShippingVerifyResultLines : IEquatable<ShippingVerifyResultLines>, IValidatableObject
    {
        /// <summary>
        /// Describes whether the line is compliant or not. In cases where a determination could not be made, resultCode will provide the reason why.
        /// </summary>
        /// <value>Describes whether the line is compliant or not. In cases where a determination could not be made, resultCode will provide the reason why.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultCodeEnum
        {
            /// <summary>
            /// Enum Compliant for value: Compliant
            /// </summary>
            [EnumMember(Value = "Compliant")]
            Compliant = 1,

            /// <summary>
            /// Enum NotCompliant for value: NotCompliant
            /// </summary>
            [EnumMember(Value = "NotCompliant")]
            NotCompliant = 2,

            /// <summary>
            /// Enum UnsupportedTaxCode for value: UnsupportedTaxCode
            /// </summary>
            [EnumMember(Value = "UnsupportedTaxCode")]
            UnsupportedTaxCode = 3,

            /// <summary>
            /// Enum UnsupportedAddress for value: UnsupportedAddress
            /// </summary>
            [EnumMember(Value = "UnsupportedAddress")]
            UnsupportedAddress = 4,

            /// <summary>
            /// Enum InvalidLine for value: InvalidLine
            /// </summary>
            [EnumMember(Value = "InvalidLine")]
            InvalidLine = 5

        }


        /// <summary>
        /// Describes whether the line is compliant or not. In cases where a determination could not be made, resultCode will provide the reason why.
        /// </summary>
        /// <value>Describes whether the line is compliant or not. In cases where a determination could not be made, resultCode will provide the reason why.</value>
        [DataMember(Name = "resultCode", EmitDefaultValue = false)]
        public ResultCodeEnum? ResultCode { get; set; }
        /// <summary>
        /// Defines FailureCodes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FailureCodesEnum
        {
            /// <summary>
            /// Enum BelowLegalDrinkingAge for value: BelowLegalDrinkingAge
            /// </summary>
            [EnumMember(Value = "BelowLegalDrinkingAge")]
            BelowLegalDrinkingAge = 1,

            /// <summary>
            /// Enum ShippingProhibitedToAddress for value: ShippingProhibitedToAddress
            /// </summary>
            [EnumMember(Value = "ShippingProhibitedToAddress")]
            ShippingProhibitedToAddress = 2,

            /// <summary>
            /// Enum MissingRequiredLicense for value: MissingRequiredLicense
            /// </summary>
            [EnumMember(Value = "MissingRequiredLicense")]
            MissingRequiredLicense = 3,

            /// <summary>
            /// Enum VolumeLimitExceeded for value: VolumeLimitExceeded
            /// </summary>
            [EnumMember(Value = "VolumeLimitExceeded")]
            VolumeLimitExceeded = 4,

            /// <summary>
            /// Enum InvalidFieldValue for value: InvalidFieldValue
            /// </summary>
            [EnumMember(Value = "InvalidFieldValue")]
            InvalidFieldValue = 5,

            /// <summary>
            /// Enum MissingRequiredField for value: MissingRequiredField
            /// </summary>
            [EnumMember(Value = "MissingRequiredField")]
            MissingRequiredField = 6,

            /// <summary>
            /// Enum InvalidFieldType for value: InvalidFieldType
            /// </summary>
            [EnumMember(Value = "InvalidFieldType")]
            InvalidFieldType = 7,

            /// <summary>
            /// Enum InvalidFormat for value: InvalidFormat
            /// </summary>
            [EnumMember(Value = "InvalidFormat")]
            InvalidFormat = 8,

            /// <summary>
            /// Enum InvalidDate for value: InvalidDate
            /// </summary>
            [EnumMember(Value = "InvalidDate")]
            InvalidDate = 9

        }



        /// <summary>
        /// An enumeration of all the failure codes received for this line.
        /// </summary>
        /// <value>An enumeration of all the failure codes received for this line.</value>
        [DataMember(Name = "failureCodes", EmitDefaultValue = false)]
        public List<FailureCodesEnum> FailureCodes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingVerifyResultLines" /> class.
        /// </summary>
        /// <param name="resultCode">Describes whether the line is compliant or not. In cases where a determination could not be made, resultCode will provide the reason why..</param>
        /// <param name="lineNumber">The lineNumber of the line evaluated..</param>
        /// <param name="message">A short description of the result of the checks made against this line..</param>
        /// <param name="successMessages">A detailed description of the result of each of the passed checks made against this line..</param>
        /// <param name="failureMessages">A detailed description of the result of each of the failed checks made against this line..</param>
        /// <param name="failureCodes">An enumeration of all the failure codes received for this line..</param>
        public ShippingVerifyResultLines(ResultCodeEnum? resultCode = default(ResultCodeEnum?), string lineNumber = default(string), string message = default(string), string successMessages = default(string), string failureMessages = default(string), List<FailureCodesEnum> failureCodes = default(List<FailureCodesEnum>))
        {
            this.ResultCode = resultCode;
            this.LineNumber = lineNumber;
            this.Message = message;
            this.SuccessMessages = successMessages;
            this.FailureMessages = failureMessages;
            this.FailureCodes = failureCodes;
        }

        /// <summary>
        /// The lineNumber of the line evaluated.
        /// </summary>
        /// <value>The lineNumber of the line evaluated.</value>
        [DataMember(Name = "lineNumber", EmitDefaultValue = false)]
        public string LineNumber { get; set; }

        /// <summary>
        /// A short description of the result of the checks made against this line.
        /// </summary>
        /// <value>A short description of the result of the checks made against this line.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// A detailed description of the result of each of the passed checks made against this line.
        /// </summary>
        /// <value>A detailed description of the result of each of the passed checks made against this line.</value>
        [DataMember(Name = "successMessages", EmitDefaultValue = false)]
        public string SuccessMessages { get; set; }

        /// <summary>
        /// A detailed description of the result of each of the failed checks made against this line.
        /// </summary>
        /// <value>A detailed description of the result of each of the failed checks made against this line.</value>
        [DataMember(Name = "failureMessages", EmitDefaultValue = false)]
        public string FailureMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingVerifyResultLines {\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  LineNumber: ").Append(LineNumber).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  SuccessMessages: ").Append(SuccessMessages).Append("\n");
            sb.Append("  FailureMessages: ").Append(FailureMessages).Append("\n");
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
            return this.Equals(input as ShippingVerifyResultLines);
        }

        /// <summary>
        /// Returns true if ShippingVerifyResultLines instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingVerifyResultLines to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingVerifyResultLines input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ResultCode == input.ResultCode ||
                    this.ResultCode.Equals(input.ResultCode)
                ) && 
                (
                    this.LineNumber == input.LineNumber ||
                    (this.LineNumber != null &&
                    this.LineNumber.Equals(input.LineNumber))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.SuccessMessages == input.SuccessMessages ||
                    (this.SuccessMessages != null &&
                    this.SuccessMessages.Equals(input.SuccessMessages))
                ) && 
                (
                    this.FailureMessages == input.FailureMessages ||
                    (this.FailureMessages != null &&
                    this.FailureMessages.Equals(input.FailureMessages))
                ) && 
                (
                    this.FailureCodes == input.FailureCodes ||
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
                hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                if (this.LineNumber != null)
                {
                    hashCode = (hashCode * 59) + this.LineNumber.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.SuccessMessages != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessMessages.GetHashCode();
                }
                if (this.FailureMessages != null)
                {
                    hashCode = (hashCode * 59) + this.FailureMessages.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FailureCodes.GetHashCode();
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
