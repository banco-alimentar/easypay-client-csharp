# Easypay.Rest.Client.Model.FinantialTransactionDetails
An object containing detailed financial information related to the transaction. Provides a breakdown of various components of the transaction, such as fees , requested and payed amounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestedAmount** | [**Money**](Money.md) | The amount requested by payee. | [optional] 
**PayedAmount** | [**Money**](Money.md) | The amount payed by payer. | [optional] 
**Fees** | [**Collection&lt;Fee&gt;**](Fee.md) | An array of fee objects, where each fee represents a specific charge or cost associated with a transaction.   Each fee includes details such as the amount and currency, and may represent different types of fees   like fixed, variable, or VAT. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

