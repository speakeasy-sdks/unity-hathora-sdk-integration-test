
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.AppV1
{
    using System;
using UnityEngine.Networking;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class UpdateAppRequest
    {
        
        [JsonProperty("AppConfig")]
        public AppConfig AppConfig { get; set; }
        
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, UpdateAppRequest value, string baseUrl)
        {
            if("UpdateApp" == operationId)
            {
                
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                string json = JsonConvert.SerializeObject(value.AppConfig, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                // #request-debugging A, method "post"
                var urlString = baseUrl + $"/apps/v1/update/{appId}";
                UnityWebRequest  message = UnityWebRequest.Post(urlString, json, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [UpdateAppRequest]");
        }
    }

}