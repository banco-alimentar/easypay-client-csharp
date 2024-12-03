# Easypay.Rest.Client.Api.ReportsApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ReportLedgerGet**](ReportsApi.md#reportledgerget) | **GET** /report/ledger | Report Ledger |
| [**ReportTransactionsGet**](ReportsApi.md#reporttransactionsget) | **GET** /report/transactions | Report Transactions |

<a id="reportledgerget"></a>
# **ReportLedgerGet**
> InlineObject2 ReportLedgerGet (string? cursor = null, decimal? limit = null, string? createdAt = null, string? transactionType = null, string? transferBatch = null)

Report Ledger

The /reports/ledger endpoint provides access to detailed reports of ledger entries within the Easypay reconciliation system. This endpoint retrieves comprehensive financial data for each transaction recorded in the ledger, including captures, refunds, fees, and other financial operations, and it was designed to help users generate precise and relevant financial reports, aiding in effective account reconciliation and financial management.  By using this endpoint, clients can obtain an itemized list of all ledger entries, including relevant financial details such as transaction amounts, fees, taxes, and net transferred amounts. The data returned by this endpoint is ideal for accounting, auditing, and financial analysis purposes, as it ensures transparency and accuracy in financial reporting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class ReportLedgerGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.easypay.pt/2.0";
            // Configure API key authorization: accountId
            config.AddApiKey("AccountId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccountId", "Bearer");
            // Configure API key authorization: apiKey
            config.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new ReportsApi(config);
            var cursor = "cursor_example";  // string? | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. (optional) 
            var limit = 100MD;  // decimal? | The maximum number of records to return in a single response. This value determines how many items are included in each page of the results. The default value is 100, and the maximum allowable limit is 100. If not specified, the default limit will be used. Adjust the limit to control the size of the response and manage the data load for each request. (optional)  (default to 100M)
            var createdAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 
            var transactionType = CP;  // string? | Filter by **LedgerTransactionType** (optional) 
            var transferBatch = 584;  // string? | Filter by **LedgerTransferBatch** (optional) 

            try
            {
                // Report Ledger
                InlineObject2 result = apiInstance.ReportLedgerGet(cursor, limit, createdAt, transactionType, transferBatch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportLedgerGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportLedgerGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Ledger
    ApiResponse<InlineObject2> response = apiInstance.ReportLedgerGetWithHttpInfo(cursor, limit, createdAt, transactionType, transferBatch);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportsApi.ReportLedgerGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string?** | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. | [optional]  |
| **limit** | **decimal?** | The maximum number of records to return in a single response. This value determines how many items are included in each page of the results. The default value is 100, and the maximum allowable limit is 100. If not specified, the default limit will be used. Adjust the limit to control the size of the response and manage the data load for each request. | [optional] [default to 100M] |
| **createdAt** | **string?** | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |
| **transactionType** | **string?** | Filter by **LedgerTransactionType** | [optional]  |
| **transferBatch** | **string?** | Filter by **LedgerTransferBatch** | [optional]  |

### Return type

[**InlineObject2**](InlineObject2.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, multipart/form-data, text/html, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **403** | Forbidden |  -  |
| **412** | Precondition Failed |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reporttransactionsget"></a>
# **ReportTransactionsGet**
> ReportTransactionsGet200Response ReportTransactionsGet (string? startDate = null, string? endDate = null, decimal? page = null, decimal? recordsPerPage = null)

Report Transactions

List your transactions

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class ReportTransactionsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.easypay.pt/2.0";
            // Configure API key authorization: accountId
            config.AddApiKey("AccountId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccountId", "Bearer");
            // Configure API key authorization: apiKey
            config.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new ReportsApi(config);
            var startDate = "startDate_example";  // string? | Filter from this date (optional) 
            var endDate = "endDate_example";  // string? | Filter until this date (optional) 
            var page = 8.14D;  // decimal? | Page Number (optional) 
            var recordsPerPage = 20MD;  // decimal? | Limit records per page (Max: 2500) (optional)  (default to 20M)

            try
            {
                // Report Transactions
                ReportTransactionsGet200Response result = apiInstance.ReportTransactionsGet(startDate, endDate, page, recordsPerPage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportsApi.ReportTransactionsGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReportTransactionsGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Report Transactions
    ApiResponse<ReportTransactionsGet200Response> response = apiInstance.ReportTransactionsGetWithHttpInfo(startDate, endDate, page, recordsPerPage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ReportsApi.ReportTransactionsGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **startDate** | **string?** | Filter from this date | [optional]  |
| **endDate** | **string?** | Filter until this date | [optional]  |
| **page** | **decimal?** | Page Number | [optional]  |
| **recordsPerPage** | **decimal?** | Limit records per page (Max: 2500) | [optional] [default to 20M] |

### Return type

[**ReportTransactionsGet200Response**](ReportTransactionsGet200Response.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **412** | Precondition Failed |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

