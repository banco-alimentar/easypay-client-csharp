# Easypay.Rest.Client.Model.ListRefundModel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | [optional] 
**Status** | **RefundStatus** |  | [optional] 
**TransactionKey** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | [optional] 
**Iban** | **string** | (Required for fallback): The International Bank Account Number of the account to which the refund will be sent. This field is used to uniquely identify the recipient&#39;s bank account across international borders. | [optional] 
**Email** | **string** | (Required for fallback): The email address of the account holder. This field is used for communication purposes, including sending notifications about the refund stat. | [optional] 
**Phone** | **string** | (Required for fallback): The contact phone number of the account holder, including the country code indicator (e.g., \&quot;+351\&quot;). This field is used for communication purposes, such as contacting the account holder for verification. | [optional] 
**AccountHolder** | **string** | (Required for fallback): The name of the person or entity that holds the bank account. This field ensures that the refund is directed to the correct recipient. | [optional] 
**Capture** | [**RefundScopedCapture**](RefundScopedCapture.md) |  | [optional] 
**CreatedAt** | **string** | The timestamp indicating when the resource was created. It is formatted as \&quot;YYYY-MM-DD HH:MM\&quot;. | [optional] 
**UpdatedAt** | **string** | The timestamp indicating when the resource was updated. It is formatted as \&quot;YYYY-MM-DD HH:MM\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

