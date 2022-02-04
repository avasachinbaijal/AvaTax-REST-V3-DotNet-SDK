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
 * @version    2.4.19
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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Message Details Object
    /// </summary>
    [DataContract(Name = "ErrorDetails_error_details")]
    public partial class ErrorDetailsErrorDetails : IEquatable<ErrorDetailsErrorDetails>, IValidatableObject
    {
        /// <summary>
        /// Name of the error or message.
        /// </summary>
        /// <value>Name of the error or message.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum AuthenticationException for value: AuthenticationException
            /// </summary>
            [EnumMember(Value = "AuthenticationException")]
            AuthenticationException = 1,

            /// <summary>
            /// Enum SubscriptionRequired for value: SubscriptionRequired
            /// </summary>
            [EnumMember(Value = "SubscriptionRequired")]
            SubscriptionRequired = 2,

            /// <summary>
            /// Enum UnhandledException for value: UnhandledException
            /// </summary>
            [EnumMember(Value = "UnhandledException")]
            UnhandledException = 3,

            /// <summary>
            /// Enum InvalidAddress for value: InvalidAddress
            /// </summary>
            [EnumMember(Value = "InvalidAddress")]
            InvalidAddress = 4,

            /// <summary>
            /// Enum EntityNotFoundError for value: EntityNotFoundError
            /// </summary>
            [EnumMember(Value = "EntityNotFoundError")]
            EntityNotFoundError = 5

        }


        /// <summary>
        /// Name of the error or message.
        /// </summary>
        /// <value>Name of the error or message.</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Severity of the message
        /// </summary>
        /// <value>Severity of the message</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SeverityEnum
        {
            /// <summary>
            /// Enum Error for value: Error
            /// </summary>
            [EnumMember(Value = "Error")]
            Error = 1

        }


        /// <summary>
        /// Severity of the message
        /// </summary>
        /// <value>Severity of the message</value>
        [DataMember(Name = "severity", EmitDefaultValue = false)]
        public SeverityEnum? Severity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetailsErrorDetails" /> class.
        /// </summary>
        /// <param name="code">Name of the error or message..</param>
        /// <param name="message">Concise summary of the message, suitable for display in the caption of an alert box..</param>
        /// <param name="number">Unique ID number referring to this error or message..</param>
        /// <param name="description">A more detailed description of the problem referenced by this error message, suitable for display in the contents area of an alert box..</param>
        /// <param name="faultCode">Indicates the SOAP Fault code, if this was related to an error that corresponded to AvaTax SOAP v1 behavior..</param>
        /// <param name="helpLink">URL to help for this message.</param>
        /// <param name="severity">Severity of the message.</param>
        public ErrorDetailsErrorDetails(CodeEnum? code = default(CodeEnum?), string message = default(string), int number = default(int), string description = default(string), string faultCode = default(string), string helpLink = default(string), SeverityEnum? severity = default(SeverityEnum?))
        {
            this.Code = code;
            this.Message = message;
            this.Number = number;
            this.Description = description;
            this.FaultCode = faultCode;
            this.HelpLink = helpLink;
            this.Severity = severity;
        }

        /// <summary>
        /// Concise summary of the message, suitable for display in the caption of an alert box.
        /// </summary>
        /// <value>Concise summary of the message, suitable for display in the caption of an alert box.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Unique ID number referring to this error or message.
        /// </summary>
        /// <value>Unique ID number referring to this error or message.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// A more detailed description of the problem referenced by this error message, suitable for display in the contents area of an alert box.
        /// </summary>
        /// <value>A more detailed description of the problem referenced by this error message, suitable for display in the contents area of an alert box.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates the SOAP Fault code, if this was related to an error that corresponded to AvaTax SOAP v1 behavior.
        /// </summary>
        /// <value>Indicates the SOAP Fault code, if this was related to an error that corresponded to AvaTax SOAP v1 behavior.</value>
        [DataMember(Name = "faultCode", EmitDefaultValue = false)]
        public string FaultCode { get; set; }

        /// <summary>
        /// URL to help for this message
        /// </summary>
        /// <value>URL to help for this message</value>
        [DataMember(Name = "helpLink", EmitDefaultValue = false)]
        public string HelpLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorDetailsErrorDetails {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FaultCode: ").Append(FaultCode).Append("\n");
            sb.Append("  HelpLink: ").Append(HelpLink).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
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
            return this.Equals(input as ErrorDetailsErrorDetails);
        }

        /// <summary>
        /// Returns true if ErrorDetailsErrorDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorDetailsErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetailsErrorDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FaultCode == input.FaultCode ||
                    (this.FaultCode != null &&
                    this.FaultCode.Equals(input.FaultCode))
                ) && 
                (
                    this.HelpLink == input.HelpLink ||
                    (this.HelpLink != null &&
                    this.HelpLink.Equals(input.HelpLink))
                ) && 
                (
                    this.Severity == input.Severity ||
                    this.Severity.Equals(input.Severity)
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
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.FaultCode != null)
                {
                    hashCode = (hashCode * 59) + this.FaultCode.GetHashCode();
                }
                if (this.HelpLink != null)
                {
                    hashCode = (hashCode * 59) + this.HelpLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Severity.GetHashCode();
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
