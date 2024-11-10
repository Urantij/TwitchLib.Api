using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.ChatSettings;

/// <summary>
/// Update Broadcaster chat settings response model
/// </summary>
public class UpdateChatSettingsResponse
{
    /// <summary>
    /// The list of chat settings. The list contains a single object with all the settings.
    /// </summary>
    [JsonPropertyName("data")]
    public UpdateChatSettingsResponseModel[] Data { get; protected set; }
}
