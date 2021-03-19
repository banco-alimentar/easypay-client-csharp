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
    /// PaymentMethodBase
    /// </summary>
    [DataContract(Name = "PaymentMethod_Base")]
    public partial class PaymentMethodBase : IEquatable<PaymentMethodBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodBase" /> class.
        /// </summary>
        /// <param name="entity">entity.</param>
        /// <param name="reference">reference.</param>
        /// <param name="url">url.</param>
        /// <param name="lastFour">Last 4 digits of the  submitted Credit Card.</param>
        /// <param name="cardType">MasterCard, VISA.</param>
        /// <param name="expirationDate">expirationDate.</param>
        public PaymentMethodBase(int entity = default(int), string reference = default(string), string url = default(string), string lastFour = default(string), string cardType = default(string), string expirationDate = default(string))
        {
            this.Entity = entity;
            this.Reference = reference;
            this.Url = url;
            this.LastFour = lastFour;
            this.CardType = cardType;
            this.ExpirationDate = expirationDate;
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodBase {\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  LastFour: ").Append(LastFour).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
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
            return this.Equals(input as PaymentMethodBase);
        }

        /// <summary>
        /// Returns true if PaymentMethodBase instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodBase input)
        {
            if (input == null)
                return false;

            return 
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
