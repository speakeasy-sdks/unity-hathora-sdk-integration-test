
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.LobbyV1
{
    using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using Newtonsoft.Json;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class CreatePublicLobbyDeprecatedRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("local")]
        public bool? Local { get; set; }
        
    /// <summary>
    /// Available regions to request a game server.
    /// </summary>
        
        [JsonProperty("region")]
        public Region? Region { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, CreatePublicLobbyDeprecatedRequest value, string baseUrl)
        {
            if("CreatePublicLobbyDeprecated" == operationId)
            {
                var queryParams = new List<string>();
                
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "local", "", value.Local));
                
                queryParams.Add(QueryParamSerializer.Serialize("form",true, "region", "", value.Region));
                var queryParamString = $"?{String.Join("&", queryParams)}";
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var urlString = baseUrl + $"/lobby/v1/{appId}/create/public" + queryParamString;// #request-debugging post TODO: work in progress
                UnityWebRequest message;// cannot make a HttpMethod Post call in Unity without content (?)
                message = new UnityWebRequest(urlString);
                
                
                
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [CreatePublicLobbyDeprecatedRequest]");
        }
    }

}