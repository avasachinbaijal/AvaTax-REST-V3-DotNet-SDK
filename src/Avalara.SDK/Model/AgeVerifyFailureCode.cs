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
 * @version    2.4.22-beta
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
    /// Defines AgeVerifyFailureCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AgeVerifyFailureCode
    {
        /// <summary>
        /// Enum NotFound for value: not_found
        /// </summary>
        [EnumMember(Value = "not_found")]
        NotFound = 1,

        /// <summary>
        /// Enum DobUnverifiable for value: dob_unverifiable
        /// </summary>
        [EnumMember(Value = "dob_unverifiable")]
        DobUnverifiable = 2,

        /// <summary>
        /// Enum UnderAge for value: under_age
        /// </summary>
        [EnumMember(Value = "under_age")]
        UnderAge = 3,

        /// <summary>
        /// Enum SuspectedFraud for value: suspected_fraud
        /// </summary>
        [EnumMember(Value = "suspected_fraud")]
        SuspectedFraud = 4,

        /// <summary>
        /// Enum Deceased for value: deceased
        /// </summary>
        [EnumMember(Value = "deceased")]
        Deceased = 5,

        /// <summary>
        /// Enum UnknownError for value: unknown_error
        /// </summary>
        [EnumMember(Value = "unknown_error")]
        UnknownError = 6

    }

}
