using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.GetBannedUsers;

/// <summary>
/// A user that was banned or put in a timeout.
/// </summary>
public class BannedUserEvent
{
    /// <summary>
    /// User ID of the banned user.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// Login of the banned user.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// Display name of the banned user.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3999 format) when the timeout expires, or an empty string if the user is permanently banned.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public DateTime? ExpiresAt { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3999 format) when the ban was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; protected set; }

    /// <summary>
    /// The reason for the ban if provided by the moderator.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; protected set; }

    /// <summary>
    /// User ID of the moderator who initiated the ban.
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string ModeratorId { get; protected set; }

    /// <summary>
    /// Login of the moderator who initiated the ban.
    /// </summary>
    [JsonPropertyName("moderator_login")]
    public string ModeratorLogin { get; protected set; }

    /// <summary>
    /// Display name of the moderator who initiated the ban.
    /// </summary>
    [JsonPropertyName("moderator_name")]
    public string ModeratorName { get; protected set; }
}
