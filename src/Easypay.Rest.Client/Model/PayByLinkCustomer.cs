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
    /// customer data required to produce a pay-by-link
    /// </summary>
    [DataContract(Name = "PayByLinkCustomer")]
    public partial class PayByLinkCustomer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayByLinkCustomer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayByLinkCustomer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayByLinkCustomer" /> class.
        /// </summary>
        /// <param name="id">customer id that already exists in easypay..</param>
        /// <param name="name">customer name (required).</param>
        /// <param name="email">email (required).</param>
        /// <param name="phone">e164 formatted phone (required).</param>
        /// <param name="language">2- or 3-letter ISO 3166-1 (required).</param>
        public PayByLinkCustomer(Guid id = default(Guid), string name = default(string), string email = default(string), string phone = default(string), string language = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PayByLinkCustomer and cannot be null");
            }
            this.Name = name;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for PayByLinkCustomer and cannot be null");
            }
            this.Email = email;
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new ArgumentNullException("phone is a required property for PayByLinkCustomer and cannot be null");
            }
            this.Phone = phone;
            // to ensure "language" is required (not null)
            if (language == null)
            {
                throw new ArgumentNullException("language is a required property for PayByLinkCustomer and cannot be null");
            }
            this.Language = language;
            this.Id = id;
        }

        /// <summary>
        /// customer id that already exists in easypay.
        /// </summary>
        /// <value>customer id that already exists in easypay.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// customer name
        /// </summary>
        /// <value>customer name</value>
        /*
        <example>Jonh Doe</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /*
        <example>example@easypay.pt</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// e164 formatted phone
        /// </summary>
        /// <value>e164 formatted phone</value>
        /*
        <example>+351911234567</example>
        */
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// 2- or 3-letter ISO 3166-1
        /// </summary>
        /// <value>2- or 3-letter ISO 3166-1</value>
        /*
        <example>PT</example>
        */
        [DataMember(Name = "language", IsRequired = true, EmitDefaultValue = true)]
        public string Language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayByLinkCustomer {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new[] { "Name" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 70)
            {
                yield return new ValidationResult("Invalid value for Email, length must be less than 70.", new[] { "Email" });
            }

            yield break;
        }
    }

}
