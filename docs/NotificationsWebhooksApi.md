# Easypay.Rest.Client.Api.NotificationsWebhooksApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**YourAuthorisationNotificationEndpointPost**](NotificationsWebhooksApi.md#yourauthorisationnotificationendpointpost) | **POST** /yourAuthorisationNotificationEndpoint | Authorisation Notification |
| [**YourGenericNotificationEndpointPost**](NotificationsWebhooksApi.md#yourgenericnotificationendpointpost) | **POST** /yourGenericNotificationEndpoint | Generic Notification |
| [**YourNotificationEndpointPost**](NotificationsWebhooksApi.md#yournotificationendpointpost) | **POST** /yourNotificationEndpoint | Transaction Notification |

<a id="yourauthorisationnotificationendpointpost"></a>
# **YourAuthorisationNotificationEndpointPost**
> void YourAuthorisationNotificationEndpointPost (NotificationAuthorisation body)

Authorisation Notification

We will send you this json in our notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class YourAuthorisationNotificationEndpointPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.easypay.pt/2.0";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NotificationsWebhooksApi(config);
            var body = new NotificationAuthorisation(); // NotificationAuthorisation | Notification Payload

            try
            {
                // Authorisation Notification
                apiInstance.YourAuthorisationNotificationEndpointPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsWebhooksApi.YourAuthorisationNotificationEndpointPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the YourAuthorisationNotificationEndpointPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Authorisation Notification
    apiInstance.YourAuthorisationNotificationEndpointPostWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsWebhooksApi.YourAuthorisationNotificationEndpointPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**NotificationAuthorisation**](NotificationAuthorisation.md) | Notification Payload |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return a 200 status to indicate that the data was received successfully |  * X-Easypay-Code - A user defined code <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="yourgenericnotificationendpointpost"></a>
# **YourGenericNotificationEndpointPost**
> void YourGenericNotificationEndpointPost (NotificationGeneric notificationGeneric)

Generic Notification

We will send you this json in our notifications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class YourGenericNotificationEndpointPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.easypay.pt/2.0";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NotificationsWebhooksApi(config);
            var notificationGeneric = new NotificationGeneric(); // NotificationGeneric | Notification Payload

            try
            {
                // Generic Notification
                apiInstance.YourGenericNotificationEndpointPost(notificationGeneric);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsWebhooksApi.YourGenericNotificationEndpointPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the YourGenericNotificationEndpointPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generic Notification
    apiInstance.YourGenericNotificationEndpointPostWithHttpInfo(notificationGeneric);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsWebhooksApi.YourGenericNotificationEndpointPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **notificationGeneric** | [**NotificationGeneric**](NotificationGeneric.md) | Notification Payload |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return a 200 status to indicate that the data was received successfully |  * X-Easypay-Code - A user defined code <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="yournotificationendpointpost"></a>
# **YourNotificationEndpointPost**
> void YourNotificationEndpointPost (NotificationCapture body)

Transaction Notification

We will send you this json in our notification

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Easypay.Rest.Client.Api;
using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Model;

namespace Example
{
    public class YourNotificationEndpointPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.prod.easypay.pt/2.0";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new NotificationsWebhooksApi(config);
            var body = new NotificationCapture(); // NotificationCapture | Notification Payload

            try
            {
                // Transaction Notification
                apiInstance.YourNotificationEndpointPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NotificationsWebhooksApi.YourNotificationEndpointPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the YourNotificationEndpointPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Transaction Notification
    apiInstance.YourNotificationEndpointPostWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling NotificationsWebhooksApi.YourNotificationEndpointPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**NotificationCapture**](NotificationCapture.md) | Notification Payload |  |

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return a 200 status to indicate that the data was received successfully |  * X-Easypay-Code - A user defined code <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

