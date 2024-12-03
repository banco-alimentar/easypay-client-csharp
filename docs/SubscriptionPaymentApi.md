# Easypay.Rest.Client.Api.SubscriptionPaymentApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SubscriptionGet**](SubscriptionPaymentApi.md#subscriptionget) | **GET** /subscription | List subscription payments |
| [**SubscriptionIdDelete**](SubscriptionPaymentApi.md#subscriptioniddelete) | **DELETE** /subscription/{id} | Deletes subscription payment |
| [**SubscriptionIdGet**](SubscriptionPaymentApi.md#subscriptionidget) | **GET** /subscription/{id} | Shows subscription payment details |
| [**SubscriptionIdPatch**](SubscriptionPaymentApi.md#subscriptionidpatch) | **PATCH** /subscription/{id} | Updates subscription payment details |
| [**SubscriptionPost**](SubscriptionPaymentApi.md#subscriptionpost) | **POST** /subscription | Create subscription payment |

<a id="subscriptionget"></a>
# **SubscriptionGet**
> SubscriptionGet200Response SubscriptionGet (decimal? page = null, decimal? recordsPerPage = null, string? expirationTime = null, string? method = null, string? customer = null, string? id = null, string? key = null, string? createdAt = null)

List subscription payments

Full report with all the subscriptions payments from your Account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SubscriptionGetExample
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

            var apiInstance = new SubscriptionPaymentApi(config);
            var page = 8.14D;  // decimal? | Page Number (optional) 
            var recordsPerPage = 20MD;  // decimal? | Limit records per page (Max: 100) (optional)  (default to 20M)
            var expirationTime = "expirationTime_example";  // string? | Filter by expiration time interval (max 30 days) (optional) 
            var method = "method_example";  // string? | Filter by method (optional) 
            var customer = "customer_example";  // string? | Filter by customer key (optional) 
            var id = "id_example";  // string? | Filter by id (optional) 
            var key = "key_example";  // string? | Filter by subscription key (optional) 
            var createdAt = "createdAt_example";  // string? | Filter by created datetime interval (max 30 days) (optional) 

            try
            {
                // List subscription payments
                SubscriptionGet200Response result = apiInstance.SubscriptionGet(page, recordsPerPage, expirationTime, method, customer, id, key, createdAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List subscription payments
    ApiResponse<SubscriptionGet200Response> response = apiInstance.SubscriptionGetWithHttpInfo(page, recordsPerPage, expirationTime, method, customer, id, key, createdAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionGetWithHttpInfo: " + e.Message);
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
| **key** | **string?** | Filter by subscription key | [optional]  |
| **createdAt** | **string?** | Filter by created datetime interval (max 30 days) | [optional]  |

### Return type

[**SubscriptionGet200Response**](SubscriptionGet200Response.md)

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

<a id="subscriptioniddelete"></a>
# **SubscriptionIdDelete**
> void SubscriptionIdDelete (Guid id)

Deletes subscription payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SubscriptionIdDeleteExample
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

            var apiInstance = new SubscriptionPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Deletes subscription payment
                apiInstance.SubscriptionIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes subscription payment
    apiInstance.SubscriptionIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionIdDeleteWithHttpInfo: " + e.Message);
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

<a id="subscriptionidget"></a>
# **SubscriptionIdGet**
> SubscriptionIdGet200Response SubscriptionIdGet (Guid id)

Shows subscription payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SubscriptionIdGetExample
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

            var apiInstance = new SubscriptionPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows subscription payment details
                SubscriptionIdGet200Response result = apiInstance.SubscriptionIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows subscription payment details
    ApiResponse<SubscriptionIdGet200Response> response = apiInstance.SubscriptionIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**SubscriptionIdGet200Response**](SubscriptionIdGet200Response.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


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

<a id="subscriptionidpatch"></a>
# **SubscriptionIdPatch**
> SubscriptionIdPatch200Response SubscriptionIdPatch (Guid id, SubscriptionIdPatchRequest body)

Updates subscription payment details

Retrieves the subscription payment details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SubscriptionIdPatchExample
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

            var apiInstance = new SubscriptionPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification
            var body = new SubscriptionIdPatchRequest(); // SubscriptionIdPatchRequest | Subscription Payment object to edit existing one

            try
            {
                // Updates subscription payment details
                SubscriptionIdPatch200Response result = apiInstance.SubscriptionIdPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionIdPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionIdPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates subscription payment details
    ApiResponse<SubscriptionIdPatch200Response> response = apiInstance.SubscriptionIdPatchWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionIdPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |
| **body** | [**SubscriptionIdPatchRequest**](SubscriptionIdPatchRequest.md) | Subscription Payment object to edit existing one |  |

### Return type

[**SubscriptionIdPatch200Response**](SubscriptionIdPatch200Response.md)

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

<a id="subscriptionpost"></a>
# **SubscriptionPost**
> SubscriptionPost201Response SubscriptionPost (SubscriptionPostRequest body)

Create subscription payment

Subscriptions are periodic payments of the same amount of money, configured through Checkout or our Payments API.  Subscriptions support a number of different frequencies, ranging from daily to once every three years. Their last payment can be determined by the end date of the subscription, as well as the total number of payments captured.  They also support a configurable number of retries for each capture in case of failure, as well as falling back to another (single) payment method if the recurring one is not successful.  Supported methods for subscriptions are: <i style=\"color:red\">Credit Card</i> and <i style=\"color:red\">Direct Debit.</i>

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SubscriptionPostExample
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

            var apiInstance = new SubscriptionPaymentApi(config);
            var body = new SubscriptionPostRequest(); // SubscriptionPostRequest | Payment configuration object to generate a payment

            try
            {
                // Create subscription payment
                SubscriptionPost201Response result = apiInstance.SubscriptionPost(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SubscriptionPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create subscription payment
    ApiResponse<SubscriptionPost201Response> response = apiInstance.SubscriptionPostWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SubscriptionPaymentApi.SubscriptionPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SubscriptionPostRequest**](SubscriptionPostRequest.md) | Payment configuration object to generate a payment |  |

### Return type

[**SubscriptionPost201Response**](SubscriptionPost201Response.md)

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
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

