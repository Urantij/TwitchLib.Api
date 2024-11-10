﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Users.Internal;

/// <summary>
/// User extension state.
/// </summary>
public class UserExtensionState
{
    /// <summary>
    /// A Boolean value that determines the extension’s activation state.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; protected set; }

    /// <summary>
    /// An ID that identifies the extension.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The extension’s version.
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; protected set; }

    /// <summary>
    /// User extension state.
    /// </summary>
    /// <param name="active">Active</param>
    /// <param name="id">Id</param>
    /// <param name="version">Version</param>
    public UserExtensionState(bool active, string id, string version)
    {
        Active = active;
        Id = id;
        Version = version;
    }
}
