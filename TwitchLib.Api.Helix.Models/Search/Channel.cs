using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Search;

/// <summary>
/// A channel.
/// </summary>
public class Channel
{
    /// <summary>
    /// The ID of the game that the broadcaster is playing or last played.
    /// </summary>
    [JsonPropertyName("game_id")]
    public string GameId { get; protected set; }

    /// <summary>
    /// The name of the game that the broadcaster is playing or last played.
    /// </summary>
    [JsonPropertyName("game_name")]
    public string GameName { get; protected set; }

    /// <summary>
    /// An ID that uniquely identifies the channel (this is the broadcaster’s ID).
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }

    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; protected set; }

    /// <summary>
    /// The ISO 639-1 two-letter language code of the language used by the broadcaster.
    /// </summary>
    [JsonPropertyName("broadcaster_language")]
    public string BroadcasterLanguage { get; protected set; }

    /// <summary>
    /// The stream’s title. Is an empty string if the broadcaster didn’t set it.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; protected set; }

    /// <summary>
    /// A URL to a thumbnail of the broadcaster’s profile image.
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the broadcaster is streaming live.
    /// </summary>
    [JsonPropertyName("is_live")]
    public bool IsLive { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the broadcaster started streaming.
    /// </summary>
    [JsonPropertyName("started_at")]
    public DateTime? StartedAt { get; protected set; }

    /// <summary>
    /// IMPORTANT As of February 28, 2023, this field is deprecated and returns only an empty array.
    /// </summary>
    [Obsolete]
    [JsonPropertyName("tag_ids")]
    public List<string> TagIds { get; protected set; }

    /// <summary>
    /// The tags applied to the channel.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; protected set; }
}
