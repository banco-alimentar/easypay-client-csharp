# Easypay.Rest.Client.Model.UpdatableCustomer
The Customer object contains detailed information about the customer involved in the transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The full name of the customer. This field is used to identify the customer and personalize interactions. It typically includes the customer&#39;s first name and last name. | [optional] 
**Email** | **string** | The email address of the customer. This field is used for communication purposes, including sending transaction confirmations, receipts, and other notifications related to the customer&#39;s activities. | [optional] 
**Phone** | **string** | The contact phone number of the customer, excluding the country code indicator (e.g., \&quot;+351\&quot;). This field is used for communication purposes. If the payment method is MBWAY, the phone_number is required and is used to send the MBWAY push notification. | [optional] 
**PhoneIndicative** | **string** | The country code indicator for the customer&#39;s phone number (e.g., \&quot;351\&quot; for Portugal). This field is used in conjunction with the phone number to ensure proper international dialing and communication. | [optional] [default to "351"]
**FiscalNumber** | **string** | The customer&#39;s fiscal number (prefixed by the country code). | [optional] 
**Key** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**Language** | **string** | The language preference of the customer, specified in the ISO 639-1 Alpha-2 format (e.g., \&quot;EN\&quot; for English, \&quot;PT\&quot; for Portuguese). This field is used to indicate the customer&#39;s preferred language for communication and documentation.  | [optional] [default to "PT"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

