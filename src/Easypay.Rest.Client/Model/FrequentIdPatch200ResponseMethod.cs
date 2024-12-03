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
    /// FrequentIdPatch200ResponseMethod
    /// </summary>
    [DataContract(Name = "_frequent__id__patch_200_response_method")]
    public partial class FrequentIdPatch200ResponseMethod : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Mb for value: mb
            /// </summary>
            [EnumMember(Value = "mb")]
            Mb = 1,

            /// <summary>
            /// Enum Cc for value: cc
            /// </summary>
            [EnumMember(Value = "cc")]
            Cc = 2,

            /// <summary>
            /// Enum Dd for value: dd
            /// </summary>
            [EnumMember(Value = "dd")]
            Dd = 3,

            /// <summary>
            /// Enum Mbw for value: mbw
            /// </summary>
            [EnumMember(Value = "mbw")]
            Mbw = 4,

            /// <summary>
            /// Enum Vi for value: vi
            /// </summary>
            [EnumMember(Value = "vi")]
            Vi = 5
        }


        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Waiting for value: waiting
            /// </summary>
            [EnumMember(Value = "waiting")]
            Waiting = 1,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,

            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 3,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 4
        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FrequentIdPatch200ResponseMethod" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="status">status.</param>
        /// <param name="url">Only returns if the payment is a Credid Card..</param>
        /// <param name="entity">entity.</param>
        /// <param name="reference">reference.</param>
        public FrequentIdPatch200ResponseMethod(TypeEnum? type = default(TypeEnum?), StatusEnum? status = default(StatusEnum?), string url = default(string), string entity = default(string), string reference = default(string))
        {
            this.Type = type;
            this.Status = status;
            this.Url = url;
            this.Entity = entity;
            this.Reference = reference;
        }

        /// <summary>
        /// Only returns if the payment is a Credid Card.
        /// </summary>
        /// <value>Only returns if the payment is a Credid Card.</value>
        /*
        <example>https://cc.test.easypay.pt/start/86401037-1c8d-4cf3-9172-d0a29b17b9fd</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        /*
        <example>59126</example>
        */
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string Entity { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        /*
        <example>810000618</example>
        */
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FrequentIdPatch200ResponseMethod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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