
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
/// Make all properties in T optional
/// </summary>
    public class PaymentMethod
    {
        
        [JsonProperty("ach")]
        public AchPaymentMethod? Ach { get; set; }
        
        
        [JsonProperty("card")]
        public CardPaymentMethod? Card { get; set; }
        
        
        [JsonProperty("link")]
        public LinkPaymentMethod? Link { get; set; }
        
    }

}