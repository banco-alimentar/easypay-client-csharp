/*
 * Easypay API
 *
 * <a href='https://www.easypay.pt/en/terms-conditions-and-legal-terms' class='item'>Terms conditions and legal terms</a><br><a href='https://www.easypay.pt/en/privacy-policy' class='item'>Privacy Policy</a><br><br><b>EasyPay</b> API allows you to query payment meta-data, receive payment notifications and generate payment references. Since EasyPay API is based on REST principles, it´s very easy to write and test applications. You can use our code examples in PHP/CURL to test all the JSON payloads for Easypay Payment Service API.<br><br> We have two distinct environments on our API Services:<br> - If you are looking to receive payments, please use the <a href='https://api.prod.easypay.pt/docs#' class='item'><b>Production Documentation</b></a>.<br> - If you are looking to test or integrate, please use the <a href='https://goo.gl/CPxQnM' class='item'><b>Sandbox Documentation</b></a>. This environment will always have the latest road map deployments, usually all deployments are sent to production within 10 days. This environment is not meant for <b>Load Tests</b>, please do not use for this purpose, you might be blocked. <br><br> All communications have to include two headers for authentication, if fails it will always respond 403.<br> On <a href='https://backoffice.easypay.pt' class='item'><b>Easypay Backoffice</b></a> please create your authentication AccountId and ApiKey on menu: <i><b>Web Services->Configuration API 2.0->Keys</b></i>.<br><br> Our default response produces a <i><b>application/json</b></i>, but the <b>Accept</b> request-header field can be used to specify certain media types which are acceptable for the response. <br>Our available options are: <i>application/json</i>, <i>application/xml</i>, <i>text/csv</i>
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
    /// PropertiesHasValuePaidValue
    /// </summary>
    [DataContract(Name = "Properties_Has_ValuePaidValue")]
    public partial class PropertiesHasValuePaidValue : IEquatable<PropertiesHasValuePaidValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertiesHasValuePaidValue" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="valueCaptured">valueCaptured.</param>
        public PropertiesHasValuePaidValue(double value = default(double), double valueCaptured = default(double))
        {
            this.Value = value;
            this.ValueCaptured = valueCaptured;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueCaptured
        /// </summary>
        [DataMember(Name = "value_captured", EmitDefaultValue = false)]
        public double ValueCaptured { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertiesHasValuePaidValue {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueCaptured: ").Append(ValueCaptured).Append("\n");
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
            return this.Equals(input as PropertiesHasValuePaidValue);
        }

        /// <summary>
        /// Returns true if PropertiesHasValuePaidValue instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertiesHasValuePaidValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertiesHasValuePaidValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
                ) && 
                (
                    this.ValueCaptured == input.ValueCaptured ||
                    this.ValueCaptured.Equals(input.ValueCaptured)
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
                hashCode = hashCode * 59 + this.ValueCaptured.GetHashCode();
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
