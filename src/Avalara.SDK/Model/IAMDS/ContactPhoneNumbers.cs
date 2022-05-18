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
    /// ContactPhoneNumbers
    /// </summary>
    [DataContract]
    public partial class ContactPhoneNumbers :  IEquatable<ContactPhoneNumbers>
    {
        /// <summary>
        /// Type of phone number
        /// </summary>
        /// <value>Type of phone number</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneTypeEnum
        {
            /// <summary>
            /// Enum Work for value: work
            /// </summary>
            [EnumMember(Value = "work")]
            Work = 1,

            /// <summary>
            /// Enum Home for value: home
            /// </summary>
            [EnumMember(Value = "home")]
            Home = 2,

            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 3,

            /// <summary>
            /// Enum Fax for value: fax
            /// </summary>
            [EnumMember(Value = "fax")]
            Fax = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }

        /// <summary>
        /// Type of phone number
        /// </summary>
        /// <value>Type of phone number</value>
        [DataMember(Name="phoneType", EmitDefaultValue=false)]
        public PhoneTypeEnum? PhoneType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactPhoneNumbers" /> class.
        /// </summary>
        /// <param name="number">Phone number of the contact.</param>
        /// <param name="phoneType">Type of phone number.</param>
        /// <param name="isPrimary">Is this the primary phone number for the contact.</param>
        public ContactPhoneNumbers(string number = default(string), PhoneTypeEnum? phoneType = default(PhoneTypeEnum?), bool isPrimary = default(bool))
        {
            this.Number = number;
            this.PhoneType = phoneType;
            this.IsPrimary = isPrimary;
        }

        /// <summary>
        /// Phone number of the contact
        /// </summary>
        /// <value>Phone number of the contact</value>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public string Number { get; set; }


        /// <summary>
        /// Is this the primary phone number for the contact
        /// </summary>
        /// <value>Is this the primary phone number for the contact</value>
        [DataMember(Name="isPrimary", EmitDefaultValue=false)]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactPhoneNumbers {\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  PhoneType: ").Append(PhoneType).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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
            return this.Equals(input as ContactPhoneNumbers);
        }

        /// <summary>
        /// Returns true if ContactPhoneNumbers instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactPhoneNumbers to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactPhoneNumbers input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.PhoneType == input.PhoneType ||
                    (this.PhoneType != null &&
                    this.PhoneType.Equals(input.PhoneType))
                ) && 
                (
                    this.IsPrimary == input.IsPrimary ||
                    (this.IsPrimary != null &&
                    this.IsPrimary.Equals(input.IsPrimary))
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
                if (this.Number != null)
                    hashCode = hashCode * 59 + this.Number.GetHashCode();
                if (this.PhoneType != null)
                    hashCode = hashCode * 59 + this.PhoneType.GetHashCode();
                if (this.IsPrimary != null)
                    hashCode = hashCode * 59 + this.IsPrimary.GetHashCode();
                return hashCode;
            }
        }
    }

}
