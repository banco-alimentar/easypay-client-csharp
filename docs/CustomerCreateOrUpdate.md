# Easypay.Rest.Client.Model.CustomerCreateOrUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Optional - uuid from previous created customer, if and id is provided the other properties will do an upsert.  | [optional] 
**Name** | **string** | Name of the customer | 
**Email** | **string** | The email of the customer | 
**Phone** | **string** |  | 
**PhoneIndicative** | **string** |  | [optional] [default to "+351"]
**FiscalNumber** | **string** | Fiscal Number must be prefixed with country code | [optional] 
**Key** | **string** |  | [optional] 
**Language** | **string** | ISO Alpha-2 code | [optional] [default to "PT"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

