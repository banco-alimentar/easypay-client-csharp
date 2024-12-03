# Easypay.Rest.Client.Model.CreateSddMandate
The SDD Mandate object contains the necessary fields to create a SEPA Direct Debit mandate. This object ensures that all required information is provided to authorize and process SEPA Direct Debit transactions. Object required when method is Direct Debit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | A unique identifier for the resource. While typically formatted as a UUID (Universally Unique Identifier), it can also be in other formats as defined by the user. This field ensures the resource can be distinctly recognized and referenced. | [optional] 
**Iban** | **string** | The International Bank Account Number (IBAN) of the debtor&#39;s account. This field is used to uniquely identify the debtor&#39;s bank account across international borders, ensuring accurate and efficient processing of SEPA Direct Debit transactions. The IBAN is a standardized format that includes the country code, check digits, bank code, and account number. | 
**Key** | **string** | A customizable text field for users to input their own identifier for the resource. This can be any string that helps the user uniquely identify or reference the resource in their own system. | [optional] 
**Name** | **string** | The full name of the individual or entity. This field is used to identify the person or organization involved in the transaction or mandate. | 
**Email** | **string** | The contact phone number of the individual or entity, including the country code indicator (e.g., \&quot;+351\&quot;). This field is used for communication purposes, such as contacting the individual for verification or support. | 
**Phone** | **string** | The contact phone number of the individual or entity, excluding the country code indicator (e.g., \&quot;+351\&quot;). This field is used for communication purposes, such as contacting the individual for verification or support. If the payment method is MBWAY, the phone number is required and is used to send the MBWAY push notification. | 
**AccountHolder** | **string** | The name of the person or entity that holds the bank account. This field is used to identify the owner of the bank account involved in the transaction, ensuring that the correct account is credited or debited. | 
**CountryCode** | **string** | The two-letter ISO 3166-1 alpha-2 country code representing the country of the individual or entity. This field is used to specify the country associated with the address or account, ensuring correct geographical identification. | [optional] 
**MaxNumDebits** | **string** | The maximum number of debits that can be made under the mandate. This field sets a limit on the number of transactions that can be processed, providing control and security over the usage of the direct debit mandate. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

