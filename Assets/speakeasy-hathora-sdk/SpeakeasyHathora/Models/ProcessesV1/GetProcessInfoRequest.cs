
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.ProcessesV1
{
    using System;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class GetProcessInfoRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("processId")]
        public string ProcessId { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, GetProcessInfoRequest value, string baseUrl)
        {
            if("GetProcessInfo" == operationId)
            {
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var processId = PathParamSerializer.Serialize("simple", false, value.ProcessId);
                // #request-debugging A, method "get"
                var urlString = baseUrl + $"/processes/v1/{appId}/info/{processId}";// #request-debugging, method "Get"
                UnityWebRequest message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [GetProcessInfoRequest]");
        }
    }

}