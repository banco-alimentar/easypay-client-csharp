# Easypay.Rest.Client.Model.FrequentMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**Url** | **string** | Only returns if the payment is a Credit Card. | [optional] 
**LastFour** | **string** | Only returns if the payment is a Credit Card.&lt;/br&gt;Last 4 digits of the submitted Credit Card.  | [optional] 
**CardType** | **string** | Only returns if the payment is a Credit Card. | [optional] 
**ExpirationDate** | **string** | Only returns if the payment is a Credit Card. | [optional] 
**Iban** | **string** | Virtual IBAN | [optional] 
**Alias** | **string** | MB WAY Alias (only for mobile implementation using MBWAY SDK). | [optional] 
**SddMandate** | [**FrequentMethodSddMandate**](FrequentMethodSddMandate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

