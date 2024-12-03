# Easypay.Rest.Client.Api.PaymentGenericOperationsApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthorisationIdGet**](PaymentGenericOperationsApi.md#authorisationidget) | **GET** /authorisation/{id} | Shows authorisation details |
| [**CaptureCaptureUuidSplitsCaptureSplitUuidPatch**](PaymentGenericOperationsApi.md#capturecaptureuuidsplitscapturesplituuidpatch) | **PATCH** /capture/{capture-uuid}/splits/{capture-split-uuid} | Updates the split of a capture |
| [**CaptureGet**](PaymentGenericOperationsApi.md#captureget) | **GET** /capture | List captures |
| [**CaptureIdGet**](PaymentGenericOperationsApi.md#captureidget) | **GET** /capture/{id} | Shows capture details |
| [**CaptureIdPost**](PaymentGenericOperationsApi.md#captureidpost) | **POST** /capture/{id} | Captures a Single Auth, Frequent and Frequent Auth |
| [**ListChargeback**](PaymentGenericOperationsApi.md#listchargeback) | **GET** /chargeback | List chargebacks |
| [**ListRefund**](PaymentGenericOperationsApi.md#listrefund) | **GET** /refund | List Refunds |
| [**RefundIdGet**](PaymentGenericOperationsApi.md#refundidget) | **GET** /refund/{id} | Shows refund details |
| [**RefundIdPost**](PaymentGenericOperationsApi.md#refundidpost) | **POST** /refund/{id} | Refunds a Single Transaction or Frequent Transaction |
| [**VoidIdGet**](PaymentGenericOperationsApi.md#voididget) | **GET** /void/{id} | Shows void details |
| [**VoidIdPost**](PaymentGenericOperationsApi.md#voididpost) | **POST** /void/{id} | Voids a Single Auth or Frequent Auth |

<a id="authorisationidget"></a>
# **AuthorisationIdGet**
> AuthorisationIdGet200Response AuthorisationIdGet (Guid id)

Shows authorisation details

Retrieves the details of an authorisation

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class AuthorisationIdGetExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows authorisation details
                AuthorisationIdGet200Response result = apiInstance.AuthorisationIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.AuthorisationIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthorisationIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows authorisation details
    ApiResponse<AuthorisationIdGet200Response> response = apiInstance.AuthorisationIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.AuthorisationIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**AuthorisationIdGet200Response**](AuthorisationIdGet200Response.md)

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

<a id="capturecaptureuuidsplitscapturesplituuidpatch"></a>
# **CaptureCaptureUuidSplitsCaptureSplitUuidPatch**
> CaptureCaptureUuidSplitsCaptureSplitUuidPatch201Response CaptureCaptureUuidSplitsCaptureSplitUuidPatch (Guid captureUuid, Guid captureSplitUuid, CaptureCaptureUuidSplitsCaptureSplitUuidPatchRequest? captureCaptureUuidSplitsCaptureSplitUuidPatchRequest = null)

Updates the split of a capture

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class CaptureCaptureUuidSplitsCaptureSplitUuidPatchExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var captureUuid = "captureUuid_example";  // Guid | Capture Identification
            var captureSplitUuid = "captureSplitUuid_example";  // Guid | Capture Split Identification
            var captureCaptureUuidSplitsCaptureSplitUuidPatchRequest = new CaptureCaptureUuidSplitsCaptureSplitUuidPatchRequest?(); // CaptureCaptureUuidSplitsCaptureSplitUuidPatchRequest? | Payment configuration object to generate a payment (optional) 

            try
            {
                // Updates the split of a capture
                CaptureCaptureUuidSplitsCaptureSplitUuidPatch201Response result = apiInstance.CaptureCaptureUuidSplitsCaptureSplitUuidPatch(captureUuid, captureSplitUuid, captureCaptureUuidSplitsCaptureSplitUuidPatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureCaptureUuidSplitsCaptureSplitUuidPatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureCaptureUuidSplitsCaptureSplitUuidPatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Updates the split of a capture
    ApiResponse<CaptureCaptureUuidSplitsCaptureSplitUuidPatch201Response> response = apiInstance.CaptureCaptureUuidSplitsCaptureSplitUuidPatchWithHttpInfo(captureUuid, captureSplitUuid, captureCaptureUuidSplitsCaptureSplitUuidPatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureCaptureUuidSplitsCaptureSplitUuidPatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **captureUuid** | **Guid** | Capture Identification |  |
| **captureSplitUuid** | **Guid** | Capture Split Identification |  |
| **captureCaptureUuidSplitsCaptureSplitUuidPatchRequest** | [**CaptureCaptureUuidSplitsCaptureSplitUuidPatchRequest?**](CaptureCaptureUuidSplitsCaptureSplitUuidPatchRequest?.md) | Payment configuration object to generate a payment | [optional]  |

### Return type

[**CaptureCaptureUuidSplitsCaptureSplitUuidPatch201Response**](CaptureCaptureUuidSplitsCaptureSplitUuidPatch201Response.md)

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
| **412** | Precondition Failed |  -  |
| **428** | Precondition Required |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="captureget"></a>
# **CaptureGet**
> InlineObject11 CaptureGet (string? cursor = null, decimal? limit = null, string? createdAt = null, string? updatedAt = null)

List captures

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class CaptureGetExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var cursor = "cursor_example";  // string? | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. (optional) 
            var limit = 8.14D;  // decimal? | The limit parameter is used for pagination. It specifies the maximum number of entries to return in a single page of results. Max 100.  (optional) 
            var createdAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 
            var updatedAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by update datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 

            try
            {
                // List captures
                InlineObject11 result = apiInstance.CaptureGet(cursor, limit, createdAt, updatedAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List captures
    ApiResponse<InlineObject11> response = apiInstance.CaptureGetWithHttpInfo(cursor, limit, createdAt, updatedAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string?** | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. | [optional]  |
| **limit** | **decimal?** | The limit parameter is used for pagination. It specifies the maximum number of entries to return in a single page of results. Max 100.  | [optional]  |
| **createdAt** | **string?** | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |
| **updatedAt** | **string?** | Filter records by update datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |

### Return type

[**InlineObject11**](InlineObject11.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |
| **401** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not found response |  -  |
| **412** | Pre condition failed |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="captureidget"></a>
# **CaptureIdGet**
> InlineObject12 CaptureIdGet (Guid id)

Shows capture details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class CaptureIdGetExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows capture details
                InlineObject12 result = apiInstance.CaptureIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows capture details
    ApiResponse<InlineObject12> response = apiInstance.CaptureIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**InlineObject12**](InlineObject12.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Example response |  -  |
| **401** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **404** | Not found response |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="captureidpost"></a>
# **CaptureIdPost**
> CaptureIdPost201Response CaptureIdPost (Guid id, CaptureIdPostRequest captureIdPostRequest)

Captures a Single Auth, Frequent and Frequent Auth

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class CaptureIdPostExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | Resource Identification
            var captureIdPostRequest = new CaptureIdPostRequest(); // CaptureIdPostRequest | Payment configuration object to generate a payment

            try
            {
                // Captures a Single Auth, Frequent and Frequent Auth
                CaptureIdPost201Response result = apiInstance.CaptureIdPost(id, captureIdPostRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CaptureIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Captures a Single Auth, Frequent and Frequent Auth
    ApiResponse<CaptureIdPost201Response> response = apiInstance.CaptureIdPostWithHttpInfo(id, captureIdPostRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.CaptureIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |
| **captureIdPostRequest** | [**CaptureIdPostRequest**](CaptureIdPostRequest.md) | Payment configuration object to generate a payment |  |

### Return type

[**CaptureIdPost201Response**](CaptureIdPost201Response.md)

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
| **412** | Precondition Failed |  -  |
| **422** | Unprocessable Entity |  -  |
| **428** | Precondition Required |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listchargeback"></a>
# **ListChargeback**
> InlineObject14 ListChargeback (string? cursor = null, decimal? limit = null, string? createdAt = null)

List chargebacks

This endpoint retrieves a list of chargebacks associated with your account. A Chargeback is a mandatory transaction reversal initiated by the consumer's card issuer or bank, usually due to a dispute over a transaction. When a chargeback occurs, the costumer effectively reverses the transaction, resulting in a debit of the disputed amount from the merchant's account. This endpoint allows you to view details of chargebacks, including the reason for the dispute, transaction amount, and status, providing insights into consumer disputes and their impact on your financials.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class ListChargebackExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var cursor = "cursor_example";  // string? | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. (optional) 
            var limit = 8.14D;  // decimal? | The limit parameter is used for pagination. It specifies the maximum number of entries to return in a single page of results. Max 100.  (optional) 
            var createdAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 

            try
            {
                // List chargebacks
                InlineObject14 result = apiInstance.ListChargeback(cursor, limit, createdAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.ListChargeback: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListChargebackWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List chargebacks
    ApiResponse<InlineObject14> response = apiInstance.ListChargebackWithHttpInfo(cursor, limit, createdAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.ListChargebackWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string?** | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. | [optional]  |
| **limit** | **decimal?** | The limit parameter is used for pagination. It specifies the maximum number of entries to return in a single page of results. Max 100.  | [optional]  |
| **createdAt** | **string?** | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |

### Return type

[**InlineObject14**](InlineObject14.md)

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
| **412** | Pre condition failed |  -  |
| **500** | Unprocessable Entity |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrefund"></a>
# **ListRefund**
> InlineObject13 ListRefund (string? cursor = null, decimal? limit = null, string? createdAt = null, string? updatedAt = null)

List Refunds

Cursor based endpoint to retrieve all account refunds.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class ListRefundExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var cursor = "cursor_example";  // string? | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. (optional) 
            var limit = 8.14D;  // decimal? | The limit parameter is used for pagination. It specifies the maximum number of entries to return in a single page of results. Max 100.  (optional) 
            var createdAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 
            var updatedAt = interval(2006-01-02 15:04,2006-01-02 15:04);  // string? | Filter records by update datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) (optional) 

            try
            {
                // List Refunds
                InlineObject13 result = apiInstance.ListRefund(cursor, limit, createdAt, updatedAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.ListRefund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRefundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Refunds
    ApiResponse<InlineObject13> response = apiInstance.ListRefundWithHttpInfo(cursor, limit, createdAt, updatedAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.ListRefundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cursor** | **string?** | The cursor parameter is used for pagination. It specifies the pointer to the start of the next set of results in a sequence of paginated data. Typically, this is a unique identifier of the last item from the previous response. If not provided, the API fetches the first page of results. | [optional]  |
| **limit** | **decimal?** | The limit parameter is used for pagination. It specifies the maximum number of entries to return in a single page of results. Max 100.  | [optional]  |
| **createdAt** | **string?** | Filter records by creation datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |
| **updatedAt** | **string?** | Filter records by update datetime interval. Maximum range of 30 days. Format: interval(YYYY-MM-DD HH:MM,YYYY-MM-DD HH:MM) | [optional]  |

### Return type

[**InlineObject13**](InlineObject13.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ListRefunds endpoint retrieves a paginated list of refund transactions processed within the system. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="refundidget"></a>
# **RefundIdGet**
> RefundIdGet200Response RefundIdGet (Guid id)

Shows refund details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class RefundIdGetExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows refund details
                RefundIdGet200Response result = apiInstance.RefundIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.RefundIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefundIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows refund details
    ApiResponse<RefundIdGet200Response> response = apiInstance.RefundIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.RefundIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**RefundIdGet200Response**](RefundIdGet200Response.md)

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

<a id="refundidpost"></a>
# **RefundIdPost**
> CaptureIdPost201Response RefundIdPost (Guid id, RefundIdPostRequest body)

Refunds a Single Transaction or Frequent Transaction

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class RefundIdPostExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | The capture uuid associated with Single or Frequent Transaction
            var body = new RefundIdPostRequest(); // RefundIdPostRequest | Refund details

            try
            {
                // Refunds a Single Transaction or Frequent Transaction
                CaptureIdPost201Response result = apiInstance.RefundIdPost(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.RefundIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RefundIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Refunds a Single Transaction or Frequent Transaction
    ApiResponse<CaptureIdPost201Response> response = apiInstance.RefundIdPostWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.RefundIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | The capture uuid associated with Single or Frequent Transaction |  |
| **body** | [**RefundIdPostRequest**](RefundIdPostRequest.md) | Refund details |  |

### Return type

[**CaptureIdPost201Response**](CaptureIdPost201Response.md)

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
| **412** | Precondition Failed |  -  |
| **422** | Unprocessable Entity |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voididget"></a>
# **VoidIdGet**
> VoidIdGet200Response VoidIdGet (Guid id)

Shows void details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class VoidIdGetExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | Resource Identification

            try
            {
                // Shows void details
                VoidIdGet200Response result = apiInstance.VoidIdGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.VoidIdGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidIdGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Shows void details
    ApiResponse<VoidIdGet200Response> response = apiInstance.VoidIdGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.VoidIdGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |

### Return type

[**VoidIdGet200Response**](VoidIdGet200Response.md)

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

<a id="voididpost"></a>
# **VoidIdPost**
> CaptureIdPost201Response VoidIdPost (Guid id, VoidIdPostRequest body)

Voids a Single Auth or Frequent Auth

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class VoidIdPostExample
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

            var apiInstance = new PaymentGenericOperationsApi(config);
            var id = "id_example";  // Guid | Resource Identification
            var body = new VoidIdPostRequest(); // VoidIdPostRequest | Void details

            try
            {
                // Voids a Single Auth or Frequent Auth
                CaptureIdPost201Response result = apiInstance.VoidIdPost(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentGenericOperationsApi.VoidIdPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidIdPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Voids a Single Auth or Frequent Auth
    ApiResponse<CaptureIdPost201Response> response = apiInstance.VoidIdPostWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentGenericOperationsApi.VoidIdPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Resource Identification |  |
| **body** | [**VoidIdPostRequest**](VoidIdPostRequest.md) | Void details |  |

### Return type

[**CaptureIdPost201Response**](CaptureIdPost201Response.md)

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
| **412** | Precondition Failed |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

