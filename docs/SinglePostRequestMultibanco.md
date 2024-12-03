# Easypay.Rest.Client.Model.SinglePostRequestMultibanco
An object that holds the details specific to a Multibanco transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationTime** | **DateTime** | The end timestamp indicating the deadline by which the Multibanco Reference must be paid. It defines the final time within which the payment must be completed. The format follows RFC3339 (e.g., \&quot;2024-06-30T21:38:31Z\&quot;). | 
**StartTime** | **DateTime** | The starting timestamp indicating when the Multibanco Reference becomes valid for payment. It defines the initial time from which the payment can be made. The format follows RFC3339 (e.g., \&quot;2024-06-30T21:38:31Z\&quot;). This field is optional and defaults to the current timestamp if not specified, or if the sent value is in the past. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

