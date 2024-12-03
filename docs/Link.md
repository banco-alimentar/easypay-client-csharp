# Easypay.Rest.Client.Model.Link

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**ExpirationTime** | **DateTime** |  | [optional] 
**Type** | **PayByLinkPaymentTypes** |  | [optional] 
**Customer** | [**PayByLinkCustomer**](PayByLinkCustomer.md) |  | [optional] 
**CommunicationChannels** | **Collection&lt;Link.CommunicationChannelsEnum&gt;** | the communication channels to where the final customer link should be forwarded | [optional] 
**Payment** | [**LinkPayment**](LinkPayment.md) |  | [optional] 
**Url** | **string** |  | [optional] 
**Image** | **string** |  | [optional] 
**Status** | **Status** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

