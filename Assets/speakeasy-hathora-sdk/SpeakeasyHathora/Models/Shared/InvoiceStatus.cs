
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
    
    public enum InvoiceStatus
    {
    	[JsonProperty("pending")]
		Pending,
		[JsonProperty("paid")]
		Paid,
		[JsonProperty("overdue")]
		Overdue,
    }
}