# Easypay.Rest.Client.Model.SinglePostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **OperationType** |  | [optional] 
**Capture** | [**CreateCapture**](CreateCapture.md) |  | [optional] 
**ExpirationTime** | **string** | The last possible time to make the payment. Applicable in Multibanco payments. This field is deprecated, use multibanco.expiration_time instead. | [optional] 
**Currency** | **Currency** |  | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | 
**Method** | **SinglePaymentMethods** |  | 
**Key** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**Customer** | [**Customer**](Customer.md) |  | [optional] 
**Multibanco** | [**SinglePostRequestMultibanco**](SinglePostRequestMultibanco.md) |  | [optional] 
**SddMandate** | [**CreateSddMandate**](CreateSddMandate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

