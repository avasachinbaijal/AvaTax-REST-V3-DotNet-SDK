/*
 Avalara API Client Library
 * Avalara Shipping Verification for Beverage Alcohol
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *
 * The version of SDK  : 2.1.5
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
