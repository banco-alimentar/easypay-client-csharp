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
    /// FrequentPostRequest
    /// </summary>
    [DataContract(Name = "_frequent_post_request")]
    public partial class FrequentPostRequest : IValidatableObject
    {
        /// <summary>
        /// Defines Currency
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum EUR for value: EUR
            /// </summary>
            [EnumMember(Value = "EUR")]
            EUR = 1,

            /// <summary>
            /// Enum BRL for value: BRL
            /// </summary>
            [EnumMember(Value = "BRL")]
            BRL = 2
        }


        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Defines Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum Mb for value: mb
            /// </summary>
            [EnumMember(Value = "mb")]
            Mb = 1,

            /// <summary>
            /// Enum Cc for value: cc
            /// </summary>
            [EnumMember(Value = "cc")]
            Cc = 2,

            /// <summary>
            /// Enum Dd for value: dd
            /// </summary>
            [EnumMember(Value = "dd")]
            Dd = 3,

            /// <summary>
            /// Enum Mbw for value: mbw
            /// </summary>
            [EnumMember(Value = "mbw")]
            Mbw = 4,

            /// <summary>
            /// Enum Vi for value: vi
            /// </summary>
            [EnumMember(Value = "vi")]
            Vi = 5
        }


        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = true)]
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequentPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FrequentPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequentPostRequest" /> class.
        /// </summary>
        /// <param name="expirationTime">expirationTime.</param>
        /// <param name="currency">currency (default to CurrencyEnum.EUR).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="key">The merchant&#39;s key for identifying the payment..</param>
        /// <param name="minValue">minValue (required).</param>
        /// <param name="maxValue">maxValue (required).</param>
        /// <param name="unlimitedPayments">Transactions will be unlimited, max or min value will be refreshed on each payment. (default to true).</param>
        /// <param name="method">method (required).</param>
        /// <param name="sddMandate">sddMandate.</param>
        /// <param name="multibanco">multibanco.</param>
        public FrequentPostRequest(string expirationTime = default(string), CurrencyEnum? currency = CurrencyEnum.EUR, Customer customer = default(Customer), string key = default(string), double minValue = default(double), double maxValue = default(double), bool unlimitedPayments = true, MethodEnum method = default(MethodEnum), SddMandate sddMandate = default(SddMandate), FrequentPostRequestMultibanco multibanco = default(FrequentPostRequestMultibanco))
        {
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new ArgumentNullException("customer is a required property for FrequentPostRequest and cannot be null");
            }
            this.Customer = customer;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
            this.Method = method;
            this.ExpirationTime = expirationTime;
            this.Currency = currency;
            this.Key = key;
            this.UnlimitedPayments = unlimitedPayments;
            this.SddMandate = sddMandate;
            this.Multibanco = multibanco;
        }

        /// <summary>
        /// Gets or Sets ExpirationTime
        /// </summary>
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", IsRequired = true, EmitDefaultValue = true)]
        public Customer Customer { get; set; }

        /// <summary>
        /// The merchant&#39;s key for identifying the payment.
        /// </summary>
        /// <value>The merchant&#39;s key for identifying the payment.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets MinValue
        /// </summary>
        [DataMember(Name = "min_value", IsRequired = true, EmitDefaultValue = true)]
        public double MinValue { get; set; }

        /// <summary>
        /// Gets or Sets MaxValue
        /// </summary>
        [DataMember(Name = "max_value", IsRequired = true, EmitDefaultValue = true)]
        public double MaxValue { get; set; }

        /// <summary>
        /// Transactions will be unlimited, max or min value will be refreshed on each payment.
        /// </summary>
        /// <value>Transactions will be unlimited, max or min value will be refreshed on each payment.</value>
        [DataMember(Name = "unlimited_payments", EmitDefaultValue = true)]
        public bool UnlimitedPayments { get; set; }

        /// <summary>
        /// Gets or Sets SddMandate
        /// </summary>
        [DataMember(Name = "sdd_mandate", EmitDefaultValue = false)]
        public SddMandate SddMandate { get; set; }

        /// <summary>
        /// Gets or Sets Multibanco
        /// </summary>
        [DataMember(Name = "multibanco", EmitDefaultValue = false)]
        public FrequentPostRequestMultibanco Multibanco { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FrequentPostRequest {\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  MinValue: ").Append(MinValue).Append("\n");
            sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
            sb.Append("  UnlimitedPayments: ").Append(UnlimitedPayments).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  SddMandate: ").Append(SddMandate).Append("\n");
            sb.Append("  Multibanco: ").Append(Multibanco).Append("\n");
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

            // MinValue (double) minimum
            if (this.MinValue < (double)0.01)
            {
                yield return new ValidationResult("Invalid value for MinValue, must be a value greater than or equal to 0.01.", new[] { "MinValue" });
            }

            // MaxValue (double) minimum
            if (this.MaxValue < (double)0.01)
            {
                yield return new ValidationResult("Invalid value for MaxValue, must be a value greater than or equal to 0.01.", new[] { "MaxValue" });
            }

            yield break;
        }
    }

}