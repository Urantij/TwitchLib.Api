﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Emotes;

/// <summary>
/// The image URLs for the emote.
/// </summary>
public class EmoteImages
{
    /// <summary>
    /// A URL to the small version (28px x 28px) of the emote.
    /// </summary>
    [JsonPropertyName("url_1x")]
    public string Url1X { get; protected set; }

    /// <summary>
    /// A URL to the medium version (56px x 56px) of the emote.
    /// </summary>
    [JsonPropertyName("url_2x")]
    public string Url2X { get; protected set; }

    /// <summary>
    /// A URL to the large version (112px x 112px) of the emote.
    /// </summary>
    [JsonPropertyName("url_4x")]
    public string Url4X { get; protected set; }
}