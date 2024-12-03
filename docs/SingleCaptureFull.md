# Easypay.Rest.Client.Model.SingleCaptureFull
The Capture object contains all the necessary information for executing a fund capture action. It defines how and where the funds should be routed upon capturing a transaction. This object is essential for finalizing transactions and ensuring the correct allocation of funds.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | 
**Status** | **CaptureStatus** |  | 
**Descriptive** | **string** | A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;. | 
**TransactionKey** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**CaptureDate** | **DateOnly** | The date when the action should be executed. This field specifies the exact day for capturing the transaction, formatted as \&quot;YYYY-MM-DD\&quot; (e.g., \&quot;2024-06-30\&quot;). It is optional and defaults to the current date if not specified. | [optional] 
**Account** | [**CaptureAccount**](CaptureAccount.md) |  | [optional] 
**Splits** | [**Collection&lt;CaptureSplit&gt;**](CaptureSplit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

