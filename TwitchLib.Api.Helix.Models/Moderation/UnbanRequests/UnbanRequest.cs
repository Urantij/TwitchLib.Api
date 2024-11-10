using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Helix.Models.Moderation.UnbanRequests;

/// <summary>
/// Contains information about the channel's unban request
/// </summary>
public class UnbanRequest
{
    /// <summary>
    /// Unban request ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }
    /// <summary>
    /// The broadcaster's display name.
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string BroadcasterName { get; protected set; }
    /// <summary>
    /// The broadcaster's login name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }
    /// <summary>
    /// User ID of broadcaster whose channel is receiving the unban request.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }
    /// <summary>
    /// User ID of moderator who approved/denied the request.
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string ModeratorId { get; protected set; }
    /// <summary>
    /// The moderator's login name.
    /// </summary>
    [JsonPropertyName("moderator_login")]
    public string ModeratorLogin { get; protected set; }
    /// <summary>
    /// The moderator's display name.
    /// </summary>
    [JsonPropertyName("moderator_name")]
    public string ModeratorName { get; protected set; }
    /// <summary>
    /// User ID of the requestor who is asking for an unban.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }
    /// <summary>
    /// The user's login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }
    /// <summary>
    /// The user's display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }
    /// <summary>
    /// Text of the request from the requesting user.
    /// </summary>
    [JsonPropertyName("text")]
    public string Text { get; protected set; }
    /// <summary>
    /// Status of the request. One of: pending, approved, denied, acknowledged, canceled
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; protected set; }
    /// <summary>
    /// Timestamp of when the unban request was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; protected set; }
    /// <summary>
    /// Timestamp of when moderator/broadcaster approved or denied the request.
    /// </summary>
    [JsonPropertyName("resolved_at")]
    public DateTime? ResolvedAt { get; protected set; }
    /// <summary>
    /// Text input by the resolver (moderator) of the unban. request
    /// </summary>
    [JsonPropertyName("resolution_text")]
    public string ResolutionText { get; protected set; }
}
