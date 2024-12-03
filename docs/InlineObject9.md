# Easypay.Rest.Client.Model.InlineObject9

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | [optional] 
**CreatedAt** | **string** |  | [optional] 
**Key** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**Capture** | [**SingleCaptureFull**](SingleCaptureFull.md) |  | [optional] 
**Descriptive** | **string** | A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;. | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | [optional] 
**ExpirationTime** | **string** |  | [optional] 
**Currency** | **Currency** |  | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Method** | [**Method**](Method.md) |  | [optional] 
**PaidAt** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

