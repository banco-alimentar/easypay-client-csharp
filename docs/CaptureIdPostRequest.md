# Easypay.Rest.Client.Model.CaptureIdPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionKey** | **string** | Your internal key identifying this capture. | [optional] 
**CaptureDate** | **DateOnly** |  | [optional] 
**Account** | [**CaptureIdPostRequestAccount**](CaptureIdPostRequestAccount.md) |  | [optional] 
**Splits** | [**Collection&lt;CaptureIdPostRequestSplitsInner&gt;**](CaptureIdPostRequestSplitsInner.md) | Used in split payments. | [optional] 
**MbwaySdk** | [**MbwaySdk**](MbwaySdk.md) |  | [optional] 
**Force3ds** | **bool** | Whether or not you want to force the 3DS authentication on Credit Cards (used only on Frequent capture without authorisation). | [optional] [default to false]
**Descriptive** | **string** | This will appear in the bank statement/mbway application. | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals. | 
**Currency** | **Currency** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

