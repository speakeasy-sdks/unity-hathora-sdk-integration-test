
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
    using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class DestroyRoomSecurity
    {
        
        [JsonProperty("auth0")]
        public string Auth0 { get; set; }
        
        // Operation security
        public static void Apply(DestroyRoomSecurity security, UnityWebRequest message)
        {
            if(security == null)
            {
                return;
            }
            if(security.Auth0 != null)
            {
                message.SetRequestHeader("Authorization", Utilities.PrefixBearer(Utilities.ToString(security.Auth0)));
            }
        }
    }

}