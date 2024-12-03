# Easypay.Rest.Client.Model.SubscriptionIdPatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The Payment Status. | [optional] 
**Capture** | [**SubscriptionPostRequestCapture**](SubscriptionPostRequestCapture.md) |  | [optional] 
**ExpirationTime** | **string** | Required only when no max_captures is set.&lt;/br&gt;The last possible time to make the payment. | [optional] 
**Currency** | **Currency** |  | [optional] 
**Customer** | [**SubscriptionIdPatchRequestCustomer**](SubscriptionIdPatchRequestCustomer.md) |  | [optional] 
**Key** | **string** | The merchant&#39;s key for identifying the payment. | [optional] 
**Value** | **double** | The payment value.&lt;/br&gt;Will be rounded to 2 decimals. | [optional] 
**Frequency** | **string** |  | [optional] 
**MaxCaptures** | **int** | Required when no expiration_time is set.&lt;/br&gt;Number of payments. | [optional] 
**StartTime** | **string** | Defining the start of billing cycles. | [optional] 
**Failover** | **bool** | After all retries failed, the payment cycle can have another try with another single method. | [optional] [default to false]
**Retries** | **int** | Number of retries in each payment cycle.&lt;/br&gt; The chosen frequency will define the max number of possible retries. | [optional] [default to 0]
**SddMandate** | [**SddMandate**](SddMandate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

