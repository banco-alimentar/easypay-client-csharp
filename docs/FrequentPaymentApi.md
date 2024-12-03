# Easypay.Rest.Client.Api.FrequentPaymentApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FrequentAuthorisation**](FrequentPaymentApi.md#frequentauthorisation) | **POST** /frequent/authorisation/{id} | Request Authorisation |
| [**FrequentGet**](FrequentPaymentApi.md#frequentget) | **GET** /frequent | Lists frequent payments |
| [**FrequentIdDelete**](FrequentPaymentApi.md#frequentiddelete) | **DELETE** /frequent/{id} | Deletes frequent payment |
| [**FrequentIdGet**](FrequentPaymentApi.md#frequentidget) | **GET** /frequent/{id} | Shows frequent payment details |
| [**FrequentIdPatch**](FrequentPaymentApi.md#frequentidpatch) | **PATCH** /frequent/{id} | Updates frequent payment details |
| [**FrequentPost**](FrequentPaymentApi.md#frequentpost) | **POST** /frequent | Create frequent payment |

<a id="frequentauthorisation"></a>
# **FrequentAuthorisation**
> FrequentAuthorisation201Response FrequentAuthorisation (Guid id, FrequentAuthorisationRequest frequentAuthorisationRequest)

Request Authorisation

Create a new authorisation on a given Frequent Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class FrequentAuthorisationExample
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

            var apiInstance = new FrequentPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification
            var frequentAuthorisationRequest = new FrequentAuthorisationRequest(); // FrequentAuthorisationRequest | Payment configuration object to generate a payment

            try
            {
                // Request Authorisation
                FrequentAuthorisation201Response result = apiInstance.FrequentAuthorisation(id, frequentAuthorisationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FrequentPaymentApi.FrequentAuthorisation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FrequentAuthorisationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request Authorisation
    ApiResponse<FrequentAuthorisation201Response> response = apiInstance.FrequentAuthorisationWithHttpInfo(id, frequentAuthorisationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FrequentPaymentApi.FrequentAuthorisationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |
| **frequentAuthorisationRequest** | [**FrequentAuthorisationRequest**](FrequentAuthorisationRequest.md) | Payment configuration object to generate a payment |  |

### Return type

[**FrequentAuthorisation201Response**](FrequentAuthorisation201Response.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **412** | Precondition Failed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="frequentget"></a>
# **FrequentGet**
> FrequentGet200Response FrequentGet (decimal? page = null, decimal? recordsPerPage = null, string? expirationTime = null, string? method = null, string? customer = null, string? id = null, string? key = null, string? createdAt = null)

Lists frequent payments

Full report with all the frequent payments from your Account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class FrequentGetExample
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

            var apiInstance = new FrequentPaymentApi(config);
            var page = 8.14D;  // decimal? | Page Number (optional) 
            var recordsPerPage = 20MD;  // decimal? | Limit records per page (Max: 100) (optional)  (default to 20M)
            var expirationTime = "expirationTime_example";  // string? | Filter by expiration time interval (max 30 days) (optional) 
            var method = "method_example";  // string? | Filter by method (optional) 
            var customer = "customer_example";  // string? | Filter by customer key (optional) 
            var id = "id_example";  // string? | Filter by id (optional) 
            var key = "key_example";  // string? | Filter by frequent key (optional) 
            var createdAt = "createdAt_example";  // string? | Filter by created datetime interval (max 30 days) (optional) 

            try
            {
                // Lists frequent payments
                FrequentGet200Response result = apiInstance.FrequentGet(page, recordsPerPage, expirationTime, method, customer, id, key, createdAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FrequentPaymentApi.FrequentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FrequentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists frequent payments
    ApiResponse<FrequentGet200Response> response = apiInstance.FrequentGetWithHttpInfo(page, recordsPerPage, expirationTime, method, customer, id, key, createdAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FrequentPaymentApi.FrequentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal?** | Page Number | [optional]  |
| **recordsPerPage** | **decimal?** | Limit records per page (Max: 100) | [optional] [default to 20M] |
| **expirationTime** | **string?** | Filter by expiration time interval (max 30 days) | [optional]  |
| **method** | **string?** | Filter by method | [optional]  |
| **customer** | **string?** | Filter by customer key | [optional]  |
| **id** | **string?** | Filter by id | [optional]  |
| **key** | **string?** | Filter by frequent key | [optional]  |
| **createdAt** | **string?** | Filter by created datetime interval (max 30 days) | [optional]  |

### Return type

[**FrequentGet200Response**](FrequentGet200Response.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="frequentiddelete"></a>
# **FrequentIdDelete**
> void FrequentIdDelete (Guid id)

Deletes frequent payment

3 times a day (10am, 3pm and 10pm) our system will attempt to close your deleted MB payments.<br>All CC and MBW authorisations will be deleted, releasing the funds.<br>All MBW operations waiting for user interaction will be cancelled.<br>Before 6pm all Sepa Direct Debits waiting for file processing will be cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class FrequentIdDeleteExample
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

            var apiInstance = new FrequentPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Deletes frequent payment
                apiInstance.FrequentIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FrequentPaymentApi.FrequentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FrequentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes frequent payment
    apiInstance.FrequentIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FrequentPaymentApi.FrequentIdDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

void (empty response body)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="frequentidget"></a>
# **FrequentIdGet**
> Frequent FrequentIdGet (Guid id)

Shows frequent payment details

Retrieve a Frequent Payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class FrequentIdGetExample
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

            var apiInstance = new FrequentPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows frequent payment details
                Frequent result = apiInstance.FrequentIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FrequentPaymentApi.FrequentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FrequentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows frequent payment details
    ApiResponse<Frequent> response = apiInstance.FrequentIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FrequentPaymentApi.FrequentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**Frequent**](Frequent.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml, text/csv


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="frequentidpatch"></a>
# **FrequentIdPatch**
> FrequentIdPatch200Response FrequentIdPatch (Guid id, FrequentIdPatchRequest frequentIdPatchRequest)

Updates frequent payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class FrequentIdPatchExample
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

            var apiInstance = new FrequentPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification
            var frequentIdPatchRequest = new FrequentIdPatchRequest(); // FrequentIdPatchRequest | Frequent Payment object to edit existing one

            try
            {
                // Updates frequent payment details
                FrequentIdPatch200Response result = apiInstance.FrequentIdPatch(id, frequentIdPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FrequentPaymentApi.FrequentIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FrequentIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates frequent payment details
    ApiResponse<FrequentIdPatch200Response> response = apiInstance.FrequentIdPatchWithHttpInfo(id, frequentIdPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FrequentPaymentApi.FrequentIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |
| **frequentIdPatchRequest** | [**FrequentIdPatchRequest**](FrequentIdPatchRequest.md) | Frequent Payment object to edit existing one |  |

### Return type

[**FrequentIdPatch200Response**](FrequentIdPatch200Response.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="frequentpost"></a>
# **FrequentPost**
> FrequentPost201Response FrequentPost (FrequentPostRequest? frequentPostRequest = null)

Create frequent payment

Frequent payments are repeatable transactions of varying sums without the client having to enter their payment details again.  It is possible to limit the transferred sums by choosing minimum or maximum values, either to the total sum of the transactions or each individual transaction.  Supported methods for frequent payments are: <i style=\"color:red\">Credit Card, MB WAY, Multibanco, Direct Debit</i> and <i style=\"color:red\">Virtual IBAN</i> 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class FrequentPostExample
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

            var apiInstance = new FrequentPaymentApi(config);
            var frequentPostRequest = new FrequentPostRequest?(); // FrequentPostRequest? |  (optional) 

            try
            {
                // Create frequent payment
                FrequentPost201Response result = apiInstance.FrequentPost(frequentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FrequentPaymentApi.FrequentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FrequentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create frequent payment
    ApiResponse<FrequentPost201Response> response = apiInstance.FrequentPostWithHttpInfo(frequentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FrequentPaymentApi.FrequentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **frequentPostRequest** | [**FrequentPostRequest?**](FrequentPostRequest?.md) |  | [optional]  |

### Return type

[**FrequentPost201Response**](FrequentPost201Response.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **412** | Pre condition failed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

