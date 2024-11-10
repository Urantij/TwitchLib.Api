using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Streams.CreateStreamMarker;

/// <summary>
/// A single marker that you added.
/// </summary>
public class CreatedMarker
{
    /// <summary>
    /// An ID that identifies this marker.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the user created the marker.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; protected set; }

    /// <summary>
    /// A description that the user gave the marker to help them remember why they marked the location.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; protected set; }

    /// <summary>
    /// The relative offset (in seconds) of the marker from the beginning of the stream.
    /// </summary>
    [JsonPropertyName("position_seconds")]
    public int PositionSeconds { get; protected set; }
}
