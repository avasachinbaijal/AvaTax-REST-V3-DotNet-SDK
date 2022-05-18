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
    /// Representation of an User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected User() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="externalId">Identifier for the user in external systems (clients). The external systems manage this.</param>
        /// <param name="userName">Human readable unique identifier of the user, typically used to authenticate with an identity provider (required).</param>
        /// <param name="organization">organization (required).</param>
        /// <param name="name">The components of the user&#39;s real name.  Providers MAY return just the full name as a single string in the formatted sub-attribute, or they MAY return just the individual component attributes using the other sub-attributes, or they MAY return both.  If both variants are returned, they SHOULD be describing the same name, with the formatted name indicating how the component attributes should be combined..</param>
        /// <param name="displayName">The name of the User, suitable for display to end-users.  The name SHOULD be the full name of the User being described, if known.</param>
        /// <param name="nickName">The casual way to address the user in real life, e.g., &#39;Bob&#39; or &#39;Bobby&#39; instead of &#39;Robert&#39;.  This attribute SHOULD NOT be used to represent a User&#39;s username (e.g., &#39;bjensen&#39; or &#39;mpepperidge&#39;).</param>
        /// <param name="profileUrl">A fully qualified URL pointing to a page representing the User&#39;s online profile.</param>
        /// <param name="title">The user&#39;s title, such as \&quot;Vice President.\&quot;.</param>
        /// <param name="userType">Used to identify the relationship between the organization and the user.  Typical values used might be &#39;Contractor&#39;, &#39;Employee&#39;, &#39;Intern&#39;, &#39;Temp&#39;, &#39;External&#39;, and &#39;Unknown&#39;, but any value may be used.</param>
        /// <param name="preferredLanguage">Indicates the User&#39;s preferred written or spoken language.  Generally used for selecting a localized user interface; e.g., &#39;en_US&#39; specifies the language English and country US.</param>
        /// <param name="locale">Used to indicate the User&#39;s default location for purposes of localizing items such as currency, date time format, or numerical representations.</param>
        /// <param name="timezone">The User&#39;s time zone in the &#39;Olson&#39; time zone database format, e.g., &#39;America/Los_Angeles&#39;.</param>
        /// <param name="active">A Boolean value indicating the User&#39;s administrative status.</param>
        /// <param name="password">The User&#39;s cleartext password.  This attribute is intended to be used as a means to specify an initial password when creating a new User or to reset an existing User&#39;s password.</param>
        /// <param name="emails">A List of email addresses associated with the user (required).</param>
        /// <param name="phoneNumbers">A List of phone numbers associated with the user.</param>
        /// <param name="addresses">A physical mailing address for this User, as described in (address Element). Canonical Type Values of work, home, and other. The value attribute is a complex type with the following sub-attributes.</param>
        /// <param name="defaultTenant">defaultTenant.</param>
        /// <param name="customClaims">Custom claims that are returned along with a requested scope during authentication.</param>
        /// <param name="meta">meta.</param>
        /// <param name="aspects">Identifier of the Resource (if any) in other systems.</param>
        /// <param name="tags">User defined tags in the form of key:value pair.</param>
        public User(string externalId = default(string), string userName = default(string), Reference organization = default(Reference), Object name = default(Object), string displayName = default(string), string nickName = default(string), string profileUrl = default(string), string title = default(string), string userType = default(string), string preferredLanguage = default(string), string locale = default(string), string timezone = default(string), bool active = default(bool), string password = default(string), List<Object> emails = default(List<Object>), List<Object> phoneNumbers = default(List<Object>), List<Object> addresses = default(List<Object>), Reference defaultTenant = default(Reference), List<Object> customClaims = default(List<Object>), InstanceMeta meta = default(InstanceMeta), List<Aspect> aspects = default(List<Aspect>), List<Tag> tags = default(List<Tag>))
        {
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new InvalidDataException("userName is a required property for User and cannot be null");
            }
            else
            {
                this.UserName = userName;
            }

            // to ensure "organization" is required (not null)
            if (organization == null)
            {
                throw new InvalidDataException("organization is a required property for User and cannot be null");
            }
            else
            {
                this.Organization = organization;
            }

            // to ensure "emails" is required (not null)
            if (emails == null)
            {
                throw new InvalidDataException("emails is a required property for User and cannot be null");
            }
            else
            {
                this.Emails = emails;
            }

            this.ExternalId = externalId;
            this.Name = name;
            this.DisplayName = displayName;
            this.NickName = nickName;
            this.ProfileUrl = profileUrl;
            this.Title = title;
            this.UserType = userType;
            this.PreferredLanguage = preferredLanguage;
            this.Locale = locale;
            this.Timezone = timezone;
            this.Active = active;
            this.Password = password;
            this.PhoneNumbers = phoneNumbers;
            this.Addresses = addresses;
            this.DefaultTenant = defaultTenant;
            this.CustomClaims = customClaims;
            this.Meta = meta;
            this.Aspects = aspects;
            this.Tags = tags;
        }

        /// <summary>
        /// Identifier for the user in external systems (clients). The external systems manage this
        /// </summary>
        /// <value>Identifier for the user in external systems (clients). The external systems manage this</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Human readable unique identifier of the user, typically used to authenticate with an identity provider
        /// </summary>
        /// <value>Human readable unique identifier of the user, typically used to authenticate with an identity provider</value>
        [DataMember(Name="userName", EmitDefaultValue=true)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=true)]
        public Reference Organization { get; set; }

        /// <summary>
        /// The components of the user&#39;s real name.  Providers MAY return just the full name as a single string in the formatted sub-attribute, or they MAY return just the individual component attributes using the other sub-attributes, or they MAY return both.  If both variants are returned, they SHOULD be describing the same name, with the formatted name indicating how the component attributes should be combined.
        /// </summary>
        /// <value>The components of the user&#39;s real name.  Providers MAY return just the full name as a single string in the formatted sub-attribute, or they MAY return just the individual component attributes using the other sub-attributes, or they MAY return both.  If both variants are returned, they SHOULD be describing the same name, with the formatted name indicating how the component attributes should be combined.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public Object Name { get; set; }

        /// <summary>
        /// The name of the User, suitable for display to end-users.  The name SHOULD be the full name of the User being described, if known
        /// </summary>
        /// <value>The name of the User, suitable for display to end-users.  The name SHOULD be the full name of the User being described, if known</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The casual way to address the user in real life, e.g., &#39;Bob&#39; or &#39;Bobby&#39; instead of &#39;Robert&#39;.  This attribute SHOULD NOT be used to represent a User&#39;s username (e.g., &#39;bjensen&#39; or &#39;mpepperidge&#39;)
        /// </summary>
        /// <value>The casual way to address the user in real life, e.g., &#39;Bob&#39; or &#39;Bobby&#39; instead of &#39;Robert&#39;.  This attribute SHOULD NOT be used to represent a User&#39;s username (e.g., &#39;bjensen&#39; or &#39;mpepperidge&#39;)</value>
        [DataMember(Name="nickName", EmitDefaultValue=false)]
        public string NickName { get; set; }

        /// <summary>
        /// A fully qualified URL pointing to a page representing the User&#39;s online profile
        /// </summary>
        /// <value>A fully qualified URL pointing to a page representing the User&#39;s online profile</value>
        [DataMember(Name="profileUrl", EmitDefaultValue=false)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// The user&#39;s title, such as \&quot;Vice President.\&quot;
        /// </summary>
        /// <value>The user&#39;s title, such as \&quot;Vice President.\&quot;</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Used to identify the relationship between the organization and the user.  Typical values used might be &#39;Contractor&#39;, &#39;Employee&#39;, &#39;Intern&#39;, &#39;Temp&#39;, &#39;External&#39;, and &#39;Unknown&#39;, but any value may be used
        /// </summary>
        /// <value>Used to identify the relationship between the organization and the user.  Typical values used might be &#39;Contractor&#39;, &#39;Employee&#39;, &#39;Intern&#39;, &#39;Temp&#39;, &#39;External&#39;, and &#39;Unknown&#39;, but any value may be used</value>
        [DataMember(Name="userType", EmitDefaultValue=false)]
        public string UserType { get; set; }

        /// <summary>
        /// Indicates the User&#39;s preferred written or spoken language.  Generally used for selecting a localized user interface; e.g., &#39;en_US&#39; specifies the language English and country US
        /// </summary>
        /// <value>Indicates the User&#39;s preferred written or spoken language.  Generally used for selecting a localized user interface; e.g., &#39;en_US&#39; specifies the language English and country US</value>
        [DataMember(Name="preferredLanguage", EmitDefaultValue=false)]
        public string PreferredLanguage { get; set; }

        /// <summary>
        /// Used to indicate the User&#39;s default location for purposes of localizing items such as currency, date time format, or numerical representations
        /// </summary>
        /// <value>Used to indicate the User&#39;s default location for purposes of localizing items such as currency, date time format, or numerical representations</value>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }

        /// <summary>
        /// The User&#39;s time zone in the &#39;Olson&#39; time zone database format, e.g., &#39;America/Los_Angeles&#39;
        /// </summary>
        /// <value>The User&#39;s time zone in the &#39;Olson&#39; time zone database format, e.g., &#39;America/Los_Angeles&#39;</value>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// A Boolean value indicating the User&#39;s administrative status
        /// </summary>
        /// <value>A Boolean value indicating the User&#39;s administrative status</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// The User&#39;s cleartext password.  This attribute is intended to be used as a means to specify an initial password when creating a new User or to reset an existing User&#39;s password
        /// </summary>
        /// <value>The User&#39;s cleartext password.  This attribute is intended to be used as a means to specify an initial password when creating a new User or to reset an existing User&#39;s password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// A List of email addresses associated with the user
        /// </summary>
        /// <value>A List of email addresses associated with the user</value>
        [DataMember(Name="emails", EmitDefaultValue=true)]
        public List<Object> Emails { get; set; }

        /// <summary>
        /// A List of phone numbers associated with the user
        /// </summary>
        /// <value>A List of phone numbers associated with the user</value>
        [DataMember(Name="phoneNumbers", EmitDefaultValue=false)]
        public List<Object> PhoneNumbers { get; set; }

        /// <summary>
        /// A physical mailing address for this User, as described in (address Element). Canonical Type Values of work, home, and other. The value attribute is a complex type with the following sub-attributes
        /// </summary>
        /// <value>A physical mailing address for this User, as described in (address Element). Canonical Type Values of work, home, and other. The value attribute is a complex type with the following sub-attributes</value>
        [DataMember(Name="addresses", EmitDefaultValue=false)]
        public List<Object> Addresses { get; set; }

        /// <summary>
        /// Gets or Sets DefaultTenant
        /// </summary>
        [DataMember(Name="defaultTenant", EmitDefaultValue=false)]
        public Reference DefaultTenant { get; set; }

        /// <summary>
        /// Custom claims that are returned along with a requested scope during authentication
        /// </summary>
        /// <value>Custom claims that are returned along with a requested scope during authentication</value>
        [DataMember(Name="customClaims", EmitDefaultValue=false)]
        public List<Object> CustomClaims { get; set; }

        /// <summary>
        /// Unique identifier for the Object
        /// </summary>
        /// <value>Unique identifier for the Object</value>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public InstanceMeta Meta { get; set; }

        /// <summary>
        /// Identifier of the Resource (if any) in other systems
        /// </summary>
        /// <value>Identifier of the Resource (if any) in other systems</value>
        [DataMember(Name="aspects", EmitDefaultValue=false)]
        public List<Aspect> Aspects { get; set; }

        /// <summary>
        /// User defined tags in the form of key:value pair
        /// </summary>
        /// <value>User defined tags in the form of key:value pair</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  PreferredLanguage: ").Append(PreferredLanguage).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  DefaultTenant: ").Append(DefaultTenant).Append("\n");
            sb.Append("  CustomClaims: ").Append(CustomClaims).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Aspects: ").Append(Aspects).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.ProfileUrl == input.ProfileUrl ||
                    (this.ProfileUrl != null &&
                    this.ProfileUrl.Equals(input.ProfileUrl))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
                ) && 
                (
                    this.PreferredLanguage == input.PreferredLanguage ||
                    (this.PreferredLanguage != null &&
                    this.PreferredLanguage.Equals(input.PreferredLanguage))
                ) && 
                (
                    this.Locale == input.Locale ||
                    (this.Locale != null &&
                    this.Locale.Equals(input.Locale))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
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
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.DefaultTenant == input.DefaultTenant ||
                    (this.DefaultTenant != null &&
                    this.DefaultTenant.Equals(input.DefaultTenant))
                ) && 
                (
                    this.CustomClaims == input.CustomClaims ||
                    this.CustomClaims != null &&
                    input.CustomClaims != null &&
                    this.CustomClaims.SequenceEqual(input.CustomClaims)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Aspects == input.Aspects ||
                    this.Aspects != null &&
                    input.Aspects != null &&
                    this.Aspects.SequenceEqual(input.Aspects)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.ProfileUrl != null)
                    hashCode = hashCode * 59 + this.ProfileUrl.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.UserType != null)
                    hashCode = hashCode * 59 + this.UserType.GetHashCode();
                if (this.PreferredLanguage != null)
                    hashCode = hashCode * 59 + this.PreferredLanguage.GetHashCode();
                if (this.Locale != null)
                    hashCode = hashCode * 59 + this.Locale.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Emails != null)
                    hashCode = hashCode * 59 + this.Emails.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.DefaultTenant != null)
                    hashCode = hashCode * 59 + this.DefaultTenant.GetHashCode();
                if (this.CustomClaims != null)
                    hashCode = hashCode * 59 + this.CustomClaims.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Aspects != null)
                    hashCode = hashCode * 59 + this.Aspects.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                return hashCode;
            }
        }
    }

}
