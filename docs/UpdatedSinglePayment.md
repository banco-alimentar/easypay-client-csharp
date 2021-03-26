# Easypay.Rest.Client.Model.UpdatedSinglePayment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**ExpirationTime** | **string** | Optional | [optional] 
**Currency** | **string** |  | [optional] [default to CurrencyEnum.EUR]
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Key** | **string** | Merchant identification key | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals | [optional] 
**Type** | **string** | Optional - only applicable to method cc or mbw | [optional] [default to TypeEnum.Sale]
**Method** | [**UpdatedSinglePaymentMethod**](UpdatedSinglePaymentMethod.md) |  | [optional] 
**PaymentStatus** | **string** | Status of the single payment | [optional] 
**PaidAt** | **string** | Date when the single payment was paid | [optional] 
**CreatedAt** | **string** | Date when payment was created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

