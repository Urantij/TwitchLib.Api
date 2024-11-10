using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.BanUser;

/// <summary>
/// Identifies the user and type of ban.
/// </summary>
public class BannedUser
{
    /// <summary>
    /// The broadcaster whose chat room the user was banned from chatting in.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3999 format) when the ban was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; protected set; }

    /// <summary>
    /// The moderator that banned or put the user in the timeout.
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string ModeratorId { get; protected set; }

    /// <summary>
    /// The user that was banned or was put in a timeout.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) that the timeout will end. Is null if the user was banned instead of put in a timeout.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime? EndTime { get; protected set; }
}
