
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.BuildV1
{
    using System;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class GetBuildsRequest
    {
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, GetBuildsRequest value, string baseUrl)
        {
            if("GetBuilds" == operationId)
            {
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                // #request-debugging A, method "get"
                var urlString = baseUrl + $"/builds/v1/{appId}/list";// #request-debugging, method "Get"
                UnityWebRequest message = UnityWebRequest.Get(urlString);
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [GetBuildsRequest]");
        }
    }

}