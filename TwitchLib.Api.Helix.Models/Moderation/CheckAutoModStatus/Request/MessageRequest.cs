using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.CheckAutoModStatus.Request;

/// <summary>
/// Message request object.
/// </summary>
public class MessageRequest
{
    /// <summary>
    /// The list of messages to check.
    /// </summary>
    [JsonPropertyName("data")]
    public Message[] Messages { get; set; }
}
