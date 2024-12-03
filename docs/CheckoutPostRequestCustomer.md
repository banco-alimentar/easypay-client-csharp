# Easypay.Rest.Client.Model.CheckoutPostRequestCustomer
The customer details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The uuid of a previously created customer. | [optional] 
**Name** | **string** | Required if payment.method is &#39;MBW&#39;&lt;/br&gt;The customer&#39;s name. | [optional] 
**Email** | **string** | The customer&#39;s email. | 
**Phone** | **string** | Required if payment.method is &#39;MBW&#39;&lt;/br&gt;The customer&#39;s phone number. | [optional] 
**PhoneIndicative** | **string** | The phone country code. | [optional] 
**FiscalNumber** | **string** | The customer&#39;s fiscal number (prefixed by the country code). | [optional] 
**Key** | **string** | The merchant&#39;s key to identify the customer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

