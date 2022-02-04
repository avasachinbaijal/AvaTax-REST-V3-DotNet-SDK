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
 * @version    2.4.9
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
    /// An object holding details about the error.
    /// </summary>
    [DataContract(Name = "ErrorDetails_error")]
    public partial class ErrorDetailsError : IEquatable<ErrorDetailsError>, IValidatableObject
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
            /// Enum ServerConfiguration for value: ServerConfiguration
            /// </summary>
            [EnumMember(Value = "ServerConfiguration")]
            ServerConfiguration = 3,

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
        /// Initializes a new instance of the <see cref="ErrorDetailsError" /> class.
        /// </summary>
        /// <param name="code">Name of the error or message..</param>
        /// <param name="message">Concise summary of the message, suitable for display in the caption of an alert box..</param>
        /// <param name="details">details.</param>
        public ErrorDetailsError(CodeEnum? code = default(CodeEnum?), string message = default(string), ErrorDetailsErrorDetails details = default(ErrorDetailsErrorDetails))
        {
            this.Code = code;
            this.Message = message;
            this.Details = details;
        }

        /// <summary>
        /// Concise summary of the message, suitable for display in the caption of an alert box.
        /// </summary>
        /// <value>Concise summary of the message, suitable for display in the caption of an alert box.</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public ErrorDetailsErrorDetails Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorDetailsError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
            return this.Equals(input as ErrorDetailsError);
        }

        /// <summary>
        /// Returns true if ErrorDetailsError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorDetailsError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetailsError input)
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
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
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
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
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
