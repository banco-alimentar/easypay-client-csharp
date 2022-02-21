/*
 * Easypay API
 *
 * EasyPay - API
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
    /// PaymentSingleMethod
    /// </summary>
    [DataContract(Name = "Payment_Single_method")]
    public partial class PaymentSingleMethod : IEquatable<PaymentSingleMethod>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Mb for value: mb
            /// </summary>
            [EnumMember(Value = "mb")]
            Mb = 1,

            /// <summary>
            /// Enum Cc for value: cc
            /// </summary>
            [EnumMember(Value = "cc")]
            Cc = 2,

            /// <summary>
            /// Enum Mbw for value: mbw
            /// </summary>
            [EnumMember(Value = "mbw")]
            Mbw = 3,

            /// <summary>
            /// Enum Dd for value: dd
            /// </summary>
            [EnumMember(Value = "dd")]
            Dd = 4,

            /// <summary>
            /// Enum Bb for value: bb
            /// </summary>
            [EnumMember(Value = "bb")]
            Bb = 5

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
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
            /// Enum Waiting for value: waiting
            /// </summary>
            [EnumMember(Value = "waiting")]
            Waiting = 2,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 3,

            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 4,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 5

        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSingleMethod" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="sddMandate">sddMandate.</param>
        /// <param name="entity">entity.</param>
        /// <param name="reference">reference.</param>
        /// <param name="url">url.</param>
        /// <param name="lastFour">Last 4 digits of the  submitted Credit Card.</param>
        /// <param name="cardType">MasterCard, VISA.</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="status">status.</param>
        /// <param name="alias">MBWAY Alias (only for mobile implementation using MBWAY SDK).</param>
        public PaymentSingleMethod(TypeEnum? type = default(TypeEnum?), SinglePaymentUpdateRequestSddMandate sddMandate = default(SinglePaymentUpdateRequestSddMandate), int entity = default(int), string reference = default(string), string url = default(string), string lastFour = default(string), string cardType = default(string), string expirationDate = default(string), StatusEnum? status = default(StatusEnum?), string alias = default(string))
        {
            this.Type = type;
            this.SddMandate = sddMandate;
            this.Entity = entity;
            this.Reference = reference;
            this.Url = url;
            this.LastFour = lastFour;
            this.CardType = cardType;
            this.ExpirationDate = expirationDate;
            this.Status = status;
            this.Alias = alias;
        }

        /// <summary>
        /// Gets or Sets SddMandate
        /// </summary>
        [DataMember(Name = "sdd_mandate", EmitDefaultValue = false)]
        public SinglePaymentUpdateRequestSddMandate SddMandate { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public int Entity { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Last 4 digits of the  submitted Credit Card
        /// </summary>
        /// <value>Last 4 digits of the  submitted Credit Card</value>
        [DataMember(Name = "last_four", EmitDefaultValue = false)]
        public string LastFour { get; set; }

        /// <summary>
        /// MasterCard, VISA
        /// </summary>
        /// <value>MasterCard, VISA</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expiration_date", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// MBWAY Alias (only for mobile implementation using MBWAY SDK)
        /// </summary>
        /// <value>MBWAY Alias (only for mobile implementation using MBWAY SDK)</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSingleMethod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SddMandate: ").Append(SddMandate).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  LastFour: ").Append(LastFour).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
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
            return this.Equals(input as PaymentSingleMethod);
        }

        /// <summary>
        /// Returns true if PaymentSingleMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSingleMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSingleMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SddMandate == input.SddMandate ||
                    (this.SddMandate != null &&
                    this.SddMandate.Equals(input.SddMandate))
                ) && 
                (
                    this.Entity == input.Entity ||
                    this.Entity.Equals(input.Entity)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.LastFour == input.LastFour ||
                    (this.LastFour != null &&
                    this.LastFour.Equals(input.LastFour))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.ExpirationDate == input.ExpirationDate ||
                    (this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(input.ExpirationDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.SddMandate != null)
                    hashCode = hashCode * 59 + this.SddMandate.GetHashCode();
                hashCode = hashCode * 59 + this.Entity.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.LastFour != null)
                    hashCode = hashCode * 59 + this.LastFour.GetHashCode();
                if (this.CardType != null)
                    hashCode = hashCode * 59 + this.CardType.GetHashCode();
                if (this.ExpirationDate != null)
                    hashCode = hashCode * 59 + this.ExpirationDate.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
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