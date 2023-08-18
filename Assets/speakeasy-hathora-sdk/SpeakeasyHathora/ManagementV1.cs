
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.ManagementV1
{
    using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpeakeasyHathora.Models.ManagementV1;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;

    public interface IManagementV1SDK
    {
        Task<SendVerificationEmailResponse> SendVerificationEmailAsync(VerificationEmailRequest request);
    }

    public class ManagementV1SDK: IManagementV1SDK
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

        public ManagementV1SDK(SpeakeasyHttpClient defaultClient, SpeakeasyHttpClient securityClient, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securityClient = securityClient;
            Config = config;
        }

        
    public async Task<SendVerificationEmailResponse> SendVerificationEmailAsync(VerificationEmailRequest request)
    {
        // #debug warning base url is an empty string
        string baseUrl = "";
        var message = VerificationEmailRequest.BuildHttpRequestMessage("SendVerificationEmail", request, baseUrl);
        var client = _defaultClient;

        message.SetRequestHeader("user-agent", $"speakeasy-sdk/{_language} {_sdkVersion} {_sdkGenVersion} {_openapiDocVersion}");
        var httpResponseMessage = await client.SendAsync(message);
        var contentType = httpResponseMessage.GetResponseHeader("Content-Type");
        var response = new SendVerificationEmailResponse
        {
            StatusCode = (int)httpResponseMessage.responseCode,
            ContentType = contentType,
            RawResponse = httpResponseMessage
        };
        if((response.StatusCode == 200))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.VerificationEmailResponse = JsonConvert.DeserializeObject<VerificationEmailResponse>(message.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer() }});
            }
            return response;
        }
        if((response.StatusCode == 500))
        {
            if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
            {
                response.SendVerificationEmail500ApplicationJSONString = httpResponseMessage.downloadHandler.text;
            }
            return response;
        }
        return response;
    }

        
    }
}