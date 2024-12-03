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
    /// SubscriptionIdPatchRequest
    /// </summary>
    [DataContract(Name = "_subscription__id__patch_request")]
    public partial class SubscriptionIdPatchRequest : IValidatableObject
    {
        /// <summary>
        /// The Payment Status.
        /// </summary>
        /// <value>The Payment Status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2
        }


        /// <summary>
        /// The Payment Status.
        /// </summary>
        /// <value>The Payment Status.</value>
        /*
        <example>active</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Defines Frequency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FrequencyEnum
        {
            /// <summary>
            /// Enum _1D for value: 1D
            /// </summary>
            [EnumMember(Value = "1D")]
            _1D = 1,

            /// <summary>
            /// Enum _1W for value: 1W
            /// </summary>
            [EnumMember(Value = "1W")]
            _1W = 2,

            /// <summary>
            /// Enum _2W for value: 2W
            /// </summary>
            [EnumMember(Value = "2W")]
            _2W = 3,

            /// <summary>
            /// Enum _1M for value: 1M
            /// </summary>
            [EnumMember(Value = "1M")]
            _1M = 4,

            /// <summary>
            /// Enum _2M for value: 2M
            /// </summary>
            [EnumMember(Value = "2M")]
            _2M = 5,

            /// <summary>
            /// Enum _3M for value: 3M
            /// </summary>
            [EnumMember(Value = "3M")]
            _3M = 6,

            /// <summary>
            /// Enum _4M for value: 4M
            /// </summary>
            [EnumMember(Value = "4M")]
            _4M = 7,

            /// <summary>
            /// Enum _6M for value: 6M
            /// </summary>
            [EnumMember(Value = "6M")]
            _6M = 8,

            /// <summary>
            /// Enum _1Y for value: 1Y
            /// </summary>
            [EnumMember(Value = "1Y")]
            _1Y = 9,

            /// <summary>
            /// Enum _2Y for value: 2Y
            /// </summary>
            [EnumMember(Value = "2Y")]
            _2Y = 10,

            /// <summary>
            /// Enum _3Y for value: 3Y
            /// </summary>
            [EnumMember(Value = "3Y")]
            _3Y = 11
        }


        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        /*
        <example>1W</example>
        */
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public FrequencyEnum? Frequency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionIdPatchRequest" /> class.
        /// </summary>
        /// <param name="status">The Payment Status..</param>
        /// <param name="capture">capture.</param>
        /// <param name="expirationTime">Required only when no max_captures is set.&lt;/br&gt;The last possible time to make the payment..</param>
        /// <param name="currency">currency.</param>
        /// <param name="customer">customer.</param>
        /// <param name="key">The merchant&#39;s key for identifying the payment..</param>
        /// <param name="value">The payment value.&lt;/br&gt;Will be rounded to 2 decimals..</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="maxCaptures">Required when no expiration_time is set.&lt;/br&gt;Number of payments..</param>
        /// <param name="startTime">Defining the start of billing cycles..</param>
        /// <param name="failover">After all retries failed, the payment cycle can have another try with another single method. (default to false).</param>
        /// <param name="retries">Number of retries in each payment cycle.&lt;/br&gt; The chosen frequency will define the max number of possible retries. (default to 0).</param>
        /// <param name="sddMandate">sddMandate.</param>
        public SubscriptionIdPatchRequest(StatusEnum? status = default(StatusEnum?), SubscriptionPostRequestCapture capture = default(SubscriptionPostRequestCapture), string expirationTime = default(string), Currency? currency = default(Currency?), SubscriptionIdPatchRequestCustomer customer = default(SubscriptionIdPatchRequestCustomer), string key = default(string), double value = default(double), FrequencyEnum? frequency = default(FrequencyEnum?), int maxCaptures = default(int), string startTime = default(string), bool failover = false, int retries = 0, SddMandate sddMandate = default(SddMandate))
        {
            this.Status = status;
            this.Capture = capture;
            this.ExpirationTime = expirationTime;
            this.Currency = currency;
            this.Customer = customer;
            this.Key = key;
            this.Value = value;
            this.Frequency = frequency;
            this.MaxCaptures = maxCaptures;
            this.StartTime = startTime;
            this.Failover = failover;
            this.Retries = retries;
            this.SddMandate = sddMandate;
        }

        /// <summary>
        /// Gets or Sets Capture
        /// </summary>
        [DataMember(Name = "capture", EmitDefaultValue = false)]
        public SubscriptionPostRequestCapture Capture { get; set; }

        /// <summary>
        /// Required only when no max_captures is set.&lt;/br&gt;The last possible time to make the payment.
        /// </summary>
        /// <value>Required only when no max_captures is set.&lt;/br&gt;The last possible time to make the payment.</value>
        /*
        <example>2017-12-12 16:05</example>
        */
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public SubscriptionIdPatchRequestCustomer Customer { get; set; }

        /// <summary>
        /// The merchant&#39;s key for identifying the payment.
        /// </summary>
        /// <value>The merchant&#39;s key for identifying the payment.</value>
        /*
        <example>Example Key</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// The payment value.&lt;/br&gt;Will be rounded to 2 decimals.
        /// </summary>
        /// <value>The payment value.&lt;/br&gt;Will be rounded to 2 decimals.</value>
        /*
        <example>12.55</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Required when no expiration_time is set.&lt;/br&gt;Number of payments.
        /// </summary>
        /// <value>Required when no expiration_time is set.&lt;/br&gt;Number of payments.</value>
        [DataMember(Name = "max_captures", EmitDefaultValue = false)]
        public int MaxCaptures { get; set; }

        /// <summary>
        /// Defining the start of billing cycles.
        /// </summary>
        /// <value>Defining the start of billing cycles.</value>
        /*
        <example>2017-12-12 16:05</example>
        */
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// After all retries failed, the payment cycle can have another try with another single method.
        /// </summary>
        /// <value>After all retries failed, the payment cycle can have another try with another single method.</value>
        [DataMember(Name = "failover", EmitDefaultValue = true)]
        public bool Failover { get; set; }

        /// <summary>
        /// Number of retries in each payment cycle.&lt;/br&gt; The chosen frequency will define the max number of possible retries.
        /// </summary>
        /// <value>Number of retries in each payment cycle.&lt;/br&gt; The chosen frequency will define the max number of possible retries.</value>
        [DataMember(Name = "retries", EmitDefaultValue = false)]
        public int Retries { get; set; }

        /// <summary>
        /// Gets or Sets SddMandate
        /// </summary>
        [DataMember(Name = "sdd_mandate", EmitDefaultValue = false)]
        public SddMandate SddMandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionIdPatchRequest {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Capture: ").Append(Capture).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  MaxCaptures: ").Append(MaxCaptures).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Failover: ").Append(Failover).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  SddMandate: ").Append(SddMandate).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Key, length must be less than 50.", new[] { "Key" });
            }

            // Value (double) minimum
            if (this.Value < (double)0.5)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.5.", new[] { "Value" });
            }

            yield break;
        }
    }

}