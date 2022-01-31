# Avalara.SDK - the C# library for the Avalara Shipping Verification only

API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.

This API is currently in beta.


This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 3.1.0
- SDK version: 2.4.5.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Avalara.SDK.Api;
using Avalara.SDK.Client;
using Avalara.SDK.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Avalara.SDK.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Avalara.SDK.Api;
using Avalara.SDK.Client;
using Avalara.SDK.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: Bearer
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AgeVerificationApi(config);
            var ageVerifyRequest = new AgeVerifyRequest(); // AgeVerifyRequest | Information about the individual whose age is being verified.
            var simulatedFailureCode = ;  // AgeVerifyFailureCode? | (Optional) The failure code included in the simulated response of the endpoint. Note that this endpoint is only available in Sandbox for testing purposes. (optional) 

            try
            {
                // Determines whether an individual meets or exceeds the minimum legal drinking age.
                AgeVerifyResult result = apiInstance.VerifyAge(ageVerifyRequest, simulatedFailureCode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AgeVerificationApi.VerifyAge: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *http://localhost*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AgeVerificationApi* | [**VerifyAge**](docs/AgeVerificationApi.md#verifyage) | **POST** /api/v2/ageverification/verify | Determines whether an individual meets or exceeds the minimum legal drinking age.
*ShippingVerificationApi* | [**DeregisterShipment**](docs/ShippingVerificationApi.md#deregistershipment) | **DELETE** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration | Removes the transaction from consideration when evaluating regulations that span multiple transactions.
*ShippingVerificationApi* | [**RegisterShipment**](docs/ShippingVerificationApi.md#registershipment) | **PUT** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registration | Registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
*ShippingVerificationApi* | [**RegisterShipmentIfCompliant**](docs/ShippingVerificationApi.md#registershipmentifcompliant) | **PUT** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/registerIfCompliant | Evaluates a transaction against a set of direct-to-consumer shipping regulations and, if compliant, registers the transaction so that it may be included when evaluating regulations that span multiple transactions.
*ShippingVerificationApi* | [**VerifyShipment**](docs/ShippingVerificationApi.md#verifyshipment) | **GET** /api/v2/companies/{companyCode}/transactions/{transactionCode}/shipment/verify | Evaluates a transaction against a set of direct-to-consumer shipping regulations.


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AgeVerifyFailureCode](docs/AgeVerifyFailureCode.md)
 - [Model.AgeVerifyRequest](docs/AgeVerifyRequest.md)
 - [Model.AgeVerifyRequestAddress](docs/AgeVerifyRequestAddress.md)
 - [Model.AgeVerifyResult](docs/AgeVerifyResult.md)
 - [Model.ErrorDetails](docs/ErrorDetails.md)
 - [Model.ErrorDetailsError](docs/ErrorDetailsError.md)
 - [Model.ErrorDetailsErrorDetails](docs/ErrorDetailsErrorDetails.md)
 - [Model.ShippingVerifyResult](docs/ShippingVerifyResult.md)
 - [Model.ShippingVerifyResultLines](docs/ShippingVerifyResultLines.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="BasicAuth"></a>
### BasicAuth

- **Type**: HTTP basic authentication

<a name="Bearer"></a>
### Bearer

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

