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
    /// PropertiesHasPaidAt
    /// </summary>
    [DataContract(Name = "Properties_Has_PaidAt")]
    public partial class PropertiesHasPaidAt : IEquatable<PropertiesHasPaidAt>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesHasPaidAt" /> class.
        /// </summary>
        /// <param name="paidAt">Date when the single payment was paid.</param>
        public PropertiesHasPaidAt(string paidAt = default(string))
        {
            this.PaidAt = paidAt;
        }

        /// <summary>
        /// Date when the single payment was paid
        /// </summary>
        /// <value>Date when the single payment was paid</value>
        [DataMember(Name = "paid_at", EmitDefaultValue = false)]
        public string PaidAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesHasPaidAt {\n");
            sb.Append("  PaidAt: ").Append(PaidAt).Append("\n");
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
            return this.Equals(input as PropertiesHasPaidAt);
        }

        /// <summary>
        /// Returns true if PropertiesHasPaidAt instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesHasPaidAt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesHasPaidAt input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaidAt == input.PaidAt ||
                    (this.PaidAt != null &&
                    this.PaidAt.Equals(input.PaidAt))
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
                if (this.PaidAt != null)
                    hashCode = hashCode * 59 + this.PaidAt.GetHashCode();
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
