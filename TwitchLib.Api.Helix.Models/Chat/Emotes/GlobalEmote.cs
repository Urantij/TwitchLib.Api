using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes;

/// <summary>
/// Global emote.
/// </summary>
public class GlobalEmote : Emote
{
    /// <summary>
    /// Contains the image URLs for the emote.
    /// </summary>
    [JsonPropertyName("images")]
    public EmoteImages Images { get; protected set; }
}