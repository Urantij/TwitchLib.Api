﻿using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Games;

/// <summary>
/// Get top games response object.
/// </summary>
public class GetTopGamesResponse
{
    /// <summary>
    /// The list of broadcasts. The broadcasts are sorted by the number of viewers, with the most popular first.
    /// </summary>
    [JsonPropertyName("data")]
    public Game[] Data { get; protected set; }

    /// <summary>
    /// Contains the information used to page through the list of results. 
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
