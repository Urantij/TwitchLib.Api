using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.WarnChatUser.Request;

/// <summary>
/// Request that contains information about the warning.
/// </summary>
public class WarnChatUserRequest
{
    /// <summary>
    ///  The ID of the twitch user to be warned.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// A custom reason for the warning. Max 500 chars.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; } = string.Empty;
}