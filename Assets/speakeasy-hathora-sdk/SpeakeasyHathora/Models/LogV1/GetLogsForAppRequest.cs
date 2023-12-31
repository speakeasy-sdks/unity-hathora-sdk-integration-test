
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.LogV1
{
    using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class GetLogsForAppRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("follow")]
        public bool? Follow { get; set; }
        
    /// <summary>
    /// Available regions to request a game server.
    /// </summary>
        
        [JsonProperty("region")]
        public Region? Region { get; set; }
        
        
        [JsonProperty("tailLines")]
        public int? TailLines { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, GetLogsForAppRequest value, string baseUrl)
        {
            if("GetLogsForApp" == operationId)
            {
                var queryParams = new List<string>();
                
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "follow", "", value.Follow));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "region", "", value.Region));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "tailLines", "", value.TailLines));
                var queryParamString = $"?{String.Join("&", queryParams)}";
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                
                
                // #request-debugging A, method "get"
                var urlString = baseUrl + $"/logs/v1/{appId}/all" + queryParamString;// #request-debugging, method "Get"
                UnityWebRequest message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [GetLogsForAppRequest]");
        }
    }

}