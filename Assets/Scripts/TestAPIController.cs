using System.Collections;
using System.Collections.Generic;
using Hathora.Core.Scripts.Runtime.Client;
using Hathora.Demos._1_FishNetDemo.HathoraScripts.Client.ClientMgr;
using UnityEngine;

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

    public void GetConnectionInfoAsync()
    {
        Debug.Log("Start Async operation");
        // TODO: GetLobbyInfoAsync
        var hathora = HathoraClientSession.Singleton;
        var serverInfo = hathora.ServerConnectionInfo;
        if (serverInfo != null)
        {
            Debug.Log($"server status: {serverInfo.Status}, room: {serverInfo.RoomId}");
        }
        else
        {
            Debug.LogWarning("server info not available");
        }

        var manager = HathoraFishnetClientMgr.Singleton;

    }

    public void GetConnectionInfoSpeakeasyAsync()
    {
        Debug.Log("Start Async operation using Speakeasy");
    }

    #endregion
}
