
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora.Utils
{
    using System;
    using System.Collections.Generic;
    using UnityEngine.Networking;
    using System.Threading.Tasks;

    public class SpeakeasyHttpClient
    {
        public UnityWebRequest Client { get; private set; }
        private Dictionary<string, string> _headers { get; } = new Dictionary<string, string>();

        internal SpeakeasyHttpClient(UnityWebRequest client)
        {
            if(client == null)
            {
                client = new UnityWebRequest();
            }
            Client = client;
        }

        public void SetBaseUrl(string url)
        {
            Client.uri = new Uri(url);
        }

        public void AddHeader(string key, string value)
        {
            // TODO: code review
            _headers.Add(key, value);
        }

        public async Task<UnityWebRequest> SendAsync(UnityWebRequest message)
        {
            foreach(var h in _headers)
            {
                message.SetRequestHeader(h.Key, h.Value);
            }

            // TODO: code review, this compiles but is it correct
            await message.SendWebRequest();
            return message;
        }
    }
}