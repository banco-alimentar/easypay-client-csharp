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
    /// AuthorisationIdGet200ResponseTransactionsInner
    /// </summary>
    [DataContract(Name = "_authorisation__id__get_200_response_transactions_inner")]
    public partial class AuthorisationIdGet200ResponseTransactionsInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorisationIdGet200ResponseTransactionsInner" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="key">key.</param>
        /// <param name="date">date.</param>
        /// <param name="values">values.</param>
        /// <param name="transferDate">transferDate.</param>
        /// <param name="transferBatch">transferBatch.</param>
        /// <param name="method">method.</param>
        /// <param name="documentNumber">documentNumber.</param>
        /// <param name="descriptive">descriptive.</param>
        public AuthorisationIdGet200ResponseTransactionsInner(string id = default(string), string key = default(string), string date = default(string), AuthorisationIdGet200ResponseTransactionsInnerValues values = default(AuthorisationIdGet200ResponseTransactionsInnerValues), string transferDate = default(string), string transferBatch = default(string), string method = default(string), string documentNumber = default(string), string descriptive = default(string))
        {
            this.Id = id;
            this.Key = key;
            this.Date = date;
            this.Values = values;
            this.TransferDate = transferDate;
            this.TransferBatch = transferBatch;
            this.Method = method;
            this.DocumentNumber = documentNumber;
            this.Descriptive = descriptive;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public AuthorisationIdGet200ResponseTransactionsInnerValues Values { get; set; }

        /// <summary>
        /// Gets or Sets TransferDate
        /// </summary>
        [DataMember(Name = "transfer_date", EmitDefaultValue = false)]
        public string TransferDate { get; set; }

        /// <summary>
        /// Gets or Sets TransferBatch
        /// </summary>
        [DataMember(Name = "transfer_batch", EmitDefaultValue = false)]
        public string TransferBatch { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets DocumentNumber
        /// </summary>
        [DataMember(Name = "document_number", EmitDefaultValue = false)]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Gets or Sets Descriptive
        /// </summary>
        [DataMember(Name = "descriptive", EmitDefaultValue = false)]
        public string Descriptive { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorisationIdGet200ResponseTransactionsInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  TransferDate: ").Append(TransferDate).Append("\n");
            sb.Append("  TransferBatch: ").Append(TransferBatch).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  DocumentNumber: ").Append(DocumentNumber).Append("\n");
            sb.Append("  Descriptive: ").Append(Descriptive).Append("\n");
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