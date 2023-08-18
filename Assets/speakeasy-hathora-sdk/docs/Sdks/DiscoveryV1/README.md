# discoveryV1

## Overview

Service that allows clients to directly ping all Hathora regions to get latency information

### Available Operations

* [GetPingServiceEndpoints](#getpingserviceendpoints) - Returns an array of all regions with a host and port that a client can directly ping.

## GetPingServiceEndpoints

Returns an array of all regions with a host and port that a client can directly ping.

### Example Usage

```unity
using SpeakeasyHathora;
using SpeakeasyHathora.Models.DiscoveryV1;

var sdk = new SpeakeasyHathoraSDK();

var res = await sdk.DiscoveryV1.GetPingServiceEndpointsAsync();
```


### Response

**[GetPingServiceEndpointsResponse](../../Models/DiscoveryV1/GetPingServiceEndpointsResponse.md)**

