# Easypay.Rest.Client.Model.CaptureFull
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
**PaymentId** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | [optional] 
**PaymentType** | **PaymentTypes** |  | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | [optional] 
**Force3ds** | **bool** | A boolean field indicating whether to enforce 3D Secure (3DS) authentication for the transaction. If set to true, 3DS authentication will be required, adding an additional layer of security by verifying the cardholder&#39;s identity during the transaction process. If set to false, 3DS authentication will not be enforced. This field helps enhance security and reduce fraud in online payments. | [optional] 
**CreatedAt** | **string** | The timestamp indicating when the resource was created. It is formatted as \&quot;YYYY-MM-DD HH:MM\&quot;. | [optional] 
**UpdatedAt** | **string** | The timestamp indicating when the resource was updated. It is formatted as \&quot;YYYY-MM-DD HH:MM\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

