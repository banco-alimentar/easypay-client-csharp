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
    /// CheckoutPostRequestPaymentCaptureSplitsInner
    /// </summary>
    [DataContract(Name = "checkout_post_request_payment_capture_splits_inner")]
    public partial class CheckoutPostRequestPaymentCaptureSplitsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPostRequestPaymentCaptureSplitsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutPostRequestPaymentCaptureSplitsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutPostRequestPaymentCaptureSplitsInner" /> class.
        /// </summary>
        /// <param name="splitKey">The merchant&#39;s internal key for identifying the split..</param>
        /// <param name="splitDescriptive">The description of the split..</param>
        /// <param name="value">The split funds, rounded to 2 decimals. (required).</param>
        /// <param name="account">account.</param>
        /// <param name="marginValue">The margin funds, rounded to 2 decimals..</param>
        /// <param name="marginAccount">marginAccount.</param>
        public CheckoutPostRequestPaymentCaptureSplitsInner(string splitKey = default(string), string splitDescriptive = default(string), double value = default(double), CaptureIdPostRequestSplitsInnerAccount account = default(CaptureIdPostRequestSplitsInnerAccount), decimal marginValue = default(decimal), CheckoutPostRequestPaymentCaptureSplitsInnerMarginAccount marginAccount = default(CheckoutPostRequestPaymentCaptureSplitsInnerMarginAccount))
        {
            this.Value = value;
            this.SplitKey = splitKey;
            this.SplitDescriptive = splitDescriptive;
            this.Account = account;
            this.MarginValue = marginValue;
            this.MarginAccount = marginAccount;
        }

        /// <summary>
        /// The merchant&#39;s internal key for identifying the split.
        /// </summary>
        /// <value>The merchant&#39;s internal key for identifying the split.</value>
        [DataMember(Name = "split_key", EmitDefaultValue = false)]
        public string SplitKey { get; set; }

        /// <summary>
        /// The description of the split.
        /// </summary>
        /// <value>The description of the split.</value>
        [DataMember(Name = "split_descriptive", EmitDefaultValue = false)]
        public string SplitDescriptive { get; set; }

        /// <summary>
        /// The split funds, rounded to 2 decimals.
        /// </summary>
        /// <value>The split funds, rounded to 2 decimals.</value>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public double Value { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public CaptureIdPostRequestSplitsInnerAccount Account { get; set; }

        /// <summary>
        /// The margin funds, rounded to 2 decimals.
        /// </summary>
        /// <value>The margin funds, rounded to 2 decimals.</value>
        [DataMember(Name = "margin_value", EmitDefaultValue = false)]
        public decimal MarginValue { get; set; }

        /// <summary>
        /// Gets or Sets MarginAccount
        /// </summary>
        [DataMember(Name = "margin_account", EmitDefaultValue = false)]
        public CheckoutPostRequestPaymentCaptureSplitsInnerMarginAccount MarginAccount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutPostRequestPaymentCaptureSplitsInner {\n");
            sb.Append("  SplitKey: ").Append(SplitKey).Append("\n");
            sb.Append("  SplitDescriptive: ").Append(SplitDescriptive).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  MarginValue: ").Append(MarginValue).Append("\n");
            sb.Append("  MarginAccount: ").Append(MarginAccount).Append("\n");
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
            // SplitKey (string) maxLength
            if (this.SplitKey != null && this.SplitKey.Length > 50)
            {
                yield return new ValidationResult("Invalid value for SplitKey, length must be less than 50.", new[] { "SplitKey" });
            }

            // SplitDescriptive (string) maxLength
            if (this.SplitDescriptive != null && this.SplitDescriptive.Length > 255)
            {
                yield return new ValidationResult("Invalid value for SplitDescriptive, length must be less than 255.", new[] { "SplitDescriptive" });
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