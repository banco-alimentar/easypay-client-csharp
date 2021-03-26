# Easypay.Rest.Client.Model.SinglePaymentUpdateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationTime** | **string** | Optional | [optional] 
**Currency** | **string** |  | [optional] [default to CurrencyEnum.EUR]
**Customer** | [**SinglePaymentUpdateRequestCustomer**](SinglePaymentUpdateRequestCustomer.md) |  | [optional] 
**Key** | **string** | Merchant identification key | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals | [optional] 
**Type** | **string** | Optional - only applicable to method cc or mbw | [optional] [default to TypeEnum.Sale]
**Method** | **string** |  | [optional] 
**Account** | [**SinglePaymentUpdateRequestAccount**](SinglePaymentUpdateRequestAccount.md) |  | [optional] 
**SddMandate** | [**SinglePaymentUpdateRequestSddMandate**](SinglePaymentUpdateRequestSddMandate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

