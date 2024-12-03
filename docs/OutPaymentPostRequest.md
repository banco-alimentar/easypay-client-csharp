# Easypay.Rest.Client.Model.OutPaymentPostRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Customer** | [**CustomerCreateOrUpdate**](CustomerCreateOrUpdate.md) |  | 
**Key** | **string** | Merchant identification key | [optional] 
**Value** | **double** | Value will be rounded to 2 decimals | 
**Type** | **string** | Optional - only applicable to method transfer | [optional] [default to TypeEnum.Normal]
**ScheduleAt** | **DateTime** | Schedule date to execute the payment | [optional] 
**Descriptive** | **string** |  | [optional] 
**Account** | [**Account**](Account.md) |  | [optional] 
**OutAccount** | [**OutAccount**](OutAccount.md) |  | 
**Method** | **string** |  | [default to "transfer"]
**Timestamp** | **string** | Unix timestamp UTC, must be no more than 1 minute before or after real time, if not the strong authentication signature will not be valid | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

