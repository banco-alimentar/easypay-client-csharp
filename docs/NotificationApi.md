# Easypay.Rest.Client.Api.NotificationApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthorisationNotification**](NotificationApi.md#authorisationnotification) | **POST** /your-authorisation-notification-endpoint | Authorisation notifications will be sent with this json
[**GenericNotification**](NotificationApi.md#genericnotification) | **POST** /your-generic-notification-endpoint | Generic notifications will be sent with this json
[**TransactionNotification**](NotificationApi.md#transactionnotification) | **POST** /your-transaction-notification-endpoint | Transaction notification will be sent with this json


<a name="authorisationnotification"></a>
# **AuthorisationNotification**
> StatusDetails AuthorisationNotification (AuthorisationNotificationRequest authorisationNotificationRequest)

Authorisation notifications will be sent with this json

Authorisation Notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class AuthorisationNotificationExample
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

            var apiInstance = new NotificationApi(config);
            var authorisationNotificationRequest = new AuthorisationNotificationRequest(); // AuthorisationNotificationRequest | We will send you this json in our notification

            try
            {
                // Authorisation notifications will be sent with this json
                StatusDetails result = apiInstance.AuthorisationNotification(authorisationNotificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationApi.AuthorisationNotification: " + e.Message );
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
 **authorisationNotificationRequest** | [**AuthorisationNotificationRequest**](AuthorisationNotificationRequest.md)| We will send you this json in our notification | 

### Return type

[**StatusDetails**](StatusDetails.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="genericnotification"></a>
# **GenericNotification**
> StatusDetails GenericNotification (GenericNotificationRequest genericNotificationRequest)

Generic notifications will be sent with this json

Generic Notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class GenericNotificationExample
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

            var apiInstance = new NotificationApi(config);
            var genericNotificationRequest = new GenericNotificationRequest(); // GenericNotificationRequest | We will send you this json in our notifications

            try
            {
                // Generic notifications will be sent with this json
                StatusDetails result = apiInstance.GenericNotification(genericNotificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationApi.GenericNotification: " + e.Message );
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
 **genericNotificationRequest** | [**GenericNotificationRequest**](GenericNotificationRequest.md)| We will send you this json in our notifications | 

### Return type

[**StatusDetails**](StatusDetails.md)

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

<a name="transactionnotification"></a>
# **TransactionNotification**
> StatusDetails TransactionNotification (TransactionNotificationRequest transactionNotificationRequest)

Transaction notification will be sent with this json

Transaction Notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class TransactionNotificationExample
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

            var apiInstance = new NotificationApi(config);
            var transactionNotificationRequest = new TransactionNotificationRequest(); // TransactionNotificationRequest | We will send you this json in our notification

            try
            {
                // Transaction notification will be sent with this json
                StatusDetails result = apiInstance.TransactionNotification(transactionNotificationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationApi.TransactionNotification: " + e.Message );
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
 **transactionNotificationRequest** | [**TransactionNotificationRequest**](TransactionNotificationRequest.md)| We will send you this json in our notification | 

### Return type

[**StatusDetails**](StatusDetails.md)

### Authorization

[accountId](../README.md#accountId), [apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **403** | Forbidden |  -  |
| **429** | Too Many Requests |  -  |
| **500** | Internal Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

