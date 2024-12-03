# Easypay.Rest.Client.Api.SinglePaymentApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SingleDelete**](SinglePaymentApi.md#singledelete) | **DELETE** /single/{id} | Deletes single payment |
| [**SingleGet**](SinglePaymentApi.md#singleget) | **GET** /single | Lists single payments |
| [**SingleIdGet**](SinglePaymentApi.md#singleidget) | **GET** /single/{id} | Shows single payment details |
| [**SinglePost**](SinglePaymentApi.md#singlepost) | **POST** /single | Create single payment |
| [**SingleUpdate**](SinglePaymentApi.md#singleupdate) | **PATCH** /single/{id} | Update a single Payment |

<a id="singledelete"></a>
# **SingleDelete**
> void SingleDelete (Guid id)

Deletes single payment

This endpoint allows for the deletion of a single payment identified by its unique ID. The DELETE operation performs the following actions based on the payment method:    - MBWay and Credit Cards: Voids all authorizations.   - Multibanco: Cancels the Multibanco Reference.   - Direct Debit: Cancels the Direct Debit if the request is made before the cutoff hour(18:00 Europe/Lisbon).  This operation ensures that all associated authorizations and references are properly handled and terminated according to the specified payment method.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SingleDeleteExample
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

            var apiInstance = new SinglePaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Deletes single payment
                apiInstance.SingleDelete(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.SingleDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SingleDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Deletes single payment
    apiInstance.SingleDeleteWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SinglePaymentApi.SingleDeleteWithHttpInfo: " + e.Message);
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
| **403** | Forbidden |  -  |
| **404** | Not found response |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="singleget"></a>
# **SingleGet**
> InlineObject8 SingleGet (int? page = null, int? recordsPerPage = null, string? type = null, string? expirationTime = null, string? method = null, string? customer = null, Guid? id = null, string? key = null, double? value = null, string? createdAt = null)

Lists single payments

Full report with all the single payments from your Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SingleGetExample
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

            var apiInstance = new SinglePaymentApi(config);
            var page = 1;  // int? | Specifies the page number of the results to retrieve. This parameter is used for paginating through a collection of records, allowing the client to navigate to different pages of the dataset. The value must be a positive integer (e.g., \"1\" for the first page). (optional)  (default to 1)
            var recordsPerPage = 20;  // int? | Specifies the number of records to retrieve per page. This parameter is used for controlling the size of each page in a paginated collection of records. The value must be a positive integer, determining how many records are displayed on each page (e.g., \"20\" for 20 records per page). (optional)  (default to 20)
            var type = sale;  // string? | Filter by type of financial operation being performed. Possible values are \"Sale\" (a complete transaction where funds are immediately captured) or \"Authorisation\" (a temporary hold on funds pending a future capture). (optional) 
            var expirationTime = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by expiration datetime interval. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 
            var method = mb;  // string? | Filter by payment method used in the transaction. (optional) 
            var customer = 01J32EDWGNX94XMWP8PWB23KBK;  // string? | A user-defined identifier used to filter the customers. This parameter allows the client to specify a key to retrieve records or transactions that match the provided key. The value is a string and may not be unique, as it is determined by the user. (optional) 
            var id = bb3e7e60-20f3-4208-9b21-64c635a51f42;  // Guid? | Filter by the unique identifier for the resource. Typically formatted as a UUID (Universally Unique Identifier). (optional) 
            var key = 01J32EESEC1Z543P7J3PKSF1Q9;  // string? | A user-defined identifier used to filter the results. This parameter allows the client to specify a key to retrieve records or transactions that match the provided key. The value is a string and may not be unique, as it is determined by the user. (optional) 
            var value = 10.32;  // double? | Filter records by the exact transaction amount. (optional) 
            var createdAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 

            try
            {
                // Lists single payments
                InlineObject8 result = apiInstance.SingleGet(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.SingleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SingleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Lists single payments
    ApiResponse<InlineObject8> response = apiInstance.SingleGetWithHttpInfo(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SinglePaymentApi.SingleGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | Specifies the page number of the results to retrieve. This parameter is used for paginating through a collection of records, allowing the client to navigate to different pages of the dataset. The value must be a positive integer (e.g., \&quot;1\&quot; for the first page). | [optional] [default to 1] |
| **recordsPerPage** | **int?** | Specifies the number of records to retrieve per page. This parameter is used for controlling the size of each page in a paginated collection of records. The value must be a positive integer, determining how many records are displayed on each page (e.g., \&quot;20\&quot; for 20 records per page). | [optional] [default to 20] |
| **type** | **string?** | Filter by type of financial operation being performed. Possible values are \&quot;Sale\&quot; (a complete transaction where funds are immediately captured) or \&quot;Authorisation\&quot; (a temporary hold on funds pending a future capture). | [optional]  |
| **expirationTime** | **string?** | Filter records by expiration datetime interval. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |
| **method** | **string?** | Filter by payment method used in the transaction. | [optional]  |
| **customer** | **string?** | A user-defined identifier used to filter the customers. This parameter allows the client to specify a key to retrieve records or transactions that match the provided key. The value is a string and may not be unique, as it is determined by the user. | [optional]  |
| **id** | **Guid?** | Filter by the unique identifier for the resource. Typically formatted as a UUID (Universally Unique Identifier). | [optional]  |
| **key** | **string?** | A user-defined identifier used to filter the results. This parameter allows the client to specify a key to retrieve records or transactions that match the provided key. The value is a string and may not be unique, as it is determined by the user. | [optional]  |
| **value** | **double?** | Filter records by the exact transaction amount. | [optional]  |
| **createdAt** | **string?** | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |

### Return type

[**InlineObject8**](InlineObject8.md)

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
| **404** | Not found response |  -  |
| **412** | Pre condition failed |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="singleidget"></a>
# **SingleIdGet**
> InlineObject9 SingleIdGet (Guid id)

Shows single payment details

Retrive a single payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SingleIdGetExample
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

            var apiInstance = new SinglePaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows single payment details
                InlineObject9 result = apiInstance.SingleIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.SingleIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SingleIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows single payment details
    ApiResponse<InlineObject9> response = apiInstance.SingleIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SinglePaymentApi.SingleIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**InlineObject9**](InlineObject9.md)

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
| **404** | Not found response |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="singlepost"></a>
# **SinglePost**
> InlineObject5 SinglePost (SinglePostRequest singlePostRequest)

Create single payment

Creates a Single Payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SinglePostExample
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

            var apiInstance = new SinglePaymentApi(config);
            var singlePostRequest = new SinglePostRequest(); // SinglePostRequest | Configuration object to generate a single payment

            try
            {
                // Create single payment
                InlineObject5 result = apiInstance.SinglePost(singlePostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.SinglePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SinglePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create single payment
    ApiResponse<InlineObject5> response = apiInstance.SinglePostWithHttpInfo(singlePostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SinglePaymentApi.SinglePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **singlePostRequest** | [**SinglePostRequest**](SinglePostRequest.md) | Configuration object to generate a single payment |  |

### Return type

[**InlineObject5**](InlineObject5.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Single created with success response |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **412** | Pre condition failed |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="singleupdate"></a>
# **SingleUpdate**
> InlineObject10 SingleUpdate (Guid id, SingleUpdateRequest? singleUpdateRequest = null)

Update a single Payment

Apply partial modifications to a single payment resource.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class SingleUpdateExample
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

            var apiInstance = new SinglePaymentApi(config);
            var id = "id_example";  // Guid | Resource Identification
            var singleUpdateRequest = new SingleUpdateRequest?(); // SingleUpdateRequest? |  (optional) 

            try
            {
                // Update a single Payment
                InlineObject10 result = apiInstance.SingleUpdate(id, singleUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.SingleUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SingleUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a single Payment
    ApiResponse<InlineObject10> response = apiInstance.SingleUpdateWithHttpInfo(id, singleUpdateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SinglePaymentApi.SingleUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |
| **singleUpdateRequest** | [**SingleUpdateRequest?**](SingleUpdateRequest?.md) |  | [optional]  |

### Return type

[**InlineObject10**](InlineObject10.md)

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
| **403** | Forbidden |  -  |
| **404** | Not found response |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

