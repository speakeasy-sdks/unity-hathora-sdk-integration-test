
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.AppV1
{
    using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpeakeasyHathora.Models.AppV1;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;

    public interface IAppV1SDK
    {
        Task<CreateAppResponse> CreateAppAsync(CreateAppSecurity security, AppConfig request);
        Task<DeleteAppResponse> DeleteAppAsync(DeleteAppSecurity security, DeleteAppRequest? request = null);
        Task<GetAppInfoResponse> GetAppInfoAsync(GetAppInfoSecurity security, GetAppInfoRequest? request = null);
        Task<GetAppsResponse> GetAppsAsync(GetAppsSecurity security);
        Task<UpdateAppResponse> UpdateAppAsync(UpdateAppSecurity security, UpdateAppRequest request);
    }

    public class AppV1SDK: IAppV1SDK
    {

        public SDKConfig Config { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        // TODO: code review, is this more work required here to convert to a base URL?
        public Uri ServerUrl { get { return new Uri(_defaultClient.Client.url); } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;

        public AppV1SDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Create a new [application](https://hathora.dev/docs/concepts/hathora-entities#application).
    /// </summary>
    public async Task<CreateAppResponse> CreateAppAsync(CreateAppSecurity security, AppConfig request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = AppConfig.BuildHttpRequestMessage("CreateApp", request, baseUrl);
        var client = _defaultClient;
        CreateAppSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new CreateAppResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Application = JsonConvert.DeserializeObject<Application>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateApp422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateApp500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Delete an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Your organization will lose access to this application.
    /// </summary>
    public async Task<DeleteAppResponse> DeleteAppAsync(DeleteAppSecurity security, DeleteAppRequest? request = null)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = DeleteAppRequest.BuildHttpRequestMessage("DeleteApp", request, baseUrl);
        var client = _defaultClient;
        DeleteAppSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new DeleteAppResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 204))
        {
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DeleteApp404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.DeleteApp500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Get details for an [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
    /// </summary>
    public async Task<GetAppInfoResponse> GetAppInfoAsync(GetAppInfoSecurity security, GetAppInfoRequest? request = null)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = GetAppInfoRequest.BuildHttpRequestMessage("GetAppInfo", request, baseUrl);
        var client = _defaultClient;
        GetAppInfoSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GetAppInfoResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Application = JsonConvert.DeserializeObject<Application>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetAppInfo404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Returns an unsorted list of your organization’s [applications](https://hathora.dev/docs/concepts/hathora-entities#application). An application is uniquely identified by an `appId`.
    /// </summary>
    public async Task<GetAppsResponse> GetAppsAsync(GetAppsSecurity security)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = UnityWebRequest.Get(baseUrl + "/apps/v1/list");
        var client = _defaultClient;
        GetAppsSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GetAppsResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.ApplicationWithDeployments = JsonConvert.DeserializeObject<List<ApplicationWithDeployment>>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Update data for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
    /// </summary>
    public async Task<UpdateAppResponse> UpdateAppAsync(UpdateAppSecurity security, UpdateAppRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = UpdateAppRequest.BuildHttpRequestMessage("UpdateApp", request, baseUrl);
        var client = _defaultClient;
        UpdateAppSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new UpdateAppResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Application = JsonConvert.DeserializeObject<Application>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.UpdateApp404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.UpdateApp500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    }
}