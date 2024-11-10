﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Users.GetUserBlockList;

/// <summary>
/// Get user block list response object.
/// </summary>
public class GetUserBlockListResponse
{
    /// <summary>
    /// The list of blocked users.
    /// The list is in descending order by when the user was blocked.
    /// </summary>
    [JsonPropertyName("data")]
    public BlockedUser[] Data { get; protected set; }
}
