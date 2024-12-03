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
    /// The Pagination object contains detailed information about the pagination of a collection of records.  This object is used to provide navigation and context for paginated results, allowing users to easily move between pages and understand the scope of the dataset.
    /// </summary>
    [DataContract(Name = "ResponseMeta")]
    public partial class ResponseMeta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMeta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResponseMeta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMeta" /> class.
        /// </summary>
        /// <param name="page">page (required).</param>
        /// <param name="records">records.</param>
        /// <param name="links">links.</param>
        public ResponseMeta(ResponseMetaPage page = default(ResponseMetaPage), ResponseMetaRecords records = default(ResponseMetaRecords), ResponseMetaLinks links = default(ResponseMetaLinks))
        {
            // to ensure "page" is required (not null)
            if (page == null)
            {
                throw new ArgumentNullException("page is a required property for ResponseMeta and cannot be null");
            }
            this.Page = page;
            this.Records = records;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name = "page", IsRequired = true, EmitDefaultValue = true)]
        public ResponseMetaPage Page { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public ResponseMetaRecords Records { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public ResponseMetaLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseMeta {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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