# Easypay.Rest.Client.Api.OutPaymentApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**OutPaymentGet**](OutPaymentApi.md#outpaymentget) | **GET** /out_payment | Lists out payments |
| [**OutPaymentIdDelete**](OutPaymentApi.md#outpaymentiddelete) | **DELETE** /out_payment/{id} | Deletes out payment |
| [**OutPaymentIdGet**](OutPaymentApi.md#outpaymentidget) | **GET** /out_payment/{id} | Shows out payment details |
| [**OutPaymentPost**](OutPaymentApi.md#outpaymentpost) | **POST** /out_payment | Create out payment |

<a id="outpaymentget"></a>
# **OutPaymentGet**
> OutPaymentGet200Response OutPaymentGet (decimal? page = null, decimal? recordsPerPage = null, string? type = null, string? method = null, string? id = null, string? key = null, double? value = null)

Lists out payments

Full report with all the out payments from your Account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class OutPaymentGetExample
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

            var apiInstance = new OutPaymentApi(config);
            var page = 8.14D;  // decimal? | Page Number (optional) 
            var recordsPerPage = 20MD;  // decimal? | Limit records per page (Max: 100) (optional)  (default to 20M)
            var type = "type_example";  // string? | Filter by type (optional) 
            var method = "method_example";  // string? | Filter by method (optional) 
            var id = "id_example";  // string? | Filter by id (optional) 
            var key = "key_example";  // string? | Filter by out payment key (optional) 
            var value = 1.2D;  // double? | Filter by value (optional) 

            try
            {
                // Lists out payments
                OutPaymentGet200Response result = apiInstance.OutPaymentGet(page, recordsPerPage, type, method, id, key, value);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutPaymentApi.OutPaymentGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutPaymentGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists out payments
    ApiResponse<OutPaymentGet200Response> response = apiInstance.OutPaymentGetWithHttpInfo(page, recordsPerPage, type, method, id, key, value);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutPaymentApi.OutPaymentGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **decimal?** | Page Number | [optional]  |
| **recordsPerPage** | **decimal?** | Limit records per page (Max: 100) | [optional] [default to 20M] |
| **type** | **string?** | Filter by type | [optional]  |
| **method** | **string?** | Filter by method | [optional]  |
| **id** | **string?** | Filter by id | [optional]  |
| **key** | **string?** | Filter by out payment key | [optional]  |
| **value** | **double?** | Filter by value | [optional]  |

### Return type

[**OutPaymentGet200Response**](OutPaymentGet200Response.md)

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

<a id="outpaymentiddelete"></a>
# **OutPaymentIdDelete**
> void OutPaymentIdDelete (Guid id)

Deletes out payment

If the payment is not processed, it will be cancelled. </br> Get your strong authentication RSA private key from Easypay Backoffice on menu: </br> Web Services->Configuration API 2.0->Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class OutPaymentIdDeleteExample
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

            var apiInstance = new OutPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Deletes out payment
                apiInstance.OutPaymentIdDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutPaymentApi.OutPaymentIdDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutPaymentIdDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes out payment
    apiInstance.OutPaymentIdDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutPaymentApi.OutPaymentIdDeleteWithHttpInfo: " + e.Message);
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

<a id="outpaymentidget"></a>
# **OutPaymentIdGet**
> OutPaymentIdGet200Response OutPaymentIdGet (Guid id)

Shows out payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class OutPaymentIdGetExample
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

            var apiInstance = new OutPaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows out payment details
                OutPaymentIdGet200Response result = apiInstance.OutPaymentIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutPaymentApi.OutPaymentIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutPaymentIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows out payment details
    ApiResponse<OutPaymentIdGet200Response> response = apiInstance.OutPaymentIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutPaymentApi.OutPaymentIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**OutPaymentIdGet200Response**](OutPaymentIdGet200Response.md)

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

<a id="outpaymentpost"></a>
# **OutPaymentPost**
> OutPaymentPost201Response OutPaymentPost (OutPaymentPostRequest? outPaymentPostRequest = null)

Create out payment

Get your strong authentication RSA private key from Easypay Backoffice on menu:</br>Web Services->Configuration API 2.0->Keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class OutPaymentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.easypay.pt/2.0";
            // Configure API key authorization: accountId
            config.AddApiKey("AccountId", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("AccountId", "Bearer");
            // Configure API key authorization: signatureAuth
            config.AddApiKey("Signature", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Signature", "Bearer");
            // Configure API key authorization: apiKey
            config.AddApiKey("ApiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("ApiKey", "Bearer");

            var apiInstance = new OutPaymentApi(config);
            var outPaymentPostRequest = new OutPaymentPostRequest?(); // OutPaymentPostRequest? |  (optional) 

            try
            {
                // Create out payment
                OutPaymentPost201Response result = apiInstance.OutPaymentPost(outPaymentPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OutPaymentApi.OutPaymentPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the OutPaymentPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create out payment
    ApiResponse<OutPaymentPost201Response> response = apiInstance.OutPaymentPostWithHttpInfo(outPaymentPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OutPaymentApi.OutPaymentPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **outPaymentPostRequest** | [**OutPaymentPostRequest?**](OutPaymentPostRequest?.md) |  | [optional]  |

### Return type

[**OutPaymentPost201Response**](OutPaymentPost201Response.md)

### Authorization

[accountId](../README.md#accountId), [signatureAuth](../README.md#signatureAuth), [apiKey](../README.md#apiKey)

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

