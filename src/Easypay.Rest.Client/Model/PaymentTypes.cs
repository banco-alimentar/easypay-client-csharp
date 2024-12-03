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
    /// Specifies the type of payment processed. Possible values include:  - Single: A one-time payment transaction. - Frequent: A payment that occurs regularly but is not part of a subscription (e.g., recurring manual payments). - Subscription: A recurring payment that is part of a subscription plan, automatically processed at regular intervals.  This field helps to categorize and manage different payment methods based on their frequency and nature.
    /// </summary>
    /// <value>Specifies the type of payment processed. Possible values include:  - Single: A one-time payment transaction. - Frequent: A payment that occurs regularly but is not part of a subscription (e.g., recurring manual payments). - Subscription: A recurring payment that is part of a subscription plan, automatically processed at regular intervals.  This field helps to categorize and manage different payment methods based on their frequency and nature.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentTypes
    {
        /// <summary>
        /// Enum Single for value: single
        /// </summary>
        [EnumMember(Value = "single")]
        Single = 1,

        /// <summary>
        /// Enum Frequent for value: frequent
        /// </summary>
        [EnumMember(Value = "frequent")]
        Frequent = 2,

        /// <summary>
        /// Enum Subscription for value: subscription
        /// </summary>
        [EnumMember(Value = "subscription")]
        Subscription = 3
    }

}