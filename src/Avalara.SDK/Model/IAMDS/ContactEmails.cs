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
    /// ContactEmails
    /// </summary>
    [DataContract]
    public partial class ContactEmails :  IEquatable<ContactEmails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactEmails" /> class.
        /// </summary>
        /// <param name="emailId">Email address of the contact.</param>
        /// <param name="isPrimary">Is this the primary email Id for the contact.</param>
        public ContactEmails(string emailId = default(string), bool isPrimary = default(bool))
        {
            this.EmailId = emailId;
            this.IsPrimary = isPrimary;
        }

        /// <summary>
        /// Email address of the contact
        /// </summary>
        /// <value>Email address of the contact</value>
        [DataMember(Name="emailId", EmitDefaultValue=false)]
        public string EmailId { get; set; }

        /// <summary>
        /// Is this the primary email Id for the contact
        /// </summary>
        /// <value>Is this the primary email Id for the contact</value>
        [DataMember(Name="isPrimary", EmitDefaultValue=false)]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactEmails {\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
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
            return this.Equals(input as ContactEmails);
        }

        /// <summary>
        /// Returns true if ContactEmails instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactEmails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactEmails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailId == input.EmailId ||
                    (this.EmailId != null &&
                    this.EmailId.Equals(input.EmailId))
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
                if (this.EmailId != null)
                    hashCode = hashCode * 59 + this.EmailId.GetHashCode();
                if (this.IsPrimary != null)
                    hashCode = hashCode * 59 + this.IsPrimary.GetHashCode();
                return hashCode;
            }
        }
    }

}
