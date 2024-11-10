﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar.CreateGuestStarSession;

/// <summary>
/// Create guest star session repsonse object.
/// </summary>
public class CreateGuestStarSessionResponse
{
    /// <summary>
    /// <para>Summary of the session details.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public GuestStarSession[] Data { get; protected set; }
}