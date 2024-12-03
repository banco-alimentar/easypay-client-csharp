# Easypay.Rest.Client.Model.Money
The money type is a data structure used to represent a monetary value in a specific currency. It includes both the amount and the currency type to accurately define the value of money in various contexts, such as financial transactions, pricing, and accounting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **string** | Represents the numerical value of the money. The amount should be a string formatted to include up to two decimal places to accurately represent cents or subunits of currency. For example, \&quot;123.45\&quot; represents one hundred twenty-three units and forty-five subunits of the currency. | [optional] 
**Currency** | **string** | Indicates the type of currency associated with the amount. This should follow standard currency codes (ISO 4217), such as \&quot;USD\&quot; for US Dollar, \&quot;EUR\&quot; for Euro, or \&quot;JPY\&quot; for Japanese Yen, to specify which currency the amount is denominated in. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

