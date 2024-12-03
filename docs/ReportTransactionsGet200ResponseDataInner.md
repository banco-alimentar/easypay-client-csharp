# Easypay.Rest.Client.Model.ReportTransactionsGet200ResponseDataInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] 
**Key** | **string** | Any value that will help the merchant manage the transaction on his database. | [optional] 
**Date** | **DateTime** |  | [optional] 
**Values** | [**ReportTransactionsGet200ResponseDataInnerValues**](ReportTransactionsGet200ResponseDataInnerValues.md) |  | [optional] 
**TransferDate** | **DateOnly** |  | [optional] 
**TransferBatch** | **string** | The batch where this transaction has transfered. | [optional] 
**Method** | **string** | The payment method. | [optional] 
**DocumentNumber** | **string** | Unique document number used for Easypay Invoice. | [optional] 
**PaymentType** | **string** |  | [optional] 
**PaymentId** | **Guid** |  | [optional] 
**PaymentAccount** | [**FrequentPost201ResponseCustomer**](FrequentPost201ResponseCustomer.md) |  | [optional] 
**PaymentKey** | **string** |  | [optional] 
**PaymentTransactionKey** | **string** | Capture transaction key. | [optional] 
**Descriptive** | **string** | Any descriptive information that will help the merchant manage the transaction on his database. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

