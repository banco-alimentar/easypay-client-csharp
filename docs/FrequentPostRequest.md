# Easypay.Rest.Client.Model.FrequentPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationTime** | **string** |  | [optional] 
**Currency** | **string** |  | [optional] [default to CurrencyEnum.EUR]
**Customer** | [**Customer**](Customer.md) |  | 
**Key** | **string** | The merchant&#39;s key for identifying the payment. | [optional] 
**MinValue** | **double** |  | 
**MaxValue** | **double** |  | 
**UnlimitedPayments** | **bool** | Transactions will be unlimited, max or min value will be refreshed on each payment. | [optional] [default to true]
**Method** | **string** |  | 
**SddMandate** | [**SddMandate**](SddMandate.md) |  | [optional] 
**Multibanco** | [**FrequentPostRequestMultibanco**](FrequentPostRequestMultibanco.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

