using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Helix.Models.Moderation.UnbanRequests.ResolveUnbanRequests;

/// <summary>
/// Resolve unban requests response object.
/// </summary>
public class ResolveUnbanRequestsResponse
{
    /// <summary>
    /// Contains information about the channel's unban request.
    /// </summary>
    [JsonPropertyName("data")]
    public UnbanRequest[] Data { get; protected set; }
}
