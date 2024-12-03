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
    /// CheckoutPostRequestOrderItemsInner
    /// </summary>
    [DataContract(Name = "checkout_post_request_order_items_inner")]
    public partial class CheckoutPostRequestOrderItemsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPostRequestOrderItemsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutPostRequestOrderItemsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPostRequestOrderItemsInner" /> class.
        /// </summary>
        /// <param name="description">The description of the item. (required).</param>
        /// <param name="quantity">Quantity of this item being paid..</param>
        /// <param name="key">The merchant&#39;s key to identify the item..</param>
        /// <param name="value">The price being paid for the specific item(s), rounded to 2 decimals. (required).</param>
        public CheckoutPostRequestOrderItemsInner(string description = default(string), int quantity = default(int), string key = default(string), double value = default(double))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for CheckoutPostRequestOrderItemsInner and cannot be null");
            }
            this.Description = description;
            this.Value = value;
            this.Quantity = quantity;
            this.Key = key;
        }

        /// <summary>
        /// The description of the item.
        /// </summary>
        /// <value>The description of the item.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Quantity of this item being paid.
        /// </summary>
        /// <value>Quantity of this item being paid.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The merchant&#39;s key to identify the item.
        /// </summary>
        /// <value>The merchant&#39;s key to identify the item.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// The price being paid for the specific item(s), rounded to 2 decimals.
        /// </summary>
        /// <value>The price being paid for the specific item(s), rounded to 2 decimals.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public double Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutPostRequestOrderItemsInner {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 100)
            {
                yield return new ValidationResult("Invalid value for Description, length must be less than 100.", new[] { "Description" });
            }

            // Key (string) maxLength
            if (this.Key != null && this.Key.Length > 50)
            {
                yield return new ValidationResult("Invalid value for Key, length must be less than 50.", new[] { "Key" });
            }

            // Value (double) minimum
            if (this.Value < (double)0.01)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.01.", new[] { "Value" });
            }

            yield break;
        }
    }

}