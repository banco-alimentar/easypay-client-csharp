# Easypay.Rest.Client.Model.LedgerEntryDetails
An object containing detailed information about a specific operation and payment.     This includes unique identifiers, the method used for the payment, and the type of payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OperationId** | **string** | A unique identifier for the operation, represented as a UUID. | [optional] 
**OperationKey** | **string** | A merchant-specific identification key for the operation. | [optional] 
**Method** | **string** | The payment method used for the transaction (e.g., CC for credit card). | [optional] 
**PaymentId** | **string** | A unique identifier for the payment, represented as a UUID. | [optional] 
**PaymentType** | **string** | The type of payment, such as &#39;single&#39; for a one-time payment. | [optional] 
**PaymentKey** | **string** |  A merchant-specific identification key for the payment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

