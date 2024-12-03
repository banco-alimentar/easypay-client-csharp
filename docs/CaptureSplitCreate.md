# Easypay.Rest.Client.Model.CaptureSplitCreate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SplitKey** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**SplitDescriptive** | **string** | A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;. | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | 
**Account** | [**SplitAccount**](SplitAccount.md) | The account to which the funds should be routed. This field is used to specify the destination account for the split payment, ensuring that the correct recipient receives their designated portion of the funds. | 
**MarginValue** | **double** | The monetary amount designated as the margin in a split payment. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;10.00\&quot;). The value must be less than the total value of the split. This specifies the portion of the funds that should be routed to the margin account. | [optional] 
**MarginAccount** | [**MarginAccount**](MarginAccount.md) |  | [optional] 
**ClearingPeriod** | **string** | The clearing period must follow the format 1Y, 10W or 30D. Y for Years, W for weeks, D for days. Minimum is 7 days, maximum is 1 year. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

