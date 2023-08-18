<!-- Start SDK Example Usage -->


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
            ClientId = "corrupti",
        },
        Nickname = new RecordStringNever() {},
    },
});
```
<!-- End SDK Example Usage -->