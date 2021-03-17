# Easypay.Rest.Client.Model.PaymentSingleRequestBody
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationTime** | **string** | Optional | [optional] 
**Currency** | **string** |  | [optional] [default to CurrencyEnum.EUR]
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Key** | **string** | Merchant identification key | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals | 
**Type** | **string** | Optional - only applicable to method cc or mbw | [optional] [default to TypeEnum.Sale]
**Method** | [**PaymentSingleMethodAvailable**](PaymentSingleMethodAvailable.md) |  | [optional] 
**SddMandate** | [**SddMandate**](SddMandate.md) |  | [optional] 
**Capture** | [**PaymentCaptureCapture**](PaymentCaptureCapture.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

