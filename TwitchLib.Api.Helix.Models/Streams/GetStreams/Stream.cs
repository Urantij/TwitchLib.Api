using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreams;

/// <summary>
/// 
/// </summary>
public class Stream
{
    /// <summary>
    /// An ID that identifies the stream.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The ID of the user that’s broadcasting the stream.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// The user’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The ID of the category or game being played.
    /// </summary>
    [JsonPropertyName("game_id")]
    public string GameId { get; protected set; }

    /// <summary>
    /// The name of the category or game being played.
    /// </summary>
    [JsonPropertyName("game_name")]
    public string GameName { get; protected set; }

    /// <summary>
    /// The type of stream.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; protected set; }

    /// <summary>
    /// The stream’s title.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; protected set; }

    /// <summary>
    /// The tags applied to the stream.
    /// </summary>
    [JsonPropertyName("tags")]
    public string[] Tags { get; protected set; }

    /// <summary>
    /// The number of users watching the stream.
    /// </summary>
    [JsonPropertyName("viewer_count")]
    public int ViewerCount { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the broadcast began.
    /// </summary>
    [JsonPropertyName("started_at")]
    public DateTime StartedAt { get; protected set; }

    /// <summary>
    /// The language that the stream uses.
    /// </summary>
    [JsonPropertyName("language")]
    public string Language { get; protected set; }

    /// <summary>
    /// A URL to an image of a frame from the last 5 minutes of the stream. 
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; protected set; }

    /// <summary>
    /// IMPORTANT As of February 28, 2023, this field is deprecated and returns only an empty array. 
    /// </summary>
    [Obsolete]
    [JsonPropertyName("tag_ids")]
    public string[] TagIds { get; protected set; }

    /// <summary>
    /// A Boolean value that indicates whether the stream is meant for mature audiences.
    /// </summary>
    [JsonPropertyName("is_mature")]
    public bool IsMature { get; protected set; }
}
