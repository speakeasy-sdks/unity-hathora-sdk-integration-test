
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.MetricsV1
{
    using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpeakeasyHathora.Models.MetricsV1;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;

    public interface IMetricsV1SDK
    {
        Task<GetMetricsResponse> GetMetricsAsync(GetMetricsSecurity security, GetMetricsRequest? request = null);
    }

    public class MetricsV1SDK: IMetricsV1SDK
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

        public MetricsV1SDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    /// <summary>
    /// Get metrics for a [process](https://hathora.dev/docs/concepts/hathora-entities#process) using `appId` and `processId`.
    /// </summary>
    public async Task<GetMetricsResponse> GetMetricsAsync(GetMetricsSecurity security, GetMetricsRequest? request = null)
    {
        string baseUrl = "";
        var message = GetMetricsRequest.BuildHttpRequestMessage("GetMetrics", request, baseUrl);
        var client = _defaultClient;
        GetMetricsSecurity.Apply(security, message);

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new GetMetricsResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.MetricsResponse = JsonConvert.DeserializeObject<MetricsResponse>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 404))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetMetrics404ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        if((response.StatusCode == 422))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.GetMetrics422ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    }
}