using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.GetUserChatColor;

/// <summary>
/// The color used for the user’s name in chat.
/// </summary>
public class UserChatColorResponseModel
{
    /// <summary>
    /// The ID of the user.
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
    /// <summary>
    /// The Hex color code that the user uses in chat for their name. If the user hasn’t specified a color in their settings, the string is empty.
    /// </summary>
    [JsonPropertyName("color")]
    public string Color { get; protected set; }
}
