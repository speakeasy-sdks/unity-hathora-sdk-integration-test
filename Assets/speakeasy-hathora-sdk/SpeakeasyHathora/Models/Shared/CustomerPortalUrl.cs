
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
using UnityEngine.Networking;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Utils;
    using System.Collections.Generic;
    public class CustomerPortalUrl
    {
        
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }
        
        internal static UnityWebRequest BuildHttpRequestMessage(string operationId, CustomerPortalUrl value, string baseUrl)
        {
            if("InitStripeCustomerPortalUrl" == operationId)
            {
                string json = JsonConvert.SerializeObject(value, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
                // #request-debugging A, method "post"
                var urlString = baseUrl + "/billing/v1/customerportalurl";
                UnityWebRequest  message = UnityWebRequest.Post(urlString, json, "application/json");
                return message;
            }
            throw new ArgumentException($"Attempt to build UnityWebRequest for invalid operationId [{operationId}] for request type [CustomerPortalUrl]");
        }
    }

}