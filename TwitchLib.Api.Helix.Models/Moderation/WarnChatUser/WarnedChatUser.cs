using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.WarnChatUser;

/// <summary>
/// Contains information about the warning.
/// </summary>
public class WarnedChatUser
{
    /// <summary>
    /// The ID of the channel in which the warning will take effect.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The ID of the warned user.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The ID of the user who applied the warning.
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string ModeratorId { get; protected set; }

    /// <summary>
    /// The reason provided for warning.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; protected set; }
}

