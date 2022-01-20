# Avalara.SDK.Api.ShippingVerificationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeregisterShipment**](ShippingVerificationApi.md#deregistershipment) | **DELETE** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration | Removes the transaction from consideration when evaluating regulations that span multiple transactions.
[**RegisterShipment**](ShippingVerificationApi.md#registershipment) | **PUT** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration | Registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
[**RegisterShipmentIfCompliant**](ShippingVerificationApi.md#registershipmentifcompliant) | **PUT** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registerIfCompliant | Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
[**VerifyShipment**](ShippingVerificationApi.md#verifyshipment) | **GET** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/verify | Evaluates a transaction against a set of direct-to-consumer shipping regulations.


<a name="deregistershipment"></a>
# **DeregisterShipment**
> void DeregisterShipment (string companyCode, string transactionCode, string documentType = null)

Removes the transaction from consideration when evaluating regulations that span multiple transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Avalara.SDK.Api;
using Avalara.SDK.Client;
using Avalara.SDK.Model;

namespace Example
{
    public class DeregisterShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShippingVerificationApi(config);
            var companyCode = companyCode_example;  // string | The company code of the company that recorded the transaction
            var transactionCode = transactionCode_example;  // string | The transaction code to retrieve
            var documentType = documentType_example;  // string | (Optional): The document type of the transaction to operate on. If omitted, defaults to \"SalesInvoice\" (optional) 

            try
            {
                // Removes the transaction from consideration when evaluating regulations that span multiple transactions.
                apiInstance.DeregisterShipment(companyCode, transactionCode, documentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingVerificationApi.DeregisterShipment: " + e.Message );
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
 **companyCode** | **string**| The company code of the company that recorded the transaction | 
 **transactionCode** | **string**| The transaction code to retrieve | 
 **documentType** | **string**| (Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; | [optional] 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Invalid Transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registershipment"></a>
# **RegisterShipment**
> void RegisterShipment (string companyCode, string transactionCode, string documentType = null)

Registers the transaction so that it may be included when evaluating regulations that span multiple transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Avalara.SDK.Api;
using Avalara.SDK.Client;
using Avalara.SDK.Model;

namespace Example
{
    public class RegisterShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShippingVerificationApi(config);
            var companyCode = companyCode_example;  // string | The company code of the company that recorded the transaction
            var transactionCode = transactionCode_example;  // string | The transaction code to retrieve
            var documentType = documentType_example;  // string | (Optional): The document type of the transaction to operate on. If omitted, defaults to \"SalesInvoice\" (optional) 

            try
            {
                // Registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
                apiInstance.RegisterShipment(companyCode, transactionCode, documentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingVerificationApi.RegisterShipment: " + e.Message );
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
 **companyCode** | **string**| The company code of the company that recorded the transaction | 
 **transactionCode** | **string**| The transaction code to retrieve | 
 **documentType** | **string**| (Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; | [optional] 

### Return type

void (empty response body)

### Authorization

[BasicAuth](../README.md#BasicAuth), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Invalid Transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="registershipmentifcompliant"></a>
# **RegisterShipmentIfCompliant**
> ShippingVerifyResult RegisterShipmentIfCompliant (string companyCode, string transactionCode, string documentType = null)

Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Avalara.SDK.Api;
using Avalara.SDK.Client;
using Avalara.SDK.Model;

namespace Example
{
    public class RegisterShipmentIfCompliantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShippingVerificationApi(config);
            var companyCode = companyCode_example;  // string | The company code of the company that recorded the transaction
            var transactionCode = transactionCode_example;  // string | The transaction code to retrieve
            var documentType = documentType_example;  // string | (Optional): The document type of the transaction to operate on. If omitted, defaults to \"SalesInvoice\" (optional) 

            try
            {
                // Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
                ShippingVerifyResult result = apiInstance.RegisterShipmentIfCompliant(companyCode, transactionCode, documentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingVerificationApi.RegisterShipmentIfCompliant: " + e.Message );
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
 **companyCode** | **string**| The company code of the company that recorded the transaction | 
 **transactionCode** | **string**| The transaction code to retrieve | 
 **documentType** | **string**| (Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; | [optional] 

### Return type

[**ShippingVerifyResult**](ShippingVerifyResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A ShippingVerifyResult object. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Invalid Transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="verifyshipment"></a>
# **VerifyShipment**
> ShippingVerifyResult VerifyShipment (string companyCode, string transactionCode, string documentType = null)

Evaluates a transaction against a set of direct-to-consumer shipping regulations.

The transaction and its lines must meet the following criteria in order to be evaluated: * The transaction must be recorded. Using a type of *SalesInvoice* is recommended. * A parameter with the name *AlcoholRouteType* must be specified and the value must be one of the following: '*DTC*', '*Retailer DTC*' * A parameter with the name *RecipientName* must be specified and the value must be the name of the recipient. * Each alcohol line must include a *ContainerSize* parameter that describes the volume of a single container. Use the *unit* field to specify one of the following units: '*Litre*', '*Millilitre*', '*gallon (US fluid)*', '*quart (US fluid)*', '*ounce (fluid US customary)*' * Each alcohol line must include a *PackSize* parameter that describes the number of containers in a pack. Specify *Count* in the *unit* field.  Optionally, the transaction and its lines may use the following parameters: * The *ShipDate* parameter may be used if the date of shipment is different than the date of the transaction. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *RecipientDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *PurchaserDOB* parameter may be used to evaluate age restrictions. The value should be ISO-8601 compliant (e.g. 2020-07-21). * The *SalesLocation* parameter may be used to describe whether the sale was made *OnSite* or *OffSite*. *OffSite* is the default value. * The *AlcoholContent* parameter may be used to describe the alcohol percentage by volume of the item. Specify *Percentage* in the *unit* field.  **Security Policies** This API depends on all of the following active subscriptions: *AvaAlcohol, AutoAddress, AvaTaxPro*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Avalara.SDK.Api;
using Avalara.SDK.Client;
using Avalara.SDK.Model;

namespace Example
{
    public class VerifyShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: Bearer
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShippingVerificationApi(config);
            var companyCode = companyCode_example;  // string | The company code of the company that recorded the transaction
            var transactionCode = transactionCode_example;  // string | The transaction code to retrieve
            var documentType = documentType_example;  // string | (Optional): The document type of the transaction to operate on. If omitted, defaults to \"SalesInvoice\" (optional) 

            try
            {
                // Evaluates a transaction against a set of direct-to-consumer shipping regulations.
                ShippingVerifyResult result = apiInstance.VerifyShipment(companyCode, transactionCode, documentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShippingVerificationApi.VerifyShipment: " + e.Message );
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
 **companyCode** | **string**| The company code of the company that recorded the transaction | 
 **transactionCode** | **string**| The transaction code to retrieve | 
 **documentType** | **string**| (Optional): The document type of the transaction to operate on. If omitted, defaults to \&quot;SalesInvoice\&quot; | [optional] 

### Return type

[**ShippingVerifyResult**](ShippingVerifyResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A ShippingVerifyResult object. |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |
| **409** | Invalid Transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

