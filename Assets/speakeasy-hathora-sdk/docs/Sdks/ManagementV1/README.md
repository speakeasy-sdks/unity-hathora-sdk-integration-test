# managementV1

### Available Operations

* [SendVerificationEmail](#sendverificationemail)

## SendVerificationEmail

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.ManagementV1;
using SpeakeasyHathora.Models.Shared;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.ManagementV1.SendVerificationEmailAsync(new VerificationEmailRequest() {
    UserId = "nisi",
});
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [VerificationEmailRequest](../../Models/Shared/VerificationEmailRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |


### Response

**[SendVerificationEmailResponse](../../Models/ManagementV1/SendVerificationEmailResponse.md)**

