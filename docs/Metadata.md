# Easypay.Rest.Client.Model.Metadata
An object containing additional information about the response. It includes details that help manage and navigate the retrieved data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NextCursor** | **string** | Provides the cursor for the next set of records. This value should be used as the cursor parameter in subsequent requests to continue paginating through the data. If the cursor is an empty string or null, it indicates that there are no more results. To retrieve all available results, continue making subsequent requests until next_cursor is empty or null. | 
**Count** | **decimal** | The total number of records in the current response. This field indicates the number of items returned in the current set of results. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

