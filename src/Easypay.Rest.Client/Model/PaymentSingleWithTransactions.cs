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
    /// PaymentSingleWithTransactions
    /// </summary>
    [DataContract(Name = "Payment_SingleWithTransactions")]
    public partial class PaymentSingleWithTransactions : IEquatable<PaymentSingleWithTransactions>, IValidatableObject
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
        /// Optional - only applicable to method cc or mbw
        /// </summary>
        /// <value>Optional - only applicable to method cc or mbw</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sale for value: sale
            /// </summary>
            [EnumMember(Value = "sale")]
            Sale = 1,

            /// <summary>
            /// Enum Authorisation for value: authorisation
            /// </summary>
            [EnumMember(Value = "authorisation")]
            Authorisation = 2

        }

        /// <summary>
        /// Optional - only applicable to method cc or mbw
        /// </summary>
        /// <value>Optional - only applicable to method cc or mbw</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSingleWithTransactions" /> class.
        /// </summary>
        /// <param name="transactions">transactions.</param>
        /// <param name="id">id.</param>
        /// <param name="expirationTime">Optional.</param>
        /// <param name="currency">currency (default to CurrencyEnum.EUR).</param>
        /// <param name="customer">customer.</param>
        /// <param name="key">Merchant identification key.</param>
        /// <param name="value">Value will be rounded to 2 decimals.</param>
        /// <param name="type">Optional - only applicable to method cc or mbw (default to TypeEnum.Sale).</param>
        /// <param name="method">method.</param>
        /// <param name="paymentStatus">Status of the single payment.</param>
        /// <param name="paidAt">Date when the single payment was paid.</param>
        /// <param name="createdAt">Date when payment was created.</param>
        public PaymentSingleWithTransactions(List<PaymentSingleTransaction> transactions = default(List<PaymentSingleTransaction>), Guid id = default(Guid), string expirationTime = default(string), CurrencyEnum? currency = CurrencyEnum.EUR, Customer customer = default(Customer), string key = default(string), double value = default(double), TypeEnum? type = TypeEnum.Sale, PaymentSingleMethodResponseMethod method = default(PaymentSingleMethodResponseMethod), string paymentStatus = default(string), string paidAt = default(string), string createdAt = default(string))
        {
            this.Transactions = transactions;
            this.Id = id;
            this.ExpirationTime = expirationTime;
            this.Currency = currency;
            this.Customer = customer;
            this.Key = key;
            this.Value = value;
            this.Type = type;
            this.Method = method;
            this.PaymentStatus = paymentStatus;
            this.PaidAt = paidAt;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<PaymentSingleTransaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

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
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public PaymentSingleMethodResponseMethod Method { get; set; }

        /// <summary>
        /// Status of the single payment
        /// </summary>
        /// <value>Status of the single payment</value>
        [DataMember(Name = "payment_status", EmitDefaultValue = false)]
        public string PaymentStatus { get; set; }

        /// <summary>
        /// Date when the single payment was paid
        /// </summary>
        /// <value>Date when the single payment was paid</value>
        [DataMember(Name = "paid_at", EmitDefaultValue = false)]
        public string PaidAt { get; set; }

        /// <summary>
        /// Date when payment was created
        /// </summary>
        /// <value>Date when payment was created</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSingleWithTransactions {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  PaymentStatus: ").Append(PaymentStatus).Append("\n");
            sb.Append("  PaidAt: ").Append(PaidAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as PaymentSingleWithTransactions);
        }

        /// <summary>
        /// Returns true if PaymentSingleWithTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSingleWithTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSingleWithTransactions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.PaymentStatus == input.PaymentStatus ||
                    (this.PaymentStatus != null &&
                    this.PaymentStatus.Equals(input.PaymentStatus))
                ) && 
                (
                    this.PaidAt == input.PaidAt ||
                    (this.PaidAt != null &&
                    this.PaidAt.Equals(input.PaidAt))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ExpirationTime != null)
                    hashCode = hashCode * 59 + this.ExpirationTime.GetHashCode();
                hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.PaymentStatus != null)
                    hashCode = hashCode * 59 + this.PaymentStatus.GetHashCode();
                if (this.PaidAt != null)
                    hashCode = hashCode * 59 + this.PaidAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
