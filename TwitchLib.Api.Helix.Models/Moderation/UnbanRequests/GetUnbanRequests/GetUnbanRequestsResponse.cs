﻿using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Moderation.UnbanRequests.GetUnbanRequests;

/// <summary>
/// Get banned requests response object.
/// </summary>
public class GetUnbanRequestsResponse
{
    /// <summary>
    /// A list that contains information about the channel's unban requests.
    /// </summary>
    [JsonPropertyName("data")]
    public UnbanRequest[] Data { get; protected set; }
    /// <summary>
    /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
