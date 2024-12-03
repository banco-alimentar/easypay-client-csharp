# Easypay.Rest.Client.Model.Fee
  An object that represents a set of amounts in different categories such as fixed, variable, and VAT,   each with an associated currency. The structure includes:   - **fixed_amount**: Represents a fixed fee applied to the transaction.   - **variable_amount**: Represents a variable fee, usually dependent on the transaction amount.   - **vat_amount**: Represents the value-added tax (VAT) applied to the fees.   All amounts are represented in a specific currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FixedAmount** | [**Money**](Money.md) | The fixed fee amount applied to a transaction. | [optional] 
**VariableAmount** | [**Money**](Money.md) | The variable fee amount applied to this transaction | [optional] 
**VatAmount** | [**Money**](Money.md) | The vat amount applied to this transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

