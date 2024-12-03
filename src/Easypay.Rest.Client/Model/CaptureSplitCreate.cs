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
    /// CaptureSplitCreate
    /// </summary>
    [DataContract(Name = "CaptureSplitCreate")]
    public partial class CaptureSplitCreate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureSplitCreate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CaptureSplitCreate() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CaptureSplitCreate" /> class.
        /// </summary>
        /// <param name="splitKey">A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system..</param>
        /// <param name="splitDescriptive">A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;..</param>
        /// <param name="value">The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. (required).</param>
        /// <param name="account">The account to which the funds should be routed. This field is used to specify the destination account for the split payment, ensuring that the correct recipient receives their designated portion of the funds. (required).</param>
        /// <param name="marginValue">The monetary amount designated as the margin in a split payment. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;10.00\&quot;). The value must be less than the total value of the split. This specifies the portion of the funds that should be routed to the margin account..</param>
        /// <param name="marginAccount">marginAccount.</param>
        /// <param name="clearingPeriod">The clearing period must follow the format 1Y, 10W or 30D. Y for Years, W for weeks, D for days. Minimum is 7 days, maximum is 1 year..</param>
        public CaptureSplitCreate(string splitKey = default(string), string splitDescriptive = default(string), double value = default(double), SplitAccount account = default(SplitAccount), double marginValue = default(double), MarginAccount marginAccount = default(MarginAccount), string clearingPeriod = default(string))
        {
            this.Value = value;
            // to ensure "account" is required (not null)
            if (account == null)
            {
                throw new ArgumentNullException("account is a required property for CaptureSplitCreate and cannot be null");
            }
            this.Account = account;
            this.SplitKey = splitKey;
            this.SplitDescriptive = splitDescriptive;
            this.MarginValue = marginValue;
            this.MarginAccount = marginAccount;
            this.ClearingPeriod = clearingPeriod;
        }

        /// <summary>
        /// A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system.
        /// </summary>
        /// <value>A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system.</value>
        /*
        <example>01J1PKR2RPHJNJQGFWGDYXY0KM</example>
        */
        [DataMember(Name = "split_key", EmitDefaultValue = false)]
        public string SplitKey { get; set; }

        /// <summary>
        /// A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;.
        /// </summary>
        /// <value>A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;.</value>
        /*
        <example>Payment of Invoice Nº 1982652</example>
        */
        [DataMember(Name = "split_descriptive", EmitDefaultValue = false)]
        public string SplitDescriptive { get; set; }

        /// <summary>
        /// The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5.
        /// </summary>
        /// <value>The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5.</value>
        /*
        <example>15.32</example>
        */
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public double Value { get; set; }

        /// <summary>
        /// The account to which the funds should be routed. This field is used to specify the destination account for the split payment, ensuring that the correct recipient receives their designated portion of the funds.
        /// </summary>
        /// <value>The account to which the funds should be routed. This field is used to specify the destination account for the split payment, ensuring that the correct recipient receives their designated portion of the funds.</value>
        [DataMember(Name = "account", IsRequired = true, EmitDefaultValue = true)]
        public SplitAccount Account { get; set; }

        /// <summary>
        /// The monetary amount designated as the margin in a split payment. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;10.00\&quot;). The value must be less than the total value of the split. This specifies the portion of the funds that should be routed to the margin account.
        /// </summary>
        /// <value>The monetary amount designated as the margin in a split payment. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;10.00\&quot;). The value must be less than the total value of the split. This specifies the portion of the funds that should be routed to the margin account.</value>
        [DataMember(Name = "margin_value", EmitDefaultValue = false)]
        public double MarginValue { get; set; }

        /// <summary>
        /// Gets or Sets MarginAccount
        /// </summary>
        [DataMember(Name = "margin_account", EmitDefaultValue = false)]
        public MarginAccount MarginAccount { get; set; }

        /// <summary>
        /// The clearing period must follow the format 1Y, 10W or 30D. Y for Years, W for weeks, D for days. Minimum is 7 days, maximum is 1 year.
        /// </summary>
        /// <value>The clearing period must follow the format 1Y, 10W or 30D. Y for Years, W for weeks, D for days. Minimum is 7 days, maximum is 1 year.</value>
        [DataMember(Name = "clearing_period", EmitDefaultValue = false)]
        public string ClearingPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CaptureSplitCreate {\n");
            sb.Append("  SplitKey: ").Append(SplitKey).Append("\n");
            sb.Append("  SplitDescriptive: ").Append(SplitDescriptive).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  MarginValue: ").Append(MarginValue).Append("\n");
            sb.Append("  MarginAccount: ").Append(MarginAccount).Append("\n");
            sb.Append("  ClearingPeriod: ").Append(ClearingPeriod).Append("\n");
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
            if (this.SplitKey != null && this.SplitKey.Length > 255)
            {
                yield return new ValidationResult("Invalid value for SplitKey, length must be less than 255.", new[] { "SplitKey" });
            }

            // SplitDescriptive (string) maxLength
            if (this.SplitDescriptive != null && this.SplitDescriptive.Length > 255)
            {
                yield return new ValidationResult("Invalid value for SplitDescriptive, length must be less than 255.", new[] { "SplitDescriptive" });
            }

            // Value (double) minimum
            if (this.Value < (double)0.5)
            {
                yield return new ValidationResult("Invalid value for Value, must be a value greater than or equal to 0.5.", new[] { "Value" });
            }

            // ClearingPeriod (string) maxLength
            if (this.ClearingPeriod != null && this.ClearingPeriod.Length > 4)
            {
                yield return new ValidationResult("Invalid value for ClearingPeriod, length must be less than 4.", new[] { "ClearingPeriod" });
            }

            // ClearingPeriod (string) minLength
            if (this.ClearingPeriod != null && this.ClearingPeriod.Length < 2)
            {
                yield return new ValidationResult("Invalid value for ClearingPeriod, length must be greater than 2.", new[] { "ClearingPeriod" });
            }

            if (this.ClearingPeriod != null)
            {
                // ClearingPeriod (string) pattern
                Regex regexClearingPeriod = new Regex(@"^([\d]+)([YWD])$", RegexOptions.CultureInvariant);
                if (!regexClearingPeriod.Match(this.ClearingPeriod).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ClearingPeriod, must match a pattern of " + regexClearingPeriod, new[] { "ClearingPeriod" });
                }
            }

            yield break;
        }
    }

}