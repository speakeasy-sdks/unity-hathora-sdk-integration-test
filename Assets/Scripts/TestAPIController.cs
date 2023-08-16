using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading;
using System.Threading.Tasks;
using Hathora.Cloud.Sdk.Api;
using Hathora.Cloud.Sdk.Client;
using Hathora.Cloud.Sdk.Model;
using Hathora.Core.Scripts.Runtime.Client;

using SpeakeasyHathora;
using SpeakeasyHathora.Models.RoomV2;
using SpeakeasyHathora.Models.Shared;
using CreateRoomRequest = SpeakeasyHathora.Models.RoomV2.CreateRoomRequest;


/// <summary>
/// Test controller to use with Speakeasy generated code
/// </summary>
public class TestAPIController : MonoBehaviour
{
    string auth = "";
    string appId = "app-af469a92-5b45-4565-b3c4-b79878de67d2";
    string roomId = "2swovpy1fnunu";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
    private void TestClientAuthAsync()
    {
        // login anonymously

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
