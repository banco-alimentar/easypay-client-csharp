using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Easypay.Rest.Client.Model
{
    public class PaymentRecurringResponseMethod
    {
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
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 4,

            /// <summary>
            /// Enum Canceled for value: canceled
            /// </summary>
            [EnumMember(Value = "canceled")]
            Canceled = 5,

            /// <summary>
            /// Enum Deleted for value: deleted
            /// </summary>
            [EnumMember(Value = "deleted")]
            Deleted = 6

        }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public PaymentSubscriptionMethodAvailable Type { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "sdd_mandate", EmitDefaultValue = false)]
        public SddMandate SddMandate { get; set; }

        /// <summary>
        /// Gets or Sets Entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public int Entity { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Last 4 digits of the  submitted Credit Card
        /// </summary>
        /// <value>Last 4 digits of the  submitted Credit Card</value>
        [DataMember(Name = "last_four", EmitDefaultValue = false)]
        public string LastFour { get; set; }

        /// <summary>
        /// MasterCard, VISA
        /// </summary>
        /// <value>MasterCard, VISA</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expiration_date", EmitDefaultValue = false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum Status { get; set; }
    }
}
