# ory_kratos_client.model.Message

## Load the model package
```dart
import 'package:ory_kratos_client/api.dart';
```

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**body** | **String** |  | 
**createdAt** | [**DateTime**](DateTime.md) | CreatedAt is a helper struct field for gobuffalo.pop. | 
**dispatches** | [**BuiltList&lt;MessageDispatch&gt;**](MessageDispatch.md) | Dispatches store information about the attempts of delivering a message May contain an error if any happened, or just the `success` state. | [optional] 
**id** | **String** |  | 
**recipient** | **String** |  | 
**sendCount** | **int** |  | 
**status** | [**CourierMessageStatus**](CourierMessageStatus.md) |  | 
**subject** | **String** |  | 
**templateType** | **String** |  recovery_invalid TypeRecoveryInvalid recovery_valid TypeRecoveryValid recovery_code_invalid TypeRecoveryCodeInvalid recovery_code_valid TypeRecoveryCodeValid verification_invalid TypeVerificationInvalid verification_valid TypeVerificationValid verification_code_invalid TypeVerificationCodeInvalid verification_code_valid TypeVerificationCodeValid otp TypeOTP stub TypeTestStub | 
**type** | [**CourierMessageType**](CourierMessageType.md) |  | 
**updatedAt** | [**DateTime**](DateTime.md) | UpdatedAt is a helper struct field for gobuffalo.pop. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


