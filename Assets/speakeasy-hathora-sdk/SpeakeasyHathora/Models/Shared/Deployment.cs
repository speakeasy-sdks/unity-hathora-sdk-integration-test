
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
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using SpeakeasyHathora.Models.Shared;
    using System.Collections.Generic;
/// <summary>
/// Deployment is a versioned configuration for a build that describes runtime behavior.
/// </summary>
    public class Deployment
    {
    /// <summary>
    /// Additional ports your server listens on.
    /// </summary>
        
        [JsonProperty("additionalContainerPorts")]
        public List<ContainerPort> AdditionalContainerPorts { get; set; }
        
    /// <summary>
    /// System generated unique identifier for an application.
    /// </summary>
        
        [JsonProperty("appId")]
        public string AppId { get; set; }
        
    /// <summary>
    /// System generated id for a build associated with this deployment. Increments by 1.
    /// </summary>
        
        [JsonProperty("buildId")]
        public int BuildId { get; set; }
        
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("containerPort")]
        public float ContainerPort { get; set; }
        
    /// <summary>
    /// When the deployment was created.
    /// </summary>
        
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
        
    /// <summary>
    /// Email address for the user that created the deployment.
    /// </summary>
        
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
        
    /// <summary>
    /// A container port object represents the transport configruations for how your server will listen.
    /// </summary>
        
        [JsonProperty("defaultContainerPort")]
        public ContainerPort DefaultContainerPort { get; set; }
        
    /// <summary>
    /// System generated id for a deployment. Increments by 1.
    /// </summary>
        
        [JsonProperty("deploymentId")]
        public int DeploymentId { get; set; }
        
    /// <summary>
    /// The environment variable that our process will have access to at runtime.
    /// </summary>
        
        [JsonProperty("env")]
        public List<DeploymentEnv> Env { get; set; }
        
    /// <summary>
    /// A plan defines how much CPU and memory is required to run an instance of your game server.
    /// 
    /// <remarks>
    /// 
    /// `tiny`: shared core, 1gb memory
    /// 
    /// `small`: 1 core, 2gb memory
    /// 
    /// `medium`: 2 core, 4gb memory
    /// 
    /// `large`: 4 core, 8gb memory
    /// </remarks>
    /// </summary>
        
        [JsonProperty("planName")]
        public PlanName PlanName { get; set; }
        
    /// <summary>
    /// The number of cores allocated to your process.
    /// </summary>
        
        [JsonProperty("requestedCPU")]
        public float RequestedCPU { get; set; }
        
    /// <summary>
    /// The amount of memory allocated to your process.
    /// </summary>
        
        [JsonProperty("requestedMemoryMB")]
        public float RequestedMemoryMB { get; set; }
        
    /// <summary>
    /// Governs how many [rooms](https://hathora.dev/docs/concepts/hathora-entities#room) can be scheduled in a process.
    /// </summary>
        
        [JsonProperty("roomsPerProcess")]
        public int RoomsPerProcess { get; set; }
        
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [JsonProperty("transportType")]
        public DeploymentTransportType TransportType { get; set; }
        
    }

}