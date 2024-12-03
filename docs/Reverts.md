# Easypay.Rest.Client.Model.Reverts
Reverts refers to the process of reversing a previously made split payment. This means that the amounts that were divided and allocated to different recipients or accounts are returned to the original payer or redistributed as per the new instructions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | [optional] 
**MarginValue** | **double** | The monetary amount designated as the margin in a split payment. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;10.00\&quot;). The value must be less than the total value of the split. This specifies the portion of the funds that should be routed to the margin account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

