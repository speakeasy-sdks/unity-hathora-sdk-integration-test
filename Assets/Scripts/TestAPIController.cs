using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Threading;
using System.Threading.Tasks;
using Hathora.Cloud.Sdk.Api;
using Hathora.Cloud.Sdk.Client;
using Hathora.Cloud.Sdk.Model;
using Hathora.Core.Scripts.Runtime.Client;

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

    public void CreateRoom()
    {
        Debug.Log("Create room using Speakeasy");
    }

    public void GetConnectionInfoSpeakeasyAsync()
    {
        Debug.Log("Start Async task using Speakeasy");
    }

    #endregion
}
