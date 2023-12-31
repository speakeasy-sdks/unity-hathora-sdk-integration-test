
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace SpeakeasyHathora
{
    using System;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Threading.Tasks;
using SpeakeasyHathora.AppV1;
using SpeakeasyHathora.AuthV1;
using SpeakeasyHathora.BillingV1;
using SpeakeasyHathora.BuildV1;
using SpeakeasyHathora.DeploymentV1;
using SpeakeasyHathora.DiscoveryV1;
using SpeakeasyHathora.LobbyV1;
using SpeakeasyHathora.LobbyV2;
using SpeakeasyHathora.LogV1;
using SpeakeasyHathora.ManagementV1;
using SpeakeasyHathora.MetricsV1;
using SpeakeasyHathora.ProcessesV1;
using SpeakeasyHathora.RoomV2;
using SpeakeasyHathora.Utils;

    public interface ISpeakeasyHathoraSDK
    {
        public IAppV1SDK AppV1 { get; }
        public IAuthV1SDK AuthV1 { get; }
        public IBillingV1SDK BillingV1 { get; }
        public IBuildV1SDK BuildV1 { get; }
        public IDeploymentV1SDK DeploymentV1 { get; }
        public IDiscoveryV1SDK DiscoveryV1 { get; }
        public ILobbyV1SDK LobbyV1 { get; }
        public ILobbyV2SDK LobbyV2 { get; }
        public ILogV1SDK LogV1 { get; }
        public IManagementV1SDK ManagementV1 { get; }
        public IMetricsV1SDK MetricsV1 { get; }
        public IProcessesV1SDK ProcessesV1 { get; }
        public IRoomV2SDK RoomV2 { get; }
    }public class SDKConfig
    {
    }

    public class SpeakeasyHathoraSDK: ISpeakeasyHathoraSDK
    {
        public SDKConfig Config { get; private set; }
        public static List<string> ServerList = new List<string>()
        {
            "https://api.hathora.dev",
            "/",
        };

        private const string _language = "csharp";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "internal";
        private const string _openapiDocVersion = "0.0.1";
        // TODO: code review, is more work required here to convert to a base URL?
        public Uri ServerUrl { get { return new Uri(_defaultClient.Client.url); } }
        private SpeakeasyHttpClient _defaultClient;
        private SpeakeasyHttpClient _securityClient;
        public IAppV1SDK AppV1 { get; private set; }
        public IAuthV1SDK AuthV1 { get; private set; }
        public IBillingV1SDK BillingV1 { get; private set; }
        public IBuildV1SDK BuildV1 { get; private set; }
        public IDeploymentV1SDK DeploymentV1 { get; private set; }
        public IDiscoveryV1SDK DiscoveryV1 { get; private set; }
        public ILobbyV1SDK LobbyV1 { get; private set; }
        public ILobbyV2SDK LobbyV2 { get; private set; }
        public ILogV1SDK LogV1 { get; private set; }
        public IManagementV1SDK ManagementV1 { get; private set; }
        public IMetricsV1SDK MetricsV1 { get; private set; }
        public IProcessesV1SDK ProcessesV1 { get; private set; }
        public IRoomV2SDK RoomV2 { get; private set; }

        public SpeakeasyHathoraSDK(UnityWebRequest? client = null, string? serverUrl = null)
        {
            _defaultClient = new SpeakeasyHttpClient(client);
            if(client == null)
            {
                var _serverUrl = serverUrl ?? SpeakeasyHathoraSDK.ServerList[0];

                _defaultClient.SetBaseUrl(_serverUrl);
            }
            _securityClient = new SpeakeasyHttpClient(_defaultClient.Client);

            Config = new SDKConfig()
            {
            };
            AppV1 = new AppV1SDK(_defaultClient, _securityClient, Config);
            AuthV1 = new AuthV1SDK(_defaultClient, _securityClient, Config);
            BillingV1 = new BillingV1SDK(_defaultClient, _securityClient, Config);
            BuildV1 = new BuildV1SDK(_defaultClient, _securityClient, Config);
            DeploymentV1 = new DeploymentV1SDK(_defaultClient, _securityClient, Config);
            DiscoveryV1 = new DiscoveryV1SDK(_defaultClient, _securityClient, Config);
            LobbyV1 = new LobbyV1SDK(_defaultClient, _securityClient, Config);
            LobbyV2 = new LobbyV2SDK(_defaultClient, _securityClient, Config);
            LogV1 = new LogV1SDK(_defaultClient, _securityClient, Config);
            ManagementV1 = new ManagementV1SDK(_defaultClient, _securityClient, Config);
            MetricsV1 = new MetricsV1SDK(_defaultClient, _securityClient, Config);
            ProcessesV1 = new ProcessesV1SDK(_defaultClient, _securityClient, Config);
            RoomV2 = new RoomV2SDK(_defaultClient, _securityClient, Config);
        }
    }
}