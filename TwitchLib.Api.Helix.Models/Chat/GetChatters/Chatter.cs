using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.GetChatters;

/// <summary>
/// A user that is connected to the broadcaster’s chat session.
/// </summary>
public class Chatter
{
    /// <summary>
    /// The ID of a user that’s connected to the broadcaster’s chat room.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }
    /// <summary>
    /// The login name of a user that’s connected to the broadcaster’s chat room.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }
    /// <summary>
    /// The display name of a user that’s connected to the broadcaster’s chat room.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }
}
