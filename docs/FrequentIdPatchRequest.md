# Easypay.Rest.Client.Model.FrequentIdPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** |  | [optional] 
**ExpirationTime** | **string** |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Key** | **string** | The merchant&#39;s key for identifying the payment. | [optional] 
**MaxValue** | **double** |  | [optional] 
**MinValue** | **double** |  | [optional] 
**UnlimitedPayments** | **bool** | Transactions will be unlimited, max or min value will be refreshed on each payment. | [optional] [default to true]
**SddMandate** | [**SddMandate**](SddMandate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

