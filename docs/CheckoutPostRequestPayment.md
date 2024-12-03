# Easypay.Rest.Client.Model.CheckoutPostRequestPayment
Describing the payment configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Methods** | **Collection&lt;CheckoutPostRequestPayment.MethodsEnum&gt;** | The available methods are different according to the chosen payment type:  Available for single, frequent or subscription payment type:  * &#39;CC&#39; (Credit Card) * &#39;DD&#39; (Direct Debit)  Available for single or frequent payment type: * &#39;MBW&#39; (MB WAY)  * &#39;AP&#39; (Apple Pay)  * &#39;GP&#39; (Google Pay)  * &#39;MB&#39; (Multibanco)  * &#39;VI&#39; (Virtual IBAN)  * &#39;UF&#39; (Universo Flex)  * &#39;SC&#39; (Santander Consumer)  * &#39;AP&#39; (Apple Pay) | 
**Type** | **string** | The type of payment for Credit Card and MB WAY operations. | [optional] [default to TypeEnum.Sale]
**Capture** | [**CheckoutPostRequestPaymentCapture**](CheckoutPostRequestPaymentCapture.md) |  | [optional] 
**ExpirationTime** | **string** | The last possible time to make the payment. Applicable in Multibanco payments.  Note: If the expiration time is less than the default checkout session expiration (which is 30 minutes),&lt;/br&gt; the user won&#39;t be able to interact with the Checkout after that time. | [optional] 
**Currency** | **Currency** |  | [optional] 
**Key** | **string** | The merchant&#39;s key for identifying the payment. | [optional] 
**MaxValue** | **double** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for frequent payments.&lt;/font&gt; | [optional] 
**MinValue** | **double** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for frequent payments.&lt;/font&gt; | [optional] 
**UnlimitedPayments** | **bool** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for frequent payments.&lt;/font&gt;  Unlimited transactions.&lt;/br&gt;Uses &#39;max_value&#39; and &#39;min_value&#39; as limits per transaction instead. | [optional] [default to true]
**Frequency** | **string** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Required property for subscription payments.&lt;/font&gt; | [optional] 
**MaxCaptures** | **int** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for subscription payments.&lt;/font&gt;  Number of payments (required when no expiration_time is set). | [optional] 
**StartTime** | **string** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Required property for subscription payments.&lt;/font&gt;  Defining the start of billing cycles. | [optional] 
**Failover** | **bool** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for subscription payments.&lt;/font&gt;  After all retries failed, the payment cycle can have another try with another single method. | [optional] [default to false]
**CaptureNow** | **bool** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for subscription payments.&lt;/font&gt;  Whether to schedule an immediate capture and schedule the second one for start_time. | [optional] [default to false]
**Retries** | **decimal** | &lt;font color&#x3D;\&quot;#FF0000\&quot;&gt;Additional property for subscription payments.&lt;/font&gt;  Number of retries in each payment cycle.&lt;/br&gt; The chosen frequency will define the max number of possible retries. | [optional] [default to 0M]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

