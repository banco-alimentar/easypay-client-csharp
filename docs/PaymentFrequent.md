# Easypay.Rest.Client.Model.PaymentFrequent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**CreatedAt** | **string** | Date when payment was created | [optional] 
**Descriptive** | **string** | This will appear in the bank statement/mbway application | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals | 
**ExpirationTime** | **string** | Optional | [optional] 
**Currency** | **Currency** |  | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Key** | **string** | Merchant identification key | [optional] 
**MaxValue** | **double** | Value will be rounded to 2 decimals | [optional] 
**MinValue** | **double** | Value will be rounded to 2 decimals | [optional] 
**UnlimitedPayments** | **bool** | Transactions will be unlimited, max or min value will be refreshed on each payment | [optional] [default to true]
**Method** | [**PaymentFrequentMethodResponseMethod**](PaymentFrequentMethodResponseMethod.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

