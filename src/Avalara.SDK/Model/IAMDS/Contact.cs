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
    /// Representation of a contact within the Avalara Compliance Cloud platform
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>
    {
        /// <summary>
        /// Source of truth for the contact
        /// </summary>
        /// <value>Source of truth for the contact</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceEnum
        {
            /// <summary>
            /// Enum Referenced for value: referenced
            /// </summary>
            [EnumMember(Value = "referenced")]
            Referenced = 1,

            /// <summary>
            /// Enum Managed for value: managed
            /// </summary>
            [EnumMember(Value = "managed")]
            Managed = 2

        }

        /// <summary>
        /// Source of truth for the contact
        /// </summary>
        /// <value>Source of truth for the contact</value>
        [DataMember(Name="source", EmitDefaultValue=true)]
        public SourceEnum Source { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Contact() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="source">Source of truth for the contact (required).</param>
        /// <param name="user">user.</param>
        /// <param name="name">name (required).</param>
        /// <param name="contactType">Type of contact.</param>
        /// <param name="emails">emails (required).</param>
        /// <param name="phoneNumbers">phoneNumbers.</param>
        public Contact(SourceEnum source = default(SourceEnum), Reference user = default(Reference), ContactName name = default(ContactName), string contactType = default(string), List<ContactEmails> emails = default(List<ContactEmails>), List<ContactPhoneNumbers> phoneNumbers = default(List<ContactPhoneNumbers>))
        {
            // to ensure "source" is required (not null)
            if (source == null)
            {
                throw new InvalidDataException("source is a required property for Contact and cannot be null");
            }
            else
            {
                this.Source = source;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Contact and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new InvalidDataException("emails is a required property for Contact and cannot be null");
            }
            else
            {
                this.Emails = emails;
            }

            this.User = user;
            this.ContactType = contactType;
            this.PhoneNumbers = phoneNumbers;
        }


        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public Reference User { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public ContactName Name { get; set; }

        /// <summary>
        /// Type of contact
        /// </summary>
        /// <value>Type of contact</value>
        [DataMember(Name="contactType", EmitDefaultValue=false)]
        public string ContactType { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=true)]
        public List<ContactEmails> Emails { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumbers
        /// </summary>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<ContactPhoneNumbers> PhoneNumbers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactType: ").Append(ContactType).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContactType == input.ContactType ||
                    (this.ContactType != null &&
                    this.ContactType.Equals(input.ContactType))
                ) && 
                (
                    this.Emails == input.Emails ||
                    this.Emails != null &&
                    input.Emails != null &&
                    this.Emails.SequenceEqual(input.Emails)
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
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
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ContactType != null)
                    hashCode = hashCode * 59 + this.ContactType.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                return hashCode;
            }
        }
    }

}
