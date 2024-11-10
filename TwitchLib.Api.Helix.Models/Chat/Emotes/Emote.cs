using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes;

/// <summary>
/// Emote
/// </summary>
public abstract class Emote
{
    /// <summary>
    /// An ID that identifies the emote.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The name of the emote. This is the name that viewers type in the chat window to get the emote to appear.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; protected set; }

    /// <summary>
    /// The formats that the emote is available in.
    /// </summary>
    [JsonPropertyName("format")]
    public string[] Format { get; protected set; }

    /// <summary>
    /// The sizes that the emote is available in.
    /// </summary>
    [JsonPropertyName("scale")]
    public string[] Scale { get; protected set; }

    /// <summary>
    /// The background themes that the emote is available in.
    /// </summary>
    [JsonPropertyName("theme_mode")]
    public string[] ThemeMode { get; protected set; }
}