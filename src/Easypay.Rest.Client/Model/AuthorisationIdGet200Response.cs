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
    /// AuthorisationIdGet200Response
    /// </summary>
    [DataContract(Name = "_authorisation__id__get_200_response")]
    public partial class AuthorisationIdGet200Response : IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            [EnumMember(Value = "success")]
            Success = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 4
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public Currency? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorisationIdGet200Response" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="message">message.</param>
        /// <param name="key">key.</param>
        /// <param name="customer">customer.</param>
        /// <param name="method">method.</param>
        /// <param name="currency">currency.</param>
        /// <param name="value">value.</param>
        /// <param name="valueCaptured">valueCaptured.</param>
        /// <param name="transactions">transactions.</param>
        public AuthorisationIdGet200Response(string id = default(string), StatusEnum? status = default(StatusEnum?), string message = default(string), string key = default(string), AuthorisationIdGet200ResponseCustomer customer = default(AuthorisationIdGet200ResponseCustomer), AuthorisationIdGet200ResponseMethod method = default(AuthorisationIdGet200ResponseMethod), Currency? currency = default(Currency?), decimal value = default(decimal), decimal valueCaptured = default(decimal), Collection<AuthorisationIdGet200ResponseTransactionsInner> transactions = default(Collection<AuthorisationIdGet200ResponseTransactionsInner>))
        {
            this.Id = id;
            this.Status = status;
            this.Message = message;
            this.Key = key;
            this.Customer = customer;
            this.Method = method;
            this.Currency = currency;
            this.Value = value;
            this.ValueCaptured = valueCaptured;
            this.Transactions = transactions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public AuthorisationIdGet200ResponseCustomer Customer { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public AuthorisationIdGet200ResponseMethod Method { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public decimal Value { get; set; }

        /// <summary>
        /// Gets or Sets ValueCaptured
        /// </summary>
        [DataMember(Name = "value_captured", EmitDefaultValue = false)]
        public decimal ValueCaptured { get; set; }

        /// <summary>
        /// Gets or Sets Transactions
        /// </summary>
        [DataMember(Name = "transactions", EmitDefaultValue = false)]
        public Collection<AuthorisationIdGet200ResponseTransactionsInner> Transactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorisationIdGet200Response {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  ValueCaptured: ").Append(ValueCaptured).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
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
            yield break;
        }
    }

}
