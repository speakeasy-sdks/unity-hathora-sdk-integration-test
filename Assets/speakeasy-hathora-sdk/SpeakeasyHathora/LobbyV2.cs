
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.LobbyV2
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpeakeasyHathora.Models.LobbyV2;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;

    public interface ILobbyV2SDK
    {
        Task<CreateLobbyResponse> CreateLobbyAsync(CreateLobbyRequest request);
        Task<CreateLocalLobbyResponse> CreateLocalLobbyAsync(CreateLocalLobbyRequest request);
        Task<CreatePrivateLobbyResponse> CreatePrivateLobbyAsync(CreatePrivateLobbyRequest request);
        Task<CreatePublicLobbyResponse> CreatePublicLobbyAsync(CreatePublicLobbyRequest request);
        Task<GetLobbyInfoResponse> GetLobbyInfoAsync(GetLobbyInfoRequest? request = null);
        Task<ListActivePublicLobbiesResponse> ListActivePublicLobbiesAsync(ListActivePublicLobbiesRequest? request = null);
        Task<SetLobbyStateResponse> SetLobbyStateAsync(SetLobbyStateSecurity security, SetLobbyStateRequest request);
    }

    public class LobbyV2SDK: ILobbyV2SDK
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

        public LobbyV2SDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Create a new [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) for an existing [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`.
    /// </summary>
    public async Task<CreateLobbyResponse> CreateLobbyAsync(CreateLobbyRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = CreateLobbyRequest.BuildHttpRequestMessage("CreateLobby", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new CreateLobbyResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobby = JsonConvert.DeserializeObject<Lobby>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 400))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLobby400ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 401))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLobby401ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLobby404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLobby422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 429))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLobby429ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLobby500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<CreateLocalLobbyResponse> CreateLocalLobbyAsync(CreateLocalLobbyRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = CreateLocalLobbyRequest.BuildHttpRequestMessage("CreateLocalLobby", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new CreateLocalLobbyResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobby = JsonConvert.DeserializeObject<Lobby>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 400))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLocalLobby400ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 401))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLocalLobby401ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLocalLobby404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLocalLobby422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 429))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLocalLobby429ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreateLocalLobby500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<CreatePrivateLobbyResponse> CreatePrivateLobbyAsync(CreatePrivateLobbyRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = CreatePrivateLobbyRequest.BuildHttpRequestMessage("CreatePrivateLobby", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new CreatePrivateLobbyResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobby = JsonConvert.DeserializeObject<Lobby>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 400))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePrivateLobby400ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 401))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePrivateLobby401ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePrivateLobby404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePrivateLobby422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 429))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePrivateLobby429ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePrivateLobby500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    [Obsolete("This method will be removed in a future release, please migrate away from it as soon as possible")]
    public async Task<CreatePublicLobbyResponse> CreatePublicLobbyAsync(CreatePublicLobbyRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = CreatePublicLobbyRequest.BuildHttpRequestMessage("CreatePublicLobby", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new CreatePublicLobbyResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 201))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobby = JsonConvert.DeserializeObject<Lobby>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 400))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePublicLobby400ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 401))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePublicLobby401ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePublicLobby404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePublicLobby422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 429))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePublicLobby429ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.CreatePublicLobby500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Get details for an existing [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`.
    /// </summary>
    public async Task<GetLobbyInfoResponse> GetLobbyInfoAsync(GetLobbyInfoRequest? request = null)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = GetLobbyInfoRequest.BuildHttpRequestMessage("GetLobbyInfo", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GetLobbyInfoResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobby = JsonConvert.DeserializeObject<Lobby>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetLobbyInfo404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Get all active [lobbies](https://hathora.dev/docs/concepts/hathora-entities#lobby) for a given [application](https://hathora.dev/docs/concepts/hathora-entities#application) using `appId`. Filter the array by optionally passing in a `region`.
    /// </summary>
    public async Task<ListActivePublicLobbiesResponse> ListActivePublicLobbiesAsync(ListActivePublicLobbiesRequest? request = null)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = ListActivePublicLobbiesRequest.BuildHttpRequestMessage("ListActivePublicLobbies", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new ListActivePublicLobbiesResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobbies = JsonConvert.DeserializeObject<List<Lobby>>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        return response;
    }

        
    /// <summary>
    /// Set the state of a [lobby](https://hathora.dev/docs/concepts/hathora-entities#lobby) using `appId` and `roomId`. State is intended to be set by the server and must be smaller than 1MB.
    /// </summary>
    public async Task<SetLobbyStateResponse> SetLobbyStateAsync(SetLobbyStateSecurity security, SetLobbyStateRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = SetLobbyStateRequest.BuildHttpRequestMessage("SetLobbyState", request, baseUrl);
        var client = _defaultClient;
        SetLobbyStateSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new SetLobbyStateResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.Lobby = JsonConvert.DeserializeObject<Lobby>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.SetLobbyState404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.SetLobbyState422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    }
}