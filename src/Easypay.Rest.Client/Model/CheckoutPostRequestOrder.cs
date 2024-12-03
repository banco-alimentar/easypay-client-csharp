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
    /// Order represent the order/cart being paid. Order is required if type is one single or subscription.
    /// </summary>
    [DataContract(Name = "checkout_post_request_order")]
    public partial class CheckoutPostRequestOrder : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPostRequestOrder" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutPostRequestOrder() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPostRequestOrder" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="key">The merchant&#39;s key to identify the order..</param>
        /// <param name="value">The price being paid for the entire order, rounded to 2 decimals. (required).</param>
        public CheckoutPostRequestOrder(Collection<CheckoutPostRequestOrderItemsInner> items = default(Collection<CheckoutPostRequestOrderItemsInner>), string key = default(string), decimal value = default(decimal))
        {
            this.Value = value;
            this.Items = items;
            this.Key = key;
        }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public Collection<CheckoutPostRequestOrderItemsInner> Items { get; set; }

        /// <summary>
        /// The merchant&#39;s key to identify the order.
        /// </summary>
        /// <value>The merchant&#39;s key to identify the order.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// The price being paid for the entire order, rounded to 2 decimals.
        /// </summary>
        /// <value>The price being paid for the entire order, rounded to 2 decimals.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public decimal Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutPostRequestOrder {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Value (decimal) minimum
            if (this.Value < (decimal)0.01)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.01.", new[] { "Value" });
            }

            yield break;
        }
    }

}
