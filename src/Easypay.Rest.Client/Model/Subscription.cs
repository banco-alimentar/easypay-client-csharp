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
    /// Subscription
    /// </summary>
    [DataContract(Name = "Subscription")]
    public partial class Subscription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Subscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="frequency">frequency (required).</param>
        /// <param name="maximumCaptures">maximumCaptures (required).</param>
        /// <param name="startTime">startTime (required).</param>
        /// <param name="captureNow">captureNow (required).</param>
        /// <param name="retries">retries (required).</param>
        /// <param name="failover">failover (required).</param>
        public Subscription(string frequency = default(string), string maximumCaptures = default(string), string startTime = default(string), bool captureNow = default(bool), int retries = default(int), bool failover = default(bool))
        {
            // to ensure "frequency" is required (not null)
            if (frequency == null)
            {
                throw new ArgumentNullException("frequency is a required property for Subscription and cannot be null");
            }
            this.Frequency = frequency;
            // to ensure "maximumCaptures" is required (not null)
            if (maximumCaptures == null)
            {
                throw new ArgumentNullException("maximumCaptures is a required property for Subscription and cannot be null");
            }
            this.MaximumCaptures = maximumCaptures;
            // to ensure "startTime" is required (not null)
            if (startTime == null)
            {
                throw new ArgumentNullException("startTime is a required property for Subscription and cannot be null");
            }
            this.StartTime = startTime;
            this.CaptureNow = captureNow;
            this.Retries = retries;
            this.Failover = failover;
        }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = true)]
        public string Frequency { get; set; }

        /// <summary>
        /// Gets or Sets MaximumCaptures
        /// </summary>
        [DataMember(Name = "maximum_captures", IsRequired = true, EmitDefaultValue = true)]
        public string MaximumCaptures { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "start_time", IsRequired = true, EmitDefaultValue = true)]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or Sets CaptureNow
        /// </summary>
        [DataMember(Name = "capture_now", IsRequired = true, EmitDefaultValue = true)]
        public bool CaptureNow { get; set; }

        /// <summary>
        /// Gets or Sets Retries
        /// </summary>
        [DataMember(Name = "retries", IsRequired = true, EmitDefaultValue = true)]
        public int Retries { get; set; }

        /// <summary>
        /// Gets or Sets Failover
        /// </summary>
        [DataMember(Name = "failover", IsRequired = true, EmitDefaultValue = true)]
        public bool Failover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  MaximumCaptures: ").Append(MaximumCaptures).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  CaptureNow: ").Append(CaptureNow).Append("\n");
            sb.Append("  Retries: ").Append(Retries).Append("\n");
            sb.Append("  Failover: ").Append(Failover).Append("\n");
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