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
    /// Only required if &#39;type&#39; is &#39;sale&#39;
    /// </summary>
    [DataContract(Name = "Payment_Capture_capture")]
    public partial class PaymentCaptureCapture : IEquatable<PaymentCaptureCapture>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCaptureCapture" /> class.
        /// </summary>
        /// <param name="transactionKey">Your internal key identifying this capture.</param>
        /// <param name="captureDate">captureDate.</param>
        /// <param name="account">account.</param>
        /// <param name="splits">Optional: only used for split payments.</param>
        public PaymentCaptureCapture(string transactionKey = default(string), string captureDate = default(string), PaymentCaptureCaptureAccount account = default(PaymentCaptureCaptureAccount), List<SplitsDetails> splits = default(List<SplitsDetails>))
        {
            this.TransactionKey = transactionKey;
            this.CaptureDate = captureDate;
            this.Account = account;
            this.Splits = splits;
        }

        /// <summary>
        /// Your internal key identifying this capture
        /// </summary>
        /// <value>Your internal key identifying this capture</value>
        [DataMember(Name = "transaction_key", EmitDefaultValue = false)]
        public string TransactionKey { get; set; }

        /// <summary>
        /// Gets or Sets CaptureDate
        /// </summary>
        [DataMember(Name = "capture_date", EmitDefaultValue = false)]
        public string CaptureDate { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public PaymentCaptureCaptureAccount Account { get; set; }

        /// <summary>
        /// Optional: only used for split payments
        /// </summary>
        /// <value>Optional: only used for split payments</value>
        [DataMember(Name = "splits", EmitDefaultValue = false)]
        public List<SplitsDetails> Splits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCaptureCapture {\n");
            sb.Append("  TransactionKey: ").Append(TransactionKey).Append("\n");
            sb.Append("  CaptureDate: ").Append(CaptureDate).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Splits: ").Append(Splits).Append("\n");
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
            return this.Equals(input as PaymentCaptureCapture);
        }

        /// <summary>
        /// Returns true if PaymentCaptureCapture instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCaptureCapture to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCaptureCapture input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionKey == input.TransactionKey ||
                    (this.TransactionKey != null &&
                    this.TransactionKey.Equals(input.TransactionKey))
                ) && 
                (
                    this.CaptureDate == input.CaptureDate ||
                    (this.CaptureDate != null &&
                    this.CaptureDate.Equals(input.CaptureDate))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Splits == input.Splits ||
                    this.Splits != null &&
                    input.Splits != null &&
                    this.Splits.SequenceEqual(input.Splits)
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
                if (this.TransactionKey != null)
                    hashCode = hashCode * 59 + this.TransactionKey.GetHashCode();
                if (this.CaptureDate != null)
                    hashCode = hashCode * 59 + this.CaptureDate.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Splits != null)
                    hashCode = hashCode * 59 + this.Splits.GetHashCode();
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
            // TransactionKey (string) maxLength
            if(this.TransactionKey != null && this.TransactionKey.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionKey, length must be less than 50.", new [] { "TransactionKey" });
            }

            yield break;
        }
    }

}
