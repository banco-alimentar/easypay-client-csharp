# Easypay.Rest.Client.Model.CheckoutPostRequestPaymentCapture
Required if the payment type is sale.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionKey** | **string** | The internal key used to identify this transaction in the merchant&#39;s database. | [optional] 
**CaptureDate** | **DateOnly** | The capture date. | [optional] 
**Account** | [**CaptureIdPostRequestAccount**](CaptureIdPostRequestAccount.md) |  | [optional] 
**Splits** | [**Collection&lt;CheckoutPostRequestPaymentCaptureSplitsInner&gt;**](CheckoutPostRequestPaymentCaptureSplitsInner.md) | Used in split payments. | [optional] 
**Descriptive** | **string** | Required if the payment method is &#39;MBW&#39;.&lt;/br&gt; The description of the capture. Will be displayed in the bank statement or in the MB WAY application. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

