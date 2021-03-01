# BancoAlimentar.AlimentaEstaIdeia.easypay.Api.SinglePaymentApi

All URIs are relative to *https://api.prod.easypay.pt/2.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SingleGet**](SinglePaymentApi.md#singleget) | **GET** /single | Lists single payments


<a name="singleget"></a>
# **SingleGet**
> PropertiesHasListMetaData SingleGet (int? page = null, int? recordsPerPage = null, string type = null, string expirationTime = null, PaymentSingleMethodAvailable? method = null, string customer = null, string id = null, string key = null, double? value = null, string createdAt = null)

Lists single payments

Full report with all the single payments from your Account Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using BancoAlimentar.AlimentaEstaIdeia.easypay.Api;
using BancoAlimentar.AlimentaEstaIdeia.easypay.Client;
using BancoAlimentar.AlimentaEstaIdeia.easypay.Model;

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
            var page = 2;  // int? | Page Number (optional) 
            var recordsPerPage = 2;  // int? | Limit records per page (Max: 100) (optional) 
            var type = sale;  // string | Filter by type (optional) 
            var expirationTime = interval(2019-07-01 00:00,2019-07-01 23:59);  // string | Filter by expiration time interval (max 30 days) (optional) 
            var method = cc;  // PaymentSingleMethodAvailable? | Filter by method (optional) 
            var customer = Key Example;  // string | Filter by customer key (optional) 
            var id = b100175d-e347-4501-8388-5d4b00b8551b;  // string | Filter by id (optional) 
            var key = Single Key Example;  // string | Filter by single key (optional) 
            var value = 17.5;  // double? | Filter by value (optional) 
            var createdAt = interval(2019-07-01 00:00,2019-07-01 23:59);  // string | Filter by created datetime interval (max 30 days) (optional) 

            try
            {
                // Lists single payments
                PropertiesHasListMetaData result = apiInstance.SingleGet(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SinglePaymentApi.SingleGet: " + e.Message );
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
 **method** | **PaymentSingleMethodAvailable?**| Filter by method | [optional] 
 **customer** | **string**| Filter by customer key | [optional] 
 **id** | **string**| Filter by id | [optional] 
 **key** | **string**| Filter by single key | [optional] 
 **value** | **double?**| Filter by value | [optional] 
 **createdAt** | **string**| Filter by created datetime interval (max 30 days) | [optional] 

### Return type

[**PropertiesHasListMetaData**](PropertiesHasListMetaData.md)

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
