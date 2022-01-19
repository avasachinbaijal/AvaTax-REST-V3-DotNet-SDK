# AvaTax-REST-V3-DotNet-SDK.Model.ShippingVerifyResultLines

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultCode** | **string** | Describes whether the line is compliant or not. In cases where a determination could not be made, resultCode will provide the reason why. | [optional] 
**LineNumber** | **string** | The lineNumber of the line evaluated. | [optional] 
**Message** | **string** | A short description of the result of the checks made against this line. | [optional] 
**SuccessMessages** | **string** | A detailed description of the result of each of the passed checks made against this line. | [optional] 
**FailureMessages** | **string** | A detailed description of the result of each of the failed checks made against this line. | [optional] 
**FailureCodes** | **List&lt;string&gt;** | An enumeration of all the failure codes received for this line. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

