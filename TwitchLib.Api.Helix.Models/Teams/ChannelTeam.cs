﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// A team the broadcaster is a member of.
/// </summary>
public class ChannelTeam : TeamBase
{
    /// <summary>
    /// An ID that identifies the broadcaster.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string BroadcasterName { get; protected set; }

    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }
}