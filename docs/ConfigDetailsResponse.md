# Easypay.Rest.Client.Model.ConfigDetailsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Generic** | **string** | URL for generic notification | [optional] [default to "https://www.easypay.pt/generic"]
**Authorisation** | **string** | URL for authorisation notification | [optional] [default to "https://www.easypay.pt/authorisation"]
**Transaction** | **string** | URL for transaction notification | [optional] [default to "https://www.easypay.pt/transaction"]
**VisaFwd** | **string** | URL for redirect clients on credit card forward | [optional] [default to "https://www.easypay.pt/visa_fwd"]
**VisaDetail** | **string** | URL for credit card payment detail | [optional] [default to "https://www.easypay.pt/visa_detail"]
**Account** | **string** | easypay account UUID | [optional] [default to "b2080452-bad1-4455-8ae7-9f5ea552a274"]
**PaymentMethods** | **Collection&lt;string&gt;** | payment methods allowed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

