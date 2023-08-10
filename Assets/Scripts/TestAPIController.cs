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
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    #region UI

    public async Task CreateRoomAsync()
    {
        Debug.Log("Create room using Speakeasy");

        var sdk = new SpeakeasyHathoraSDK();

        var auth = "";
        var appId = "app-af469a92-5b45-4565-b3c4-b79878de67d2";
        var roomId = "2swovpy1fnunu";

        // TODO: update code
        //var res = await sdk.RoomV2.CreateRoomAsync(
        //    new CreateRoomSecurity()
        //    {
        //        Auth0 = auth,
        //    },
        //    new CreateRoomRequest()
        //    {
        //        CreateRoomRequestValue = "",
        //        AppId = appId,
        //        RoomId = roomId,
        //    });

        // examine the room info

    }

    public void GetConnectionInfoSpeakeasyAsync()
    {
        Debug.Log("Start Async task using Speakeasy");
    }

    #endregion
}
