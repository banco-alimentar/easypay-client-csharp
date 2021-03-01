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
    /// PropertiesHasValue
    /// </summary>
    [DataContract(Name = "Properties_Has_Value")]
    public partial class PropertiesHasValue : IEquatable<PropertiesHasValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesHasValue" /> class.
        /// </summary>
        /// <param name="value">Value will be rounded to 2 decimals.</param>
        public PropertiesHasValue(double value = default(double))
        {
            this.Value = value;
        }

        /// <summary>
        /// Value will be rounded to 2 decimals
        /// </summary>
        /// <value>Value will be rounded to 2 decimals</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesHasValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as PropertiesHasValue);
        }

        /// <summary>
        /// Returns true if PropertiesHasValue instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesHasValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesHasValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                hashCode = hashCode * 59 + this.Value.GetHashCode();
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
            // Value (double) minimum
            if(this.Value < (double)0.5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.5.", new [] { "Value" });
            }

            yield break;
        }
    }

}
