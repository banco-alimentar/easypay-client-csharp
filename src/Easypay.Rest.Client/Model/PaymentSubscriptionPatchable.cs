/*
 * Easypay API
 *
 * <a href='https://www.easypay.pt/en/terms-conditions-and-legal-terms' class='item'>Terms conditions and legal terms</a><br><a href='https://www.easypay.pt/en/privacy-policy' class='item'>Privacy Policy</a><br><br><b>EasyPay</b> API allows you to query payment meta-data, receive payment notifications and generate payment references. Since EasyPay API is based on REST principles, it´s very easy to write and test applications. You can use our code examples in PHP/CURL to test all the JSON payloads for Easypay Payment Service API.<br><br> We have two distinct environments on our API Services:<br> - If you are looking to receive payments, please use the <a href='https://api.prod.easypay.pt/docs#' class='item'><b>Production Documentation</b></a>.<br> - If you are looking to test or integrate, please use the <a href='https://goo.gl/CPxQnM' class='item'><b>Sandbox Documentation</b></a>. This environment will always have the latest road map deployments, usually all deployments are sent to production within 10 days. This environment is not meant for <b>Load Tests</b>, please do not use for this purpose, you might be blocked. <br><br> All communications have to include two headers for authentication, if fails it will always respond 403.<br> On <a href='https://backoffice.easypay.pt' class='item'><b>Easypay Backoffice</b></a> please create your authentication AccountId and ApiKey on menu: <i><b>Web Services->Configuration API 2.0->Keys</b></i>.<br><br> Our default response produces a <i><b>application/json</b></i>, but the <b>Accept</b> request-header field can be used to specify certain media types which are acceptable for the response. <br>Our available options are: <i>application/json</i>, <i>application/xml</i>, <i>text/csv</i>
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
    /// PaymentSubscriptionPatchable
    /// </summary>
    [DataContract(Name = "Payment_Subscription_Patchable")]
    public partial class PaymentSubscriptionPatchable : IEquatable<PaymentSubscriptionPatchable>, IValidatableObject
    {
        /// <summary>
        /// Only available to change between active and inactive
        /// </summary>
        /// <value>Only available to change between active and inactive</value>
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
        /// Only available to change between active and inactive
        /// </summary>
        /// <value>Only available to change between active and inactive</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
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
        /// Initializes a new instance of the <see cref="PaymentSubscriptionPatchable" /> class.
        /// </summary>
        /// <param name="status">Only available to change between active and inactive.</param>
        /// <param name="expirationTime">Optional.</param>
        /// <param name="currency">currency (default to CurrencyEnum.EUR).</param>
        /// <param name="customer">customer.</param>
        /// <param name="key">Merchant identification key.</param>
        /// <param name="value">Value will be rounded to 2 decimals.</param>
        /// <param name="maxCaptures">Required only when no expiration_time is set.</param>
        /// <param name="failover">After all retries failed, the payment cycle can have another try with another Single Method (default to false).</param>
        /// <param name="retries">Number of retries on every payment cycle, the chosen frequency will define the max number of possible retries.</param>
        /// <param name="method">method.</param>
        /// <param name="sddMandate">sddMandate.</param>
        public PaymentSubscriptionPatchable(StatusEnum? status = default(StatusEnum?), string expirationTime = default(string), CurrencyEnum? currency = CurrencyEnum.EUR, Customer customer = default(Customer), string key = default(string), double value = default(double), decimal maxCaptures = default(decimal), bool failover = false, decimal retries = default(decimal), PaymentSubscriptionMethodAvailable method = default(PaymentSubscriptionMethodAvailable), SddMandate sddMandate = default(SddMandate))
        {
            this.Status = status;
            this.ExpirationTime = expirationTime;
            this.Currency = currency;
            this.Customer = customer;
            this.Key = key;
            this.Value = value;
            this.MaxCaptures = maxCaptures;
            this.Failover = failover;
            this.Retries = retries;
            this.Method = method;
            this.SddMandate = sddMandate;
        }

        /// <summary>
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
        public string ExpirationTime { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public Customer Customer { get; set; }

        /// <summary>
        /// Merchant identification key
        /// </summary>
        /// <value>Merchant identification key</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Value will be rounded to 2 decimals
        /// </summary>
        /// <value>Value will be rounded to 2 decimals</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Required only when no expiration_time is set
        /// </summary>
        /// <value>Required only when no expiration_time is set</value>
        [DataMember(Name = "max_captures", EmitDefaultValue = false)]
        public decimal MaxCaptures { get; set; }

        /// <summary>
        /// After all retries failed, the payment cycle can have another try with another Single Method
        /// </summary>
        /// <value>After all retries failed, the payment cycle can have another try with another Single Method</value>
        [DataMember(Name = "failover", EmitDefaultValue = false)]
        public bool Failover { get; set; }

        /// <summary>
        /// Number of retries on every payment cycle, the chosen frequency will define the max number of possible retries
        /// </summary>
        /// <value>Number of retries on every payment cycle, the chosen frequency will define the max number of possible retries</value>
        [DataMember(Name = "retries", EmitDefaultValue = false)]
        public decimal Retries { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public PaymentSubscriptionMethodAvailable Method { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class PaymentSubscriptionPatchable {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  MaxCaptures: ").Append(MaxCaptures).Append("\n");
            sb.Append("  Failover: ").Append(Failover).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentSubscriptionPatchable);
        }

        /// <summary>
        /// Returns true if PaymentSubscriptionPatchable instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSubscriptionPatchable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSubscriptionPatchable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.ExpirationTime == input.ExpirationTime ||
                    (this.ExpirationTime != null &&
                    this.ExpirationTime.Equals(input.ExpirationTime))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.MaxCaptures == input.MaxCaptures ||
                    this.MaxCaptures.Equals(input.MaxCaptures)
                ) && 
                (
                    this.Failover == input.Failover ||
                    this.Failover.Equals(input.Failover)
                ) && 
                (
                    this.Retries == input.Retries ||
                    this.Retries.Equals(input.Retries)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.SddMandate == input.SddMandate ||
                    (this.SddMandate != null &&
                    this.SddMandate.Equals(input.SddMandate))
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
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.MaxCaptures.GetHashCode();
                hashCode = hashCode * 59 + this.Failover.GetHashCode();
                hashCode = hashCode * 59 + this.Retries.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.SddMandate != null)
                    hashCode = hashCode * 59 + this.SddMandate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Key (string) maxLength
            if(this.Key != null && this.Key.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 50.", new [] { "Key" });
            }

            // Value (double) minimum
            if(this.Value < (double)0.5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.5.", new [] { "Value" });
            }

            yield break;
        }
    }

}
