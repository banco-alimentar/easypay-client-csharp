/*
 * Easypay API
 *
 * EasyPay - API allows you to query payment meta-data, receive payment notifications and generate payment references. Two distinct environments - [Sandbox environment](https://api.test.easypay.pt/docs) and [Production environment](https://api.prod.easypay.pt/docs).
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
using OpenAPIDateConverter = BancoAlimentar.AlimentaEstaIdeia.easypay.Client.OpenAPIDateConverter;

namespace BancoAlimentar.AlimentaEstaIdeia.easypay.Model
{
    /// <summary>
    /// Customer
    /// </summary>
    [DataContract(Name = "Customer")]
    public partial class Customer : IEquatable<Customer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer" /> class.
        /// </summary>
        /// <param name="id">Optional - uuid from previous created customers.</param>
        /// <param name="name">Required if &#39;method&#39; is &#39;mbw&#39;.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">Required if &#39;method&#39; is &#39;mbw&#39;.</param>
        /// <param name="phoneIndicative">phoneIndicative (default to &quot;+351&quot;).</param>
        /// <param name="fiscalNumber">Fiscal Number must be prefixed with country code.</param>
        /// <param name="key">key.</param>
        /// <param name="language">ISO Alpha-2 code (default to &quot;PT&quot;).</param>
        public Customer(Guid id = default(Guid), string name = default(string), string email = default(string), string phone = default(string), string phoneIndicative = "+351", string fiscalNumber = default(string), string key = default(string), string language = "PT")
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            // use default value if no "phoneIndicative" provided
            this.PhoneIndicative = phoneIndicative ?? "+351";
            this.FiscalNumber = fiscalNumber;
            this.Key = key;
            // use default value if no "language" provided
            this.Language = language ?? "PT";
        }

        /// <summary>
        /// Optional - uuid from previous created customers
        /// </summary>
        /// <value>Optional - uuid from previous created customers</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Required if &#39;method&#39; is &#39;mbw&#39;
        /// </summary>
        /// <value>Required if &#39;method&#39; is &#39;mbw&#39;</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Required if &#39;method&#39; is &#39;mbw&#39;
        /// </summary>
        /// <value>Required if &#39;method&#39; is &#39;mbw&#39;</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PhoneIndicative
        /// </summary>
        [DataMember(Name = "phone_indicative", EmitDefaultValue = false)]
        public string PhoneIndicative { get; set; }

        /// <summary>
        /// Fiscal Number must be prefixed with country code
        /// </summary>
        /// <value>Fiscal Number must be prefixed with country code</value>
        [DataMember(Name = "fiscal_number", EmitDefaultValue = false)]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// ISO Alpha-2 code
        /// </summary>
        /// <value>ISO Alpha-2 code</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Customer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhoneIndicative: ").Append(PhoneIndicative).Append("\n");
            sb.Append("  FiscalNumber: ").Append(FiscalNumber).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
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
            return this.Equals(input as Customer);
        }

        /// <summary>
        /// Returns true if Customer instances are equal
        /// </summary>
        /// <param name="input">Instance of Customer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Customer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhoneIndicative == input.PhoneIndicative ||
                    (this.PhoneIndicative != null &&
                    this.PhoneIndicative.Equals(input.PhoneIndicative))
                ) && 
                (
                    this.FiscalNumber == input.FiscalNumber ||
                    (this.FiscalNumber != null &&
                    this.FiscalNumber.Equals(input.FiscalNumber))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.PhoneIndicative != null)
                    hashCode = hashCode * 59 + this.PhoneIndicative.GetHashCode();
                if (this.FiscalNumber != null)
                    hashCode = hashCode * 59 + this.FiscalNumber.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // Email (string) maxLength
            if(this.Email != null && this.Email.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 70.", new [] { "Email" });
            }

            // Phone (string) maxLength
            if(this.Phone != null && this.Phone.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be less than 15.", new [] { "Phone" });
            }

            // PhoneIndicative (string) maxLength
            if(this.PhoneIndicative != null && this.PhoneIndicative.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PhoneIndicative, length must be less than 5.", new [] { "PhoneIndicative" });
            }

            // FiscalNumber (string) maxLength
            if(this.FiscalNumber != null && this.FiscalNumber.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FiscalNumber, length must be less than 20.", new [] { "FiscalNumber" });
            }

            // Key (string) maxLength
            if(this.Key != null && this.Key.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, length must be less than 255.", new [] { "Key" });
            }

            yield break;
        }
    }

}
