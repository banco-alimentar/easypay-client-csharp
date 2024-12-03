# Easypay.Rest.Client.Model.CaptureSplit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | 
**SplitKey** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**SplitDescriptive** | **string** | A text field that describes the transaction as it will appear on the end user&#39;s account statement. This is typically used to provide clear, recognizable information about the payment, such as \&quot;Payment of Invoice Nº 1982652\&quot; or \&quot;Ticket for Queen\&quot;. | [optional] 
**Account** | [**SplitAccount**](SplitAccount.md) |  | [optional] 
**Value** | **double** | The monetary amount requested for the transaction. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;100.00\&quot;). The value must be greater than or equal to 0.5. | 
**ClearingDate** | **DateOnly** | The clearing date refers to the specific date when a financial transaction is finalized and the funds are transferred from one account to another. This is the point at which the payment is officially completed and the amount is debited from the payer’s account and credited to the payee’s account. | [optional] 
**ClearingPeriod** | **string** | The clearing period must follow the format 1Y, 10W or 30D. Y for Years, W for weeks, D for days. Minimum is 7 days, maximum is 1 year. | [optional] 
**MarginAccount** | [**MarginAccount**](MarginAccount.md) |  | [optional] 
**MarginValue** | **double** | The monetary amount designated as the margin in a split payment. This field is formatted as a double, and will be rounded to two decimal places (e.g., \&quot;10.00\&quot;). The value must be less than the total value of the split. This specifies the portion of the funds that should be routed to the margin account. | [optional] 
**Status** | **string** | The status of the Split | 
**Reverts** | [**Collection&lt;Reverts&gt;**](Reverts.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

