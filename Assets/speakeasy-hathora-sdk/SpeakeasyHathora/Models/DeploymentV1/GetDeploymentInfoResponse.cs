
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
    using UnityEngine.Networking;
using SpeakeasyHathora.Models.Shared;
    using System.Collections.Generic;
    public class GetDeploymentInfoResponse {
        public string? ContentType { get; set; }
        
    /// <summary>
    /// Ok
    /// </summary>
        public Deployment? Deployment { get; set; }
        
        public string? GetDeploymentInfo404ApplicationJSONString { get; set; }
        
        public int StatusCode { get; set; }
        
        public UnityWebRequest? RawResponse { get; set; }
        
    }

}