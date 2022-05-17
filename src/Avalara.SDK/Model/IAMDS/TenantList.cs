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
    /// TenantList
    /// </summary>
    [DataContract]
    public partial class TenantList :  IEquatable<TenantList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantList" /> class.
        /// </summary>
        /// <param name="recordsetCount">recordsetCount.</param>
        /// <param name="nextLink">nextLink.</param>
        /// <param name="pageKey">pageKey.</param>
        /// <param name="items">items.</param>
        public TenantList(int recordsetCount = default(int), string nextLink = default(string), string pageKey = default(string), List<Tenant> items = default(List<Tenant>))
        {
            this.RecordsetCount = recordsetCount;
            this.NextLink = nextLink;
            this.PageKey = pageKey;
            this.Items = items;
        }

        /// <summary>
        /// Gets or Sets RecordsetCount
        /// </summary>
        [DataMember(Name="@recordsetCount", EmitDefaultValue=false)]
        public int RecordsetCount { get; set; }

        /// <summary>
        /// Gets or Sets NextLink
        /// </summary>
        [DataMember(Name="@nextLink", EmitDefaultValue=false)]
        public string NextLink { get; set; }

        /// <summary>
        /// Gets or Sets PageKey
        /// </summary>
        [DataMember(Name="pageKey", EmitDefaultValue=false)]
        public string PageKey { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<Tenant> Items { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantList {\n");
            sb.Append("  RecordsetCount: ").Append(RecordsetCount).Append("\n");
            sb.Append("  NextLink: ").Append(NextLink).Append("\n");
            sb.Append("  PageKey: ").Append(PageKey).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
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
            return this.Equals(input as TenantList);
        }

        /// <summary>
        /// Returns true if TenantList instances are equal
        /// </summary>
        /// <param name="input">Instance of TenantList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TenantList input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecordsetCount == input.RecordsetCount ||
                    (this.RecordsetCount != null &&
                    this.RecordsetCount.Equals(input.RecordsetCount))
                ) && 
                (
                    this.NextLink == input.NextLink ||
                    (this.NextLink != null &&
                    this.NextLink.Equals(input.NextLink))
                ) && 
                (
                    this.PageKey == input.PageKey ||
                    (this.PageKey != null &&
                    this.PageKey.Equals(input.PageKey))
                ) && 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
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
                if (this.RecordsetCount != null)
                    hashCode = hashCode * 59 + this.RecordsetCount.GetHashCode();
                if (this.NextLink != null)
                    hashCode = hashCode * 59 + this.NextLink.GetHashCode();
                if (this.PageKey != null)
                    hashCode = hashCode * 59 + this.PageKey.GetHashCode();
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                return hashCode;
            }
        }
    }

}
