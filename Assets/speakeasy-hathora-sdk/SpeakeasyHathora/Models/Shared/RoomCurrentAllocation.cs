
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
    using System;
using Newtonsoft.Json;
using UnityEngine;
    using System.Collections.Generic;
/// <summary>
/// Metadata on allocated instances of a room.
/// </summary>
    public class RoomCurrentAllocation
    {
    /// <summary>
    /// System generated unique identifier to a runtime instance of your game server.
    /// </summary>
        
        [JsonProperty("processId")]
        public string ProcessId { get; set; }
        
    /// <summary>
    /// System generated unique identifier to an allocated instance of a room.
    /// </summary>
        
        [JsonProperty("roomAllocationId")]
        public string RoomAllocationId { get; set; }
        
        
        [JsonProperty("scheduledAt")]
        public DateTime ScheduledAt { get; set; }
        
        
        [JsonProperty("unscheduledAt")]
        public DateTime UnscheduledAt { get; set; }
        
    }

}