# Easypay.Rest.Client.Api.SinglePaymentApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSinglePayment**](SinglePaymentApi.md#createsinglepayment) | **POST** /single | Create single payment
[**DeleteSinglePayment**](SinglePaymentApi.md#deletesinglepayment) | **DELETE** /single/{id} | Deletes single payment
[**GetSinglePayment**](SinglePaymentApi.md#getsinglepayment) | **GET** /single/{id} | Shows single payment details
[**ListSinglePayments**](SinglePaymentApi.md#listsinglepayments) | **GET** /single | Lists single payments
[**UpdateSinglePayment**](SinglePaymentApi.md#updatesinglepayment) | **PATCH** /single/{id} | Updates single payment details


<a name="createsinglepayment"></a>
# **CreateSinglePayment**
> SinglePaymentResponse CreateSinglePayment (SinglePaymentRequest singlePaymentRequest)

Create single payment

Create single payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class CreateSinglePaymentExample
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
            var singlePaymentRequest = new SinglePaymentRequest(); // SinglePaymentRequest | Payment configuration object to generate a payment

            try
            {
                // Create single payment
                SinglePaymentResponse result = apiInstance.CreateSinglePayment(singlePaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.CreateSinglePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **singlePaymentRequest** | [**SinglePaymentRequest**](SinglePaymentRequest.md)| Payment configuration object to generate a payment | 

### Return type

[**SinglePaymentResponse**](SinglePaymentResponse.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesinglepayment"></a>
# **DeleteSinglePayment**
> void DeleteSinglePayment (Guid id)

Deletes single payment

Deletes single payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class DeleteSinglePaymentExample
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
            var id = new Guid(); // Guid | Resource Identification

            try
            {
                // Deletes single payment
                apiInstance.DeleteSinglePayment(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.DeleteSinglePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)| Resource Identification | 

### Return type

void (empty response body)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


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

<a name="getsinglepayment"></a>
# **GetSinglePayment**
> SinglePaymentWithTransactionsResponse GetSinglePayment (Guid id)

Shows single payment details

Shows single payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class GetSinglePaymentExample
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
            var id = new Guid(); // Guid | Resource Identification

            try
            {
                // Shows single payment details
                SinglePaymentWithTransactionsResponse result = apiInstance.GetSinglePayment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.GetSinglePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)| Resource Identification | 

### Return type

[**SinglePaymentWithTransactionsResponse**](SinglePaymentWithTransactionsResponse.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


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

<a name="listsinglepayments"></a>
# **ListSinglePayments**
> ListSinglePaymentResponse ListSinglePayments (int? page = null, int? recordsPerPage = null, string type = null, string expirationTime = null, string method = null, string customer = null, Guid? id = null, string key = null, double? value = null, string createdAt = null)

Lists single payments

Full report with all the single payments from your Account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class ListSinglePaymentsExample
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
            var page = 2;  // int? | Page Number (optional) 
            var recordsPerPage = 2;  // int? | Limit records per page (Max: 100) (optional) 
            var type = sale;  // string | Filter by type (optional) 
            var expirationTime = interval(2019-07-01 00:00,2019-07-01 23:59);  // string | Filter by expiration time interval (max 30 days) (optional) 
            var method = cc;  // string | Filter by method (optional) 
            var customer = Key Example;  // string | Filter by customer key (optional) 
            var id = new Guid?(); // Guid? | Resource Identification (optional) 
            var key = Single Key Example;  // string | Filter by single key (optional) 
            var value = 17.5;  // double? | Filter by value (optional) 
            var createdAt = interval(2019-07-01 00:00,2019-07-01 23:59);  // string | Filter by created datetime interval (max 30 days) (optional) 

            try
            {
                // Lists single payments
                ListSinglePaymentResponse result = apiInstance.ListSinglePayments(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.ListSinglePayments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Page Number | [optional] 
 **recordsPerPage** | **int?**| Limit records per page (Max: 100) | [optional] 
 **type** | **string**| Filter by type | [optional] 
 **expirationTime** | **string**| Filter by expiration time interval (max 30 days) | [optional] 
 **method** | **string**| Filter by method | [optional] 
 **customer** | **string**| Filter by customer key | [optional] 
 **id** | [**Guid?**](Guid?.md)| Resource Identification | [optional] 
 **key** | **string**| Filter by single key | [optional] 
 **value** | **double?**| Filter by value | [optional] 
 **createdAt** | **string**| Filter by created datetime interval (max 30 days) | [optional] 

### Return type

[**ListSinglePaymentResponse**](ListSinglePaymentResponse.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatesinglepayment"></a>
# **UpdateSinglePayment**
> SinglePaymentUpdateResponse UpdateSinglePayment (Guid id, SinglePaymentUpdateRequest singlePaymentUpdateRequest)

Updates single payment details

Updates single payment details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class UpdateSinglePaymentExample
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
            var id = new Guid(); // Guid | Resource Identification
            var singlePaymentUpdateRequest = new SinglePaymentUpdateRequest(); // SinglePaymentUpdateRequest | Single Payment object to edit existing one

            try
            {
                // Updates single payment details
                SinglePaymentUpdateResponse result = apiInstance.UpdateSinglePayment(id, singlePaymentUpdateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.UpdateSinglePayment: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)| Resource Identification | 
 **singlePaymentUpdateRequest** | [**SinglePaymentUpdateRequest**](SinglePaymentUpdateRequest.md)| Single Payment object to edit existing one | 

### Return type

[**SinglePaymentUpdateResponse**](SinglePaymentUpdateResponse.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **304** | Not Modified |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Resource Not Found |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

