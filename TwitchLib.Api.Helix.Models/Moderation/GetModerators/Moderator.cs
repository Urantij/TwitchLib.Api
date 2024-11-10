using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.GetModerators;

/// <summary>
/// A moderator.
/// </summary>
public class Moderator
{
    /// <summary>
    /// The ID of the user that has permission to moderate the broadcaster’s channel.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// The user’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }
}
