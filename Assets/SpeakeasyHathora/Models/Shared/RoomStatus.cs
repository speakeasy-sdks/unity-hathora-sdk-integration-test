
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
    
    /// <summary>
    /// The allocation status of a room.
    /// 
    /// <remarks>
    /// 
    /// `scheduling`: a process is not allocated yet and the room is waiting to be scheduled
    /// 
    /// `active`: ready to accept connections
    /// 
    /// `suspended`: room is unallocated from the process but can be rescheduled later with the same `roomId`
    /// 
    /// `destroyed`: all associated metadata is deleted
    /// </remarks>
    /// </summary>
    public enum RoomStatus
    {
    	[JsonProperty("scheduling")]
		Scheduling,
		[JsonProperty("active")]
		Active,
		[JsonProperty("suspended")]
		Suspended,
		[JsonProperty("destroyed")]
		Destroyed,
    }
}