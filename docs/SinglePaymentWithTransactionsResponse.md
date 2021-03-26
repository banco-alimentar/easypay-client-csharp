# Easypay.Rest.Client.Model.SinglePaymentWithTransactionsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Transactions** | [**Collection&lt;PaymentSingleTransaction&gt;**](PaymentSingleTransaction.md) |  | [optional] 
**Type** | **string** | Optional - only applicable to method cc or mbw | [optional] [default to TypeEnum.Sale]
**Id** | **Guid** |  | [optional] 
**ExpirationTime** | **string** |  | [optional] 
**Currency** | **string** |  | [optional] [default to CurrencyEnum.EUR]
**Customer** | [**SinglePaymentUpdateRequestCustomer**](SinglePaymentUpdateRequestCustomer.md) |  | [optional] 
**Key** | **string** | Merchant identification key | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals | [optional] 
**Method** | [**PaymentSingleMethod**](PaymentSingleMethod.md) |  | [optional] 
**PaymentStatus** | **string** | Status of the single payment | [optional] 
**PaidAt** | **string** | Date when the single payment was paid | [optional] 
**CreatedAt** | **string** | Date when payment was created | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

