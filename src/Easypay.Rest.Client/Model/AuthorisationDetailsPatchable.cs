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
    /// AuthorisationDetailsPatchable
    /// </summary>
    [DataContract(Name = "Authorisation_Details_Patchable")]
    public partial class AuthorisationDetailsPatchable : IEquatable<AuthorisationDetailsPatchable>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
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
        /// Initializes a new instance of the <see cref="AuthorisationDetailsPatchable" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="currency">currency (default to CurrencyEnum.EUR).</param>
        /// <param name="customer">customer.</param>
        /// <param name="key">Merchant identification key.</param>
        /// <param name="value">value.</param>
        /// <param name="valueCaptured">valueCaptured.</param>
        /// <param name="method">method.</param>
        /// <param name="account">account.</param>
        public AuthorisationDetailsPatchable(StatusEnum? status = default(StatusEnum?), string message = default(string), CurrencyEnum? currency = CurrencyEnum.EUR, Customer customer = default(Customer), string key = default(string), double value = default(double), double valueCaptured = default(double), AuthorisationDetailsMethodResponseMethod method = default(AuthorisationDetailsMethodResponseMethod), PropertiesHasID account = default(PropertiesHasID))
        {
            this.Status = status;
            this.Message = message;
            this.Currency = currency;
            this.Customer = customer;
            this.Key = key;
            this.Value = value;
            this.ValueCaptured = valueCaptured;
            this.Method = method;
            this.Account = account;
        }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

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
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueCaptured
        /// </summary>
        [DataMember(Name = "value_captured", EmitDefaultValue = false)]
        public double ValueCaptured { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public AuthorisationDetailsMethodResponseMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public PropertiesHasID Account { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuthorisationDetailsPatchable {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueCaptured: ").Append(ValueCaptured).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
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
            return this.Equals(input as AuthorisationDetailsPatchable);
        }

        /// <summary>
        /// Returns true if AuthorisationDetailsPatchable instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorisationDetailsPatchable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorisationDetailsPatchable input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                    this.ValueCaptured == input.ValueCaptured ||
                    this.ValueCaptured.Equals(input.ValueCaptured)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.ValueCaptured.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
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

            yield break;
        }
    }

}
