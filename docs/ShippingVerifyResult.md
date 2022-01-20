# Avalara.SDK.Model.ShippingVerifyResult
The Response of the /shippingverify endpoint. Describes the result of checking all applicable shipping rules against each line in the transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Compliant** | **bool** | Whether every line in the transaction is compliant. | [optional] 
**Message** | **string** | A short description of the result of the compliance check. | [optional] 
**SuccessMessages** | **string** | A detailed description of the result of each of the passed checks made against this transaction, separated by line. | [optional] 
**FailureMessages** | **string** | A detailed description of the result of each of the failed checks made against this transaction, separated by line. | [optional] 
**FailureCodes** | **List&lt;string&gt;** | An enumeration of all the failure codes received across all lines. | [optional] 
**WarningCodes** | **List&lt;string&gt;** | An enumeration of all the warning codes received across all lines that a determination could not be made for. | [optional] 
**Lines** | [**List&lt;ShippingVerifyResultLines&gt;**](ShippingVerifyResultLines.md) | Describes the results of the checks made for each line in the transaction. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

