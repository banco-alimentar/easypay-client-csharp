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
    /// PaymentBase
    /// </summary>
    [DataContract(Name = "Payment_Base")]
    public partial class PaymentBase : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentBase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentBase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentBase" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="descriptive">This will appear in the bank statement/mbway application.</param>
        /// <param name="value">Value will be rounded to 2 decimals (required).</param>
        /// <param name="expirationTime">Optional.</param>
        /// <param name="currency">currency.</param>
        /// <param name="customer">customer.</param>
        /// <param name="key">Merchant identification key.</param>
        public PaymentBase(Guid id = default(Guid), string descriptive = default(string), double value = default(double), string expirationTime = default(string), Currency? currency = default(Currency?), Customer customer = default(Customer), string key = default(string))
        {
            this.Value = value;
            this.Id = id;
            this.Descriptive = descriptive;
            this.ExpirationTime = expirationTime;
            this.Currency = currency;
            this.Customer = customer;
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>4c67e74b-a256-4e0a-965d-97bf5d01bd50</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// This will appear in the bank statement/mbway application
        /// </summary>
        /// <value>This will appear in the bank statement/mbway application</value>
        /*
        <example>Descriptive Example</example>
        */
        [DataMember(Name = "descriptive", EmitDefaultValue = false)]
        public string Descriptive { get; set; }

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
        /// Optional
        /// </summary>
        /// <value>Optional</value>
        /*
        <example>2017-12-12 16:05</example>
        */
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
        /*
        <example>Example Key</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentBase {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Descriptive: ").Append(Descriptive).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            // Descriptive (string) maxLength
            if (this.Descriptive != null && this.Descriptive.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Descriptive, length must be less than 255.", new[] { "Descriptive" });
            }

            // Value (double) minimum
            if (this.Value < (double)0.5)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.5.", new[] { "Value" });
            }

            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Key, length must be less than 50.", new[] { "Key" });
            }

            yield break;
        }
    }

}
