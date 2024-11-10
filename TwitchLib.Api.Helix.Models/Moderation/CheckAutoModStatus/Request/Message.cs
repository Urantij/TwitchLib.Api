using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.CheckAutoModStatus;

/// <summary>
/// The message to check.
/// </summary>
public class Message
{
    /// <summary>
    /// Developer-generated identifier for mapping messages to results.
    /// </summary>
    [JsonPropertyName("msg_id")]
    public string MsgId { get; set; }

    /// <summary>
    /// Message text.
    /// </summary>
    [JsonPropertyName("msg_text")]
    public string MsgText { get; set; }
}
