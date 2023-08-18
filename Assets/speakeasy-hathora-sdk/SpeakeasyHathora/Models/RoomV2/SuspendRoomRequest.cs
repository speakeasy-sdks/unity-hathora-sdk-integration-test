
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.RoomV2
{
    using System;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class SuspendRoomRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("roomId")]
        public string RoomId { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, SuspendRoomRequest value, string baseUrl)
        {
            if("SuspendRoom" == operationId)
            {
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var roomId = PathParamSerializer.Serialize("simple", false, value.RoomId);
                // #request-debugging A, method "post"
                var urlString = baseUrl + $"/rooms/v2/{appId}/suspend/{roomId}";UnityWebRequest  message = new UnityWebRequest(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [SuspendRoomRequest]");
        }
    }

}