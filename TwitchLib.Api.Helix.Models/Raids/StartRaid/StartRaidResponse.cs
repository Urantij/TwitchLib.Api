﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Raids.StartRaid;

/// <summary>
/// Start raid response object.
/// </summary>
public class StartRaidResponse
{
    /// <summary>
    /// A list that contains a single object with information about the pending raid.
    /// </summary>
    [JsonPropertyName("data")]
    public Raid[] Data { get; protected set; }
}
