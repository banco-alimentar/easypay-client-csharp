/*
 * Easypay API
 *
 * EasyPay - API allows you to query payment meta-data, receive payment notifications and generate payment references. Two distinct environments - [Sandbox environment](https://api.test.easypay.pt/docs) and [Production environment](https://api.prod.easypay.pt/docs).
 *
 * The version of the OpenAPI document: 2.0.2
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
    /// PaymentSingleResponse
    /// </summary>
    [DataContract(Name = "paymentSingleResponse")]
    public partial class PaymentSingleResponse : IEquatable<PaymentSingleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSingleResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="id">id.</param>
        /// <param name="method">method.</param>
        /// <param name="customer">customer.</param>
        public PaymentSingleResponse(string status = default(string), Collection<string> message = default(Collection<string>), Guid id = default(Guid), PaymentMethod method = default(PaymentMethod), PropertiesHasID customer = default(PropertiesHasID))
        {
            this.Status = status;
            this.Message = message;
            this.Id = id;
            this.Method = method;
            this.Customer = customer;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public Collection<string> Message { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public PaymentMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public PropertiesHasID Customer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSingleResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
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
            return this.Equals(input as PaymentSingleResponse);
        }

        /// <summary>
        /// Returns true if PaymentSingleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSingleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSingleResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Message == input.Message ||
                    this.Message != null &&
                    input.Message != null &&
                    this.Message.SequenceEqual(input.Message)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Customer == input.Customer ||
                    (this.Customer != null &&
                    this.Customer.Equals(input.Customer))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Customer != null)
                    hashCode = hashCode * 59 + this.Customer.GetHashCode();
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
