using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using TMPro;


using SpeakeasyHathora;
using SpeakeasyHathora.Models.RoomV2;
using SpeakeasyHathora.Models.Shared;
using CreateRoomRequest = SpeakeasyHathora.Models.RoomV2.CreateRoomRequest;

using SpeakeasyHathora;
using SpeakeasyHathora.Models.AuthV1;
using System;
using System.Runtime.CompilerServices;

/// <summary>
/// Test controller to use with Speakeasy generated code
/// </summary>
public class TestAPIController : MonoBehaviour
{
    [SerializeField]
    TMP_Text statusText;

    /// <summary>
    /// The app id can be obtained from the Hathora web console:
    /// https://console.hathora.dev/overview
    /// </summary>
    [SerializeField]
    string appId = "change me";

    string auth = "";
    string roomId = "2swovpy1fnunu";

    /// <summary>
    /// Speakeasy Hathora SDK.
    /// </summary>
    SpeakeasyHathoraSDK sdk;

    // Start is called before the first frame update
    void Start()
    {
        InitSDKClient();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void InitSDKClient()
    {
        sdk = new SpeakeasyHathoraSDK();
        statusText.text = $"server url '{sdk.ServerUrl.ToString()}'";
    }

    #region UI actions

    public void ActionClientAuthAsync()
    {
        Debug.Log("ActionClientAuthAsync");
        TestClientAuthAsync();
    }

    #endregion


    /// <summary>
    /// clientApis.ClientAuthApi.ClientAuthAsync()
    /// </summary>
    /// <returns></returns>
    private async void TestClientAuthAsync()
    {
        // login anonymously

        LoginAnonymousResponse res = await sdk.AuthV1.LoginAnonymousAsync(new LoginAnonymousRequest() {
            AppId = appId,
        });

        if (res.RawResponse.error != null)
        {
            var errorString = $"Error: {res.RawResponse.error}";
            Debug.LogError(errorString);
            statusText.text = errorString;
        }
        else
        {
            statusText.text = $"response status code {res.StatusCode.ToString()}";
            Debug.Log($"response {res.StatusCode}");
            Debug.Log($"response {res.RawResponse.result}");
        }


        // handle exceptions

        // check is authorized
    }

    /// <summary>
    /// clientApis.ClientLobbyApi.ClientCreateLobbyAsync()
    /// </summary>
    private void TestClientCreateLobbyAsync()
    {

    }

    /// <summary>
    /// clientApis.ClientLobbyApi.ClientGetLobbyInfoAsync()
    /// </summary>
    /// <returns></returns>
    private void TestClientGetLobbyInfoAsync()
    {

    }

    /// <summary>
    /// clientApis.ClientLobbyApi.ClientListPublicLobbiesAsync()
    /// </summary>
    /// <returns></returns>
    private void TestClientListPublicLobbiesAsync()
    {

    }

    /// <summary>
    /// clientApis.ClientRoomApi.ClientGetConnectionInfoAsync()
    /// </summary>
    /// <returns></returns>
    private void TestClientGetConnectionInfoAsync()
    {

    }

    public async Task CreateRoomAsync()
    {
        Debug.Log("Create room using Speakeasy");

        var sdk = new SpeakeasyHathoraSDK();

        var security = new CreateRoomSecurity()
        {
            Auth0 = "",
        };

        // setting the region info is missing!
        var roomRequest = new CreateRoomRequest()
        {
            AppId = appId,
            RoomId = roomId,
        };

        var res = await sdk.RoomV2.CreateRoomAsync(security, roomRequest);

        // examine the room info

    }
}
