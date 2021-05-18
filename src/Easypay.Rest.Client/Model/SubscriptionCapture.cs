namespace Easypay.Rest.Client.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract(Name = "SubscriptionRequest_capture")]
    public class SubscriptionCapture
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCapture" /> class.
        /// </summary>
        /// <param name="descriptive">This will appear in the bank statement/mbway application (required).</param>
        /// <param name="transactionKey">Your internal key identifying this capture.</param>
        /// <param name="account">account.</param>        
        public SubscriptionCapture(string descriptive = default(string), string transactionKey = default(string), SinglePaymentRequestCapture account = default(SinglePaymentRequestCapture))
        {
            // to ensure "descriptive" is required (not null)
            this.Descriptive = descriptive ?? throw new ArgumentNullException("descriptive is a required property for SinglePaymentRequestCapture and cannot be null");
            this.TransactionKey = transactionKey;
            this.Account = account;
        }

        /// <summary>
        /// Your internal key identifying this capture
        /// </summary>
        /// <value>Your internal key identifying this capture</value>
        [DataMember(Name = "transaction_key", EmitDefaultValue = false)]
        public string TransactionKey { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public SinglePaymentRequestCapture Account { get; set; }

        /// <summary>
        /// This will appear in the bank statement/mbway application
        /// </summary>
        /// <value>This will appear in the bank statement/mbway application</value>
        [DataMember(Name = "descriptive", IsRequired = true, EmitDefaultValue = false)]
        public string Descriptive { get; set; }
    }
}
