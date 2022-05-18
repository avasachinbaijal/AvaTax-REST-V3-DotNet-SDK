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
    /// Defines VersionError
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum VersionError
    {
        /// <summary>
        /// Enum TooNew for value: version-too-new
        /// </summary>
        [EnumMember(Value = "version-too-new")]
        TooNew = 1,

        /// <summary>
        /// Enum TooOld for value: version-too-old
        /// </summary>
        [EnumMember(Value = "version-too-old")]
        TooOld = 2,

        /// <summary>
        /// Enum NotValid for value: version-not-valid
        /// </summary>
        [EnumMember(Value = "version-not-valid")]
        NotValid = 3

    }

}
