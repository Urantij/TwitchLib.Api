using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes;

/// <summary>
/// Global emote.
/// </summary>
public class GlobalEmote : Emote
{
    public GlobalEmote(string id = null, string name = null, string[] format = null, string[] scale = null, string[] themeMode = null, EmoteImages images = null) : base(id, name, format, scale, themeMode)
    {
        Images = images;
    }

    /// <summary>
    /// Contains the image URLs for the emote.
    /// </summary>
    [JsonPropertyName("images")]
    public EmoteImages Images { get; protected set; }
}