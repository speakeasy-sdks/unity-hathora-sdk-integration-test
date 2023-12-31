
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.Shared
{
    using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Models.Shared;
    using System.Collections.Generic;
/// <summary>
/// A container port object represents the transport configruations for how your server will listen.
/// </summary>
    public class ContainerPort
    {
    /// <summary>
    /// Readable name for the port.
    /// </summary>
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        
        [JsonProperty("port")]
        public int Port { get; set; }
        
    /// <summary>
    /// Transport type specifies the underlying communication protocol to the exposed port.
    /// </summary>
        
        [JsonProperty("transportType")]
        public TransportType TransportType { get; set; }
        
    }

}