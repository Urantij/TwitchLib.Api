using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.WarnChatUser;

/// <summary>
/// Warn chat user response object.
/// </summary>
public class WarnChatUserResponse
{
    /// <summary>
    /// A list that contains information about the warning.
    /// </summary>
    [JsonPropertyName("data")]
    public WarnedChatUser[] Data { get; protected set; }
}

