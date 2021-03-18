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
using OpenAPIDateConverter = Easypay.Rest.Client.Client.OpenAPIDateConverter;

namespace Easypay.Rest.Client.Model
{
    /// <summary>
    /// PropertiesHasSddMandate
    /// </summary>
    [DataContract(Name = "Properties_Has_SddMandate")]
    public partial class PropertiesHasSddMandate : IEquatable<PropertiesHasSddMandate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesHasSddMandate" /> class.
        /// </summary>
        /// <param name="sddMandate">sddMandate.</param>
        public PropertiesHasSddMandate(SddMandate sddMandate = default(SddMandate))
        {
            this.SddMandate = sddMandate;
        }

        /// <summary>
        /// Gets or Sets SddMandate
        /// </summary>
        [DataMember(Name = "sdd_mandate", EmitDefaultValue = false)]
        public SddMandate SddMandate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesHasSddMandate {\n");
            sb.Append("  SddMandate: ").Append(SddMandate).Append("\n");
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
            return this.Equals(input as PropertiesHasSddMandate);
        }

        /// <summary>
        /// Returns true if PropertiesHasSddMandate instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesHasSddMandate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesHasSddMandate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SddMandate == input.SddMandate ||
                    (this.SddMandate != null &&
                    this.SddMandate.Equals(input.SddMandate))
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
                if (this.SddMandate != null)
                    hashCode = hashCode * 59 + this.SddMandate.GetHashCode();
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