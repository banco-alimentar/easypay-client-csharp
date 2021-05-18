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
    /// ConfigDetails
    /// </summary>
    [DataContract(Name = "Config_Details")]
    public partial class ConfigDetails : IEquatable<ConfigDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigDetails" /> class.
        /// </summary>
        /// <param name="generic">URL for generic notification (default to &quot;https://www.easypay.pt/generic&quot;).</param>
        /// <param name="authorisation">URL for authorisation notification (default to &quot;https://www.easypay.pt/authorisation&quot;).</param>
        /// <param name="transaction">URL for transaction notification (default to &quot;https://www.easypay.pt/transaction&quot;).</param>
        /// <param name="visaFwd">URL for redirect clients on credit card forward (default to &quot;https://www.easypay.pt/visa_fwd&quot;).</param>
        /// <param name="visaDetail">URL for credit card payment detail (default to &quot;https://www.easypay.pt/visa_detail&quot;).</param>
        /// <param name="account">easypay account UUID (default to &quot;b2080452-bad1-4455-8ae7-9f5ea552a274&quot;).</param>
        /// <param name="paymentMethods">payment methods allowed.</param>
        public ConfigDetails(string generic = "https://www.easypay.pt/generic", string authorisation = "https://www.easypay.pt/authorisation", string transaction = "https://www.easypay.pt/transaction", string visaFwd = "https://www.easypay.pt/visa_fwd", string visaDetail = "https://www.easypay.pt/visa_detail", string account = "b2080452-bad1-4455-8ae7-9f5ea552a274", List<string> paymentMethods = default(List<string>))
        {
            // use default value if no "generic" provided
            this.Generic = generic ?? "https://www.easypay.pt/generic";
            // use default value if no "authorisation" provided
            this.Authorisation = authorisation ?? "https://www.easypay.pt/authorisation";
            // use default value if no "transaction" provided
            this.Transaction = transaction ?? "https://www.easypay.pt/transaction";
            // use default value if no "visaFwd" provided
            this.VisaFwd = visaFwd ?? "https://www.easypay.pt/visa_fwd";
            // use default value if no "visaDetail" provided
            this.VisaDetail = visaDetail ?? "https://www.easypay.pt/visa_detail";
            // use default value if no "account" provided
            this.Account = account ?? "b2080452-bad1-4455-8ae7-9f5ea552a274";
            this.PaymentMethods = paymentMethods;
        }

        /// <summary>
        /// URL for generic notification
        /// </summary>
        /// <value>URL for generic notification</value>
        [DataMember(Name = "generic", EmitDefaultValue = false)]
        public string Generic { get; set; }

        /// <summary>
        /// URL for authorisation notification
        /// </summary>
        /// <value>URL for authorisation notification</value>
        [DataMember(Name = "authorisation", EmitDefaultValue = false)]
        public string Authorisation { get; set; }

        /// <summary>
        /// URL for transaction notification
        /// </summary>
        /// <value>URL for transaction notification</value>
        [DataMember(Name = "transaction", EmitDefaultValue = false)]
        public string Transaction { get; set; }

        /// <summary>
        /// URL for redirect clients on credit card forward
        /// </summary>
        /// <value>URL for redirect clients on credit card forward</value>
        [DataMember(Name = "visa_fwd", EmitDefaultValue = false)]
        public string VisaFwd { get; set; }

        /// <summary>
        /// URL for credit card payment detail
        /// </summary>
        /// <value>URL for credit card payment detail</value>
        [DataMember(Name = "visa_detail", EmitDefaultValue = false)]
        public string VisaDetail { get; set; }

        /// <summary>
        /// easypay account UUID
        /// </summary>
        /// <value>easypay account UUID</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// payment methods allowed
        /// </summary>
        /// <value>payment methods allowed</value>
        [DataMember(Name = "payment_methods", EmitDefaultValue = false)]
        public List<string> PaymentMethods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigDetails {\n");
            sb.Append("  Generic: ").Append(Generic).Append("\n");
            sb.Append("  Authorisation: ").Append(Authorisation).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  VisaFwd: ").Append(VisaFwd).Append("\n");
            sb.Append("  VisaDetail: ").Append(VisaDetail).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  PaymentMethods: ").Append(PaymentMethods).Append("\n");
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
            return this.Equals(input as ConfigDetails);
        }

        /// <summary>
        /// Returns true if ConfigDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ConfigDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Generic == input.Generic ||
                    (this.Generic != null &&
                    this.Generic.Equals(input.Generic))
                ) && 
                (
                    this.Authorisation == input.Authorisation ||
                    (this.Authorisation != null &&
                    this.Authorisation.Equals(input.Authorisation))
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.VisaFwd == input.VisaFwd ||
                    (this.VisaFwd != null &&
                    this.VisaFwd.Equals(input.VisaFwd))
                ) && 
                (
                    this.VisaDetail == input.VisaDetail ||
                    (this.VisaDetail != null &&
                    this.VisaDetail.Equals(input.VisaDetail))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.PaymentMethods == input.PaymentMethods ||
                    this.PaymentMethods != null &&
                    input.PaymentMethods != null &&
                    this.PaymentMethods.SequenceEqual(input.PaymentMethods)
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
                if (this.Generic != null)
                    hashCode = hashCode * 59 + this.Generic.GetHashCode();
                if (this.Authorisation != null)
                    hashCode = hashCode * 59 + this.Authorisation.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.VisaFwd != null)
                    hashCode = hashCode * 59 + this.VisaFwd.GetHashCode();
                if (this.VisaDetail != null)
                    hashCode = hashCode * 59 + this.VisaDetail.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.PaymentMethods != null)
                    hashCode = hashCode * 59 + this.PaymentMethods.GetHashCode();
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
            yield break;
        }
    }

}
