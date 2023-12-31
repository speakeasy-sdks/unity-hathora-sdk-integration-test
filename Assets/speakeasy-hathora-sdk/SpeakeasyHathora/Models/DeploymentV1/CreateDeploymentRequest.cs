
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.DeploymentV1
{
    using System;
using UnityEngine.Networking;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Models.Shared;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class CreateDeploymentRequest
    {
        
        [JsonProperty("DeploymentConfig")]
        public DeploymentConfig DeploymentConfig { get; set; }
        
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
        
        [JsonProperty("buildId")]
        public int BuildId { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, CreateDeploymentRequest value, string baseUrl)
        {
            if("CreateDeployment" == operationId)
            {
                
                
                var appId = PathParamSerializer.Serialize("simple", false, value.AppId);
                
                var buildId = PathParamSerializer.Serialize("simple", false, value.BuildId);
                string json = JsonConvert.SerializeObject(value.DeploymentConfig, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                // #request-debugging A, method "post"
                var urlString = baseUrl + $"/deployments/v1/{appId}/create/{buildId}";
                UnityWebRequest  message = UnityWebRequest.Post(urlString, json, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [CreateDeploymentRequest]");
        }
    }

}