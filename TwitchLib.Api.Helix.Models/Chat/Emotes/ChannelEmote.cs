using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes;

/// <summary>
/// Broadcaster created custom emote.
/// </summary>
public class ChannelEmote : Emote
{
    public ChannelEmote(string id = null, string name = null, string[] format = null, string[] scale = null, string[] themeMode = null, EmoteImages images = null, string tier = null, string emoteType = null, string emoteSetId = null) : base(id, name, format, scale, themeMode)
    {
        Images = images;
        Tier = tier;
        EmoteType = emoteType;
        EmoteSetId = emoteSetId;
    }

    /// <summary>
    /// Contains the image URLs for the emote.
    /// </summary>
    [JsonPropertyName("images")]
    public EmoteImages Images { get; protected set; }

    /// <summary>
    /// The subscriber tier at which the emote is unlocked.
    /// </summary>
    [JsonPropertyName("tier")]
    public string Tier { get; protected set; }

    /// <summary>
    /// The type of emote.
    /// </summary>
    [JsonPropertyName("emote_type")]
    public string EmoteType { get; protected set; }

    /// <summary>
    /// An ID that identifies the emote set that the emote belongs to.
    /// </summary>
    [JsonPropertyName("emote_set_id")]
    public string EmoteSetId { get; protected set; }
}