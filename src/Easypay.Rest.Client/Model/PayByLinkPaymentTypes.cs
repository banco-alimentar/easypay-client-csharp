/*
 * Easypay Payments API
 *
 * <a href='https://www.easypay.pt/en/legal-terms-and-conditions/' class='item'>Terms conditions and legal terms</a><br><a href='https://www.easypay.pt/en/privacy-and-data-protection-policy/' class='item'>Privacy Policy</a>
 *
 * The version of the OpenAPI document: 2.0
 * Contact: tec@easypay.pt
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Easypay.Rest.Client.Client.OpenAPIDateConverter;

namespace Easypay.Rest.Client.Model
{
    /// <summary>
    /// Defines PayByLinkPaymentTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PayByLinkPaymentTypes
    {
        /// <summary>
        /// Enum SINGLE for value: SINGLE
        /// </summary>
        [EnumMember(Value = "SINGLE")]
        SINGLE = 1,

        /// <summary>
        /// Enum FREQUENT for value: FREQUENT
        /// </summary>
        [EnumMember(Value = "FREQUENT")]
        FREQUENT = 2,

        /// <summary>
        /// Enum SUBSCRIPTION for value: SUBSCRIPTION
        /// </summary>
        [EnumMember(Value = "SUBSCRIPTION")]
        SUBSCRIPTION = 3
    }

}
