/*
 * Easypay API
 *
 * EasyPay - API
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
    /// PaymentSingleTransactionValues
    /// </summary>
    [DataContract(Name = "Payment_Single_Transaction_values")]
    public partial class PaymentSingleTransactionValues : IEquatable<PaymentSingleTransactionValues>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSingleTransactionValues" /> class.
        /// </summary>
        /// <param name="requested">requested.</param>
        /// <param name="paid">paid.</param>
        /// <param name="fixedFee">fixedFee.</param>
        /// <param name="variableFee">variableFee.</param>
        /// <param name="tax">tax.</param>
        /// <param name="transfer">transfer.</param>
        public PaymentSingleTransactionValues(double requested = default(double), double paid = default(double), double fixedFee = default(double), double variableFee = default(double), double tax = default(double), double transfer = default(double))
        {
            this.Requested = requested;
            this.Paid = paid;
            this.FixedFee = fixedFee;
            this.VariableFee = variableFee;
            this.Tax = tax;
            this.Transfer = transfer;
        }

        /// <summary>
        /// Gets or Sets Requested
        /// </summary>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public double Requested { get; set; }

        /// <summary>
        /// Gets or Sets Paid
        /// </summary>
        [DataMember(Name = "paid", EmitDefaultValue = false)]
        public double Paid { get; set; }

        /// <summary>
        /// Gets or Sets FixedFee
        /// </summary>
        [DataMember(Name = "fixed_fee", EmitDefaultValue = false)]
        public double FixedFee { get; set; }

        /// <summary>
        /// Gets or Sets VariableFee
        /// </summary>
        [DataMember(Name = "variable_fee", EmitDefaultValue = false)]
        public double VariableFee { get; set; }

        /// <summary>
        /// Gets or Sets Tax
        /// </summary>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        public double Tax { get; set; }

        /// <summary>
        /// Gets or Sets Transfer
        /// </summary>
        [DataMember(Name = "transfer", EmitDefaultValue = false)]
        public double Transfer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSingleTransactionValues {\n");
            sb.Append("  Requested: ").Append(Requested).Append("\n");
            sb.Append("  Paid: ").Append(Paid).Append("\n");
            sb.Append("  FixedFee: ").Append(FixedFee).Append("\n");
            sb.Append("  VariableFee: ").Append(VariableFee).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Transfer: ").Append(Transfer).Append("\n");
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
            return this.Equals(input as PaymentSingleTransactionValues);
        }

        /// <summary>
        /// Returns true if PaymentSingleTransactionValues instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentSingleTransactionValues to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentSingleTransactionValues input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Requested == input.Requested ||
                    this.Requested.Equals(input.Requested)
                ) && 
                (
                    this.Paid == input.Paid ||
                    this.Paid.Equals(input.Paid)
                ) && 
                (
                    this.FixedFee == input.FixedFee ||
                    this.FixedFee.Equals(input.FixedFee)
                ) && 
                (
                    this.VariableFee == input.VariableFee ||
                    this.VariableFee.Equals(input.VariableFee)
                ) && 
                (
                    this.Tax == input.Tax ||
                    this.Tax.Equals(input.Tax)
                ) && 
                (
                    this.Transfer == input.Transfer ||
                    this.Transfer.Equals(input.Transfer)
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
                hashCode = hashCode * 59 + this.Requested.GetHashCode();
                hashCode = hashCode * 59 + this.Paid.GetHashCode();
                hashCode = hashCode * 59 + this.FixedFee.GetHashCode();
                hashCode = hashCode * 59 + this.VariableFee.GetHashCode();
                hashCode = hashCode * 59 + this.Tax.GetHashCode();
                hashCode = hashCode * 59 + this.Transfer.GetHashCode();
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
