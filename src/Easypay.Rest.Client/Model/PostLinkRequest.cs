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
    /// PostLinkRequest
    /// </summary>
    [DataContract(Name = "post_link_request")]
    public partial class PostLinkRequest : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public PayByLinkPaymentTypes Type { get; set; }
        /// <summary>
        /// Defines CommunicationChannels
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CommunicationChannelsEnum
        {
            /// <summary>
            /// Enum SMS for value: SMS
            /// </summary>
            [EnumMember(Value = "SMS")]
            SMS = 1,

            /// <summary>
            /// Enum EMAIL for value: EMAIL
            /// </summary>
            [EnumMember(Value = "EMAIL")]
            EMAIL = 2
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostLinkRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostLinkRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostLinkRequest" /> class.
        /// </summary>
        /// <param name="expirationTime">rfc3339 formatted time for the link expiration date..</param>
        /// <param name="type">type (required).</param>
        /// <param name="customer">customer (required).</param>
        /// <param name="communicationChannels">the communication channels to where the final customer link should be forwarded.</param>
        /// <param name="payment">payment (required).</param>
        public PostLinkRequest(DateTime expirationTime = default(DateTime), PayByLinkPaymentTypes type = default(PayByLinkPaymentTypes), PayByLinkCustomer customer = default(PayByLinkCustomer), Collection<CommunicationChannelsEnum> communicationChannels = default(Collection<CommunicationChannelsEnum>), PostLinkRequestPayment payment = default(PostLinkRequestPayment))
        {
            this.Type = type;
            // to ensure "customer" is required (not null)
            if (customer == null)
            {
                throw new ArgumentNullException("customer is a required property for PostLinkRequest and cannot be null");
            }
            this.Customer = customer;
            // to ensure "payment" is required (not null)
            if (payment == null)
            {
                throw new ArgumentNullException("payment is a required property for PostLinkRequest and cannot be null");
            }
            this.Payment = payment;
            this.ExpirationTime = expirationTime;
            this.CommunicationChannels = communicationChannels;
        }

        /// <summary>
        /// rfc3339 formatted time for the link expiration date.
        /// </summary>
        /// <value>rfc3339 formatted time for the link expiration date.</value>
        [DataMember(Name = "expiration_time", EmitDefaultValue = false)]
        public DateTime ExpirationTime { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", IsRequired = true, EmitDefaultValue = true)]
        public PayByLinkCustomer Customer { get; set; }

        /// <summary>
        /// the communication channels to where the final customer link should be forwarded
        /// </summary>
        /// <value>the communication channels to where the final customer link should be forwarded</value>
        [DataMember(Name = "communication_channels", EmitDefaultValue = false)]
        public Collection<PostLinkRequest.CommunicationChannelsEnum> CommunicationChannels { get; set; }

        /// <summary>
        /// Gets or Sets Payment
        /// </summary>
        [DataMember(Name = "payment", IsRequired = true, EmitDefaultValue = true)]
        public PostLinkRequestPayment Payment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PostLinkRequest {\n");
            sb.Append("  ExpirationTime: ").Append(ExpirationTime).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  CommunicationChannels: ").Append(CommunicationChannels).Append("\n");
            sb.Append("  Payment: ").Append(Payment).Append("\n");
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
