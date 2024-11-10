using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.CheckAutoModStatus;

/// <summary>
/// Check automod status response object.
/// </summary>
public class CheckAutoModStatusResponse
{
    /// <summary>
    /// The list of messages and whether Twitch would approve them for chat.
    /// </summary>
    [JsonPropertyName("data")]
    public AutoModResult[] Data { get; protected set; }
}
