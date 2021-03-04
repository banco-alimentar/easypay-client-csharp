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
using OpenAPIDateConverter = Easypay.Client.OpenAPIDateConverter;

namespace Easypay.Model
{
    /// <summary>
    /// PropertiesHasType
    /// </summary>
    [DataContract(Name = "Properties_Has_Type")]
    public partial class PropertiesHasType : IEquatable<PropertiesHasType>, IValidatableObject
    {
        /// <summary>
        /// Optional - only applicable to method cc or mbw
        /// </summary>
        /// <value>Optional - only applicable to method cc or mbw</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Sale for value: sale
            /// </summary>
            [EnumMember(Value = "sale")]
            Sale = 1,

            /// <summary>
            /// Enum Authorisation for value: authorisation
            /// </summary>
            [EnumMember(Value = "authorisation")]
            Authorisation = 2

        }

        /// <summary>
        /// Optional - only applicable to method cc or mbw
        /// </summary>
        /// <value>Optional - only applicable to method cc or mbw</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesHasType" /> class.
        /// </summary>
        /// <param name="type">Optional - only applicable to method cc or mbw (default to TypeEnum.Sale).</param>
        public PropertiesHasType(TypeEnum? type = TypeEnum.Sale)
        {
            this.Type = type;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesHasType {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as PropertiesHasType);
        }

        /// <summary>
        /// Returns true if PropertiesHasType instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesHasType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesHasType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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