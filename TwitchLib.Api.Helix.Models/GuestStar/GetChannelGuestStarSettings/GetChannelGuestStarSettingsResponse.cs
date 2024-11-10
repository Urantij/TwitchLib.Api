﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar.GetChannelGuestStarSettings;

/// <summary>
/// Get channe geust star settings response object.
/// </summary>
public class GetChannelGuestStarSettingsResponse
{
    /// <summary>
    /// <para>A list that contains the channels guest star settings</para>
    /// </summary>
    [JsonPropertyName("data")]
    public GuestStarSettings[] Data { get; protected set; }
}