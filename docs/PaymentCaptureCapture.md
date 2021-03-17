# Easypay.Rest.Client.Model.PaymentCaptureCapture
Only required if 'type' is 'sale'
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Descriptive** | **string** | This will appear in the bank statement/mbway application | 
**TransactionKey** | **string** | Your internal key identifying this capture | [optional] 
**CaptureDate** | **string** |  | [optional] 
**Account** | [**PaymentCaptureCaptureAccount**](PaymentCaptureCaptureAccount.md) |  | [optional] 
**Splits** | [**Collection&lt;SplitsDetails&gt;**](SplitsDetails.md) | Optional: only used for split payments | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

