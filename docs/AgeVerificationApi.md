# AvaTax-REST-V3-DotNet-SDK.Api.AgeVerificationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VerifyAge**](AgeVerificationApi.md#verifyage) | **POST** /api/v2/ageverification/verify | Determines whether an individual meets or exceeds the minimum legal drinking age.


<a name="verifyage"></a>
# **VerifyAge**
> AgeVerifyResult VerifyAge (AgeVerifyRequest ageVerifyRequest, AgeVerifyFailureCode? simulatedFailureCode = null)

Determines whether an individual meets or exceeds the minimum legal drinking age.

The request must meet the following criteria in order to be evaluated: * *firstName*, *lastName*, and *address* are required fields. * One of the following sets of attributes are required for the *address*:   * *line1, city, region*   * *line1, postalCode*  Optionally, the transaction and its lines may use the following parameters: * A *DOB* (Date of Birth) field. The value should be ISO-8601 compliant (e.g. 2020-07-21). * Beyond the required *address* fields above, a *country* field is permitted   * The valid values for this attribute are [*US, USA*]  **Security Policies** This API depends on the active subscription *AgeVerification*

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AvaTax-REST-V3-DotNet-SDK.Api;
using AvaTax-REST-V3-DotNet-SDK.Client;
using AvaTax-REST-V3-DotNet-SDK.Model;

namespace Example
{
    public class VerifyAgeExample
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

            var apiInstance = new AgeVerificationApi(config);
            var ageVerifyRequest = new AgeVerifyRequest(); // AgeVerifyRequest | Information about the individual whose age is being verified.
            var simulatedFailureCode = ;  // AgeVerifyFailureCode? | (Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional) 

            try
            {
                // Determines whether an individual meets or exceeds the minimum legal drinking age.
                AgeVerifyResult result = apiInstance.VerifyAge(ageVerifyRequest, simulatedFailureCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AgeVerificationApi.VerifyAge: " + e.Message );
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
 **ageVerifyRequest** | [**AgeVerifyRequest**](AgeVerifyRequest.md)| Information about the individual whose age is being verified. | 
 **simulatedFailureCode** | **AgeVerifyFailureCode?**| (Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. | [optional] 

### Return type

[**AgeVerifyResult**](AgeVerifyResult.md)

### Authorization

[BasicAuth](../README.md#BasicAuth), [Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | An AgeVerificationResult object. |  -  |
| **400** | Invalid Request Model |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

