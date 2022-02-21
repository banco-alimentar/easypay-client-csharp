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
    /// PaymentOutPaymentWithTransactions
    /// </summary>
    [DataContract(Name = "Payment_OutPaymentWithTransactions")]
    public partial class PaymentOutPaymentWithTransactions : IEquatable<PaymentOutPaymentWithTransactions>, IValidatableObject
    {
        /// <summary>
        /// Optional - only applicable to method transfer
        /// </summary>
        /// <value>Optional - only applicable to method transfer</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Normal for value: normal
            /// </summary>
            [EnumMember(Value = "normal")]
            Normal = 1,

            /// <summary>
            /// Enum Instant for value: instant
            /// </summary>
            [EnumMember(Value = "instant")]
            Instant = 2

        }

        /// <summary>
        /// Optional - only applicable to method transfer
        /// </summary>
        /// <value>Optional - only applicable to method transfer</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentOutPaymentWithTransactions" /> class.
        /// </summary>
        /// <param name="transactions">transactions.</param>
        /// <param name="id">id.</param>
        /// <param name="customer">customer.</param>
        /// <param name="key">Merchant identification key.</param>
        /// <param name="value">Value will be rounded to 2 decimals.</param>
        /// <param name="type">Optional - only applicable to method transfer (default to TypeEnum.Normal).</param>
        /// <param name="scheduleAt">Schedule date to execute the payment.</param>
        /// <param name="account">account.</param>
        /// <param name="outAccount">outAccount.</param>
        public PaymentOutPaymentWithTransactions(List<PaymentOutPaymentTransaction> transactions = default(List<PaymentOutPaymentTransaction>), Guid id = default(Guid), Customer customer = default(Customer), string key = default(string), double value = default(double), TypeEnum? type = TypeEnum.Normal, string scheduleAt = default(string), PropertiesHasID account = default(PropertiesHasID), PropertiesHasID outAccount = default(PropertiesHasID))
        {
            this.Transactions = transactions;
            this.Id = id;
            this.Customer = customer;
            this.Key = key;
            this.Value = value;
            this.Type = type;
            this.ScheduleAt = scheduleAt;
            this.Account = account;
            this.OutAccount = outAccount;
        }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public List<PaymentOutPaymentTransaction> Transactions { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

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
        /// Schedule date to execute the payment
        /// </summary>
        /// <value>Schedule date to execute the payment</value>
        [DataMember(Name = "schedule_at", EmitDefaultValue = false)]
        public string ScheduleAt { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public PropertiesHasID Account { get; set; }

        /// <summary>
        /// Gets or Sets OutAccount
        /// </summary>
        [DataMember(Name = "out_account", EmitDefaultValue = false)]
        public PropertiesHasID OutAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentOutPaymentWithTransactions {\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  ScheduleAt: ").Append(ScheduleAt).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  OutAccount: ").Append(OutAccount).Append("\n");
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
            return this.Equals(input as PaymentOutPaymentWithTransactions);
        }

        /// <summary>
        /// Returns true if PaymentOutPaymentWithTransactions instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentOutPaymentWithTransactions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentOutPaymentWithTransactions input)
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
                    this.ScheduleAt == input.ScheduleAt ||
                    (this.ScheduleAt != null &&
                    this.ScheduleAt.Equals(input.ScheduleAt))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.OutAccount == input.OutAccount ||
                    (this.OutAccount != null &&
                    this.OutAccount.Equals(input.OutAccount))
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
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.ScheduleAt != null)
                    hashCode = hashCode * 59 + this.ScheduleAt.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.OutAccount != null)
                    hashCode = hashCode * 59 + this.OutAccount.GetHashCode();
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