
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Models.LobbyV2
{
    using UnityEngine.Networking;
using SpeakeasyHathora.Models.Shared;
    using System.Collections.Generic;
    public class CreatePublicLobbyResponse {
        public string? ContentType { get; set; }
        
        public string? CreatePublicLobby400ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobby401ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobby404ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobby422ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobby429ApplicationJSONString { get; set; }
        
        public string? CreatePublicLobby500ApplicationJSONString { get; set; }
        
        public Lobby? Lobby { get; set; }
        
        public int StatusCode { get; set; }
        
        public UnityWebRequest? RawResponse { get; set; }
        
    }

}