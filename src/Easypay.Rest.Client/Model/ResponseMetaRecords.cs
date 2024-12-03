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
    /// An object containing information about the records within the collection.
    /// </summary>
    [DataContract(Name = "ResponseMeta_records")]
    public partial class ResponseMetaRecords : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetaRecords" /> class.
        /// </summary>
        /// <param name="total">The total number of records available in the collection..</param>
        /// <param name="perPage">The number of records displayed per page..</param>
        public ResponseMetaRecords(int total = default(int), int perPage = default(int))
        {
            this.Total = total;
            this.PerPage = perPage;
        }

        /// <summary>
        /// The total number of records available in the collection.
        /// </summary>
        /// <value>The total number of records available in the collection.</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// The number of records displayed per page.
        /// </summary>
        /// <value>The number of records displayed per page.</value>
        [DataMember(Name = "per_page", EmitDefaultValue = false)]
        public int PerPage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseMetaRecords {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
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