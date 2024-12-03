# Easypay.Rest.Client.Model.Method

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** |  | 
**Status** | **string** |  | 
**SddMandate** | [**SddMandate**](SddMandate.md) |  | [optional] 
**CardType** | **string** | Indicates the type of credit card used for the payment (e.g., \&quot;Visa\&quot;, \&quot;MasterCard\&quot;). This field is only applicable for credit card transactions. | [optional] 
**LastFour** | **string** | The last four digits of the credit card number used for the payment. This field is only applicable for credit card transactions. | [optional] 
**ExpirationDate** | **string** |  | [optional] 
**Url** | **string** | The URL where the merchant should redirect the user to complete Credit Card Payments. This field is only applicable and available for credit card payment transactions. | [optional] 
**Alias** | **string** | A unique identifier for the user within the MBWay system, used to identify the user in the MBWay SDK. This field is only applicable and available for MBWay transactions. | [optional] 
**Entity** | **string** | The identifier for the Multibanco entity to which the payment should be routed. This field specifies the entity code required for processing the payment through the Multibanco network, ensuring that the payment is directed to the correct recipient. | [optional] 
**Reference** | **string** | The unique payment reference number issued for the specific Multibanco entity. This field is used by the end user to make a payment at an ATM or through home banking. It ensures that the payment is correctly attributed to the intended transaction and recipient. | [optional] 
**Iban** | **string** | The International Bank Account Number (IBAN) of the debtor&#39;s account. This field is used to uniquely identify the debtor&#39;s bank account across international borders, ensuring accurate and efficient processing of SEPA Direct Debit transactions. The IBAN is a standardized format that includes the country code, check digits, bank code, and account number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

