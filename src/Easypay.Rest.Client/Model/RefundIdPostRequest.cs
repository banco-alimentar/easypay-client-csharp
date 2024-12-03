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
    /// RefundIdPostRequest
    /// </summary>
    [DataContract(Name = "_refund__id__post_request")]
    public partial class RefundIdPostRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundIdPostRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RefundIdPostRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundIdPostRequest" /> class.
        /// </summary>
        /// <param name="transactionKey">Your internal key identifying this refund.</param>
        /// <param name="iban">Optional - Iban from the bank account.</param>
        /// <param name="email">Optional - Email from the bank account holder.</param>
        /// <param name="phone">Optional - Phone from the bank account holder.</param>
        /// <param name="accountHolder">Optional - Bank account holder name.</param>
        /// <param name="value">Value will be rounded to 2 decimals (required).</param>
        /// <param name="revert">revert.</param>
        public RefundIdPostRequest(string transactionKey = default(string), string iban = default(string), string email = default(string), string phone = default(string), string accountHolder = default(string), double value = default(double), RefundIdPostRequestRevert revert = default(RefundIdPostRequestRevert))
        {
            this.Value = value;
            this.TransactionKey = transactionKey;
            this.Iban = iban;
            this.Email = email;
            this.Phone = phone;
            this.AccountHolder = accountHolder;
            this.Revert = revert;
        }

        /// <summary>
        /// Your internal key identifying this refund
        /// </summary>
        /// <value>Your internal key identifying this refund</value>
        [DataMember(Name = "transaction_key", EmitDefaultValue = false)]
        public string TransactionKey { get; set; }

        /// <summary>
        /// Optional - Iban from the bank account
        /// </summary>
        /// <value>Optional - Iban from the bank account</value>
        /*
        <example>PT50002700000001234567833</example>
        */
        [DataMember(Name = "iban", EmitDefaultValue = false)]
        public string Iban { get; set; }

        /// <summary>
        /// Optional - Email from the bank account holder
        /// </summary>
        /// <value>Optional - Email from the bank account holder</value>
        /*
        <example>customer@example.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Optional - Phone from the bank account holder
        /// </summary>
        /// <value>Optional - Phone from the bank account holder</value>
        /*
        <example>911234567</example>
        */
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Optional - Bank account holder name
        /// </summary>
        /// <value>Optional - Bank account holder name</value>
        /*
        <example>Account Name Example</example>
        */
        [DataMember(Name = "account_holder", EmitDefaultValue = false)]
        public string AccountHolder { get; set; }

        /// <summary>
        /// Value will be rounded to 2 decimals
        /// </summary>
        /// <value>Value will be rounded to 2 decimals</value>
        /*
        <example>17.5</example>
        */
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets Revert
        /// </summary>
        [DataMember(Name = "revert", EmitDefaultValue = false)]
        public RefundIdPostRequestRevert Revert { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundIdPostRequest {\n");
            sb.Append("  TransactionKey: ").Append(TransactionKey).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Revert: ").Append(Revert).Append("\n");
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
            // TransactionKey (string) maxLength
            if (this.TransactionKey != null && this.TransactionKey.Length > 50)
            {
                yield return new ValidationResult("Invalid value for TransactionKey, length must be less than 50.", new[] { "TransactionKey" });
            }

            // Iban (string) maxLength
            if (this.Iban != null && this.Iban.Length > 34)
            {
                yield return new ValidationResult("Invalid value for Iban, length must be less than 34.", new[] { "Iban" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Email, length must be less than 50.", new[] { "Email" });
            }

            // Phone (string) maxLength
            if (this.Phone != null && this.Phone.Length > 20)
            {
                yield return new ValidationResult("Invalid value for Phone, length must be less than 20.", new[] { "Phone" });
            }

            // AccountHolder (string) maxLength
            if (this.AccountHolder != null && this.AccountHolder.Length > 100)
            {
                yield return new ValidationResult("Invalid value for AccountHolder, length must be less than 100.", new[] { "AccountHolder" });
            }

            // Value (double) minimum
            if (this.Value < (double)0)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.", new[] { "Value" });
            }

            yield break;
        }
    }

}
