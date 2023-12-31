# appV1

## Overview

Operations that allow you manage your [applications](https://hathora.dev/docs/concepts/hathora-entities#application).

### Available Operations

* [CreateApp](#createapp) - Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).
* [DeleteApp](#deleteapp) - Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.
* [GetAppInfo](#getappinfo) - Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
* [GetApps](#getapps) - Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.
* [UpdateApp](#updateapp) - Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

## CreateApp

Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.AppV1;
using SpeakeasyHathora.Models.Shared;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.AppV1.CreateAppAsync(new CreateAppSecurity() {
    Auth0 = "",
}, new AppConfig() {
    AppName = "minecraft",
    AuthConfiguration = new AppConfigAuthConfiguration() {
        Anonymous = new RecordStringNever() {},
        Google = new AppConfigAuthConfigurationGoogle() {
            ClientId = "provident",
        },
        Nickname = new RecordStringNever() {},
    },
});
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [AppConfig](../../Models/Shared/AppConfig.md)                | :heavy_check_mark:                                           | The request object to use for the request.                   |
| `security`                                                   | [CreateAppSecurity](../../Models/AppV1/CreateAppSecurity.md) | :heavy_check_mark:                                           | The security requirements to use for the request.            |


### Response

**[CreateAppResponse](../../Models/AppV1/CreateAppResponse.md)**


## DeleteApp

Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.AppV1;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.AppV1.DeleteAppAsync(new DeleteAppSecurity() {
    Auth0 = "",
}, new DeleteAppRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [DeleteAppRequest](../../Models/AppV1/DeleteAppRequest.md)   | :heavy_check_mark:                                           | The request object to use for the request.                   |
| `security`                                                   | [DeleteAppSecurity](../../Models/AppV1/DeleteAppSecurity.md) | :heavy_check_mark:                                           | The security requirements to use for the request.            |


### Response

**[DeleteAppResponse](../../Models/AppV1/DeleteAppResponse.md)**


## GetAppInfo

Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.AppV1;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.AppV1.GetAppInfoAsync(new GetAppInfoSecurity() {
    Auth0 = "",
}, new GetAppInfoRequest() {
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                      | Type                                                           | Required                                                       | Description                                                    |
| -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- | -------------------------------------------------------------- |
| `request`                                                      | [GetAppInfoRequest](../../Models/AppV1/GetAppInfoRequest.md)   | :heavy_check_mark:                                             | The request object to use for the request.                     |
| `security`                                                     | [GetAppInfoSecurity](../../Models/AppV1/GetAppInfoSecurity.md) | :heavy_check_mark:                                             | The security requirements to use for the request.              |


### Response

**[GetAppInfoResponse](../../Models/AppV1/GetAppInfoResponse.md)**


## GetApps

Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.AppV1;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.AppV1.GetAppsAsync(new GetAppsSecurity() {
    Auth0 = "",
});
```

### Parameters

| Parameter                                                | Type                                                     | Required                                                 | Description                                              |
| -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- | -------------------------------------------------------- |
| `security`                                               | [GetAppsSecurity](../../Models/AppV1/GetAppsSecurity.md) | :heavy_check_mark:                                       | The security requirements to use for the request.        |


### Response

**[GetAppsResponse](../../Models/AppV1/GetAppsResponse.md)**


## UpdateApp

Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.AppV1;
using SpeakeasyHathora.Models.Shared;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.AppV1.UpdateAppAsync(new UpdateAppSecurity() {
    Auth0 = "",
}, new UpdateAppRequest() {
    AppConfig = new AppConfig() {
        AppName = "minecraft",
        AuthConfiguration = new AppConfigAuthConfiguration() {
            Anonymous = new RecordStringNever() {},
            Google = new AppConfigAuthConfigurationGoogle() {
                ClientId = "distinctio",
            },
            Nickname = new RecordStringNever() {},
        },
    },
    AppId = "app-af469a92-5b45-4565-b3c4-b79878de67d2",
});
```

### Parameters

| Parameter                                                    | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `request`                                                    | [UpdateAppRequest](../../Models/Shared/UpdateAppRequest.md)  | :heavy_check_mark:                                           | The request object to use for the request.                   |
| `security`                                                   | [UpdateAppSecurity](../../Models/AppV1/UpdateAppSecurity.md) | :heavy_check_mark:                                           | The security requirements to use for the request.            |


### Response

**[UpdateAppResponse](../../Models/AppV1/UpdateAppResponse.md)**

