# Easypay.Rest.Client.Model.CaptureStatus
Indicates the current status of the capture. Possible values include: - delayed: The capture attempt is scheduled for a future date and does not require further user interaction due to prior consent (e.g., authorization or frequent). - waiting: The payment instruction has been given, but the chosen payment method requires confirmation from an external entity before the status of the operation is finalized. - pending: The capture is pending user completion. - success: The capture has been completed successfully. - failed: The capture could not be completed due to an error or issue. - refunded: The capture has been refunded.  This field provides a clear indication of the current state of the capture, helping users understand its progress and outcome.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

