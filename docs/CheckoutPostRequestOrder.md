# Easypay.Rest.Client.Model.CheckoutPostRequestOrder
Order represent the order/cart being paid. Order is required if type is one single or subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Items** | [**Collection&lt;CheckoutPostRequestOrderItemsInner&gt;**](CheckoutPostRequestOrderItemsInner.md) |  | [optional] 
**Key** | **string** | The merchant&#39;s key to identify the order. | [optional] 
**Value** | **decimal** | The price being paid for the entire order, rounded to 2 decimals. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

