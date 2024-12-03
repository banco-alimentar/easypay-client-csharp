# Easypay.Rest.Client.Model.PostLinkRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExpirationTime** | **DateTime** | rfc3339 formatted time for the link expiration date. | [optional] 
**Type** | **PayByLinkPaymentTypes** |  | 
**Customer** | [**PayByLinkCustomer**](PayByLinkCustomer.md) |  | 
**CommunicationChannels** | **Collection&lt;PostLinkRequest.CommunicationChannelsEnum&gt;** | the communication channels to where the final customer link should be forwarded | [optional] 
**Payment** | [**PostLinkRequestPayment**](PostLinkRequestPayment.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

