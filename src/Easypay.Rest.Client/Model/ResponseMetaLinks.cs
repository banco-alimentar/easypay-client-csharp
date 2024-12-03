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
    /// An object containing URLs for navigation between different pages of the collection.
    /// </summary>
    [DataContract(Name = "ResponseMeta_links")]
    public partial class ResponseMetaLinks : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseMetaLinks" /> class.
        /// </summary>
        /// <param name="first">The URL to the first page of the collection..</param>
        /// <param name="prev">The URL to the previous page of the collection. This field is an empty string if there is no previous page..</param>
        /// <param name="next">The URL to the next page of the collection. This field is an empty string if there is no next page..</param>
        /// <param name="last">The URL to the last page of the collection..</param>
        public ResponseMetaLinks(string first = default(string), string prev = default(string), string next = default(string), string last = default(string))
        {
            this.First = first;
            this.Prev = prev;
            this.Next = next;
            this.Last = last;
        }

        /// <summary>
        /// The URL to the first page of the collection.
        /// </summary>
        /// <value>The URL to the first page of the collection.</value>
        [DataMember(Name = "first", EmitDefaultValue = false)]
        public string First { get; set; }

        /// <summary>
        /// The URL to the previous page of the collection. This field is an empty string if there is no previous page.
        /// </summary>
        /// <value>The URL to the previous page of the collection. This field is an empty string if there is no previous page.</value>
        [DataMember(Name = "prev", EmitDefaultValue = false)]
        public string Prev { get; set; }

        /// <summary>
        /// The URL to the next page of the collection. This field is an empty string if there is no next page.
        /// </summary>
        /// <value>The URL to the next page of the collection. This field is an empty string if there is no next page.</value>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// The URL to the last page of the collection.
        /// </summary>
        /// <value>The URL to the last page of the collection.</value>
        [DataMember(Name = "last", EmitDefaultValue = false)]
        public string Last { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseMetaLinks {\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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