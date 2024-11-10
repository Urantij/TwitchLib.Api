using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreamMarkers;

/// <summary>
/// A video that contains markers.
/// </summary>
public class Video
{
    /// <summary>
    /// An ID that identifies this video.
    /// </summary>
    [JsonPropertyName("video_id")]
    public string VideoId { get; protected set; }

    /// <summary>
    /// The list of markers in this video.
    /// </summary>
    [JsonPropertyName("markers")]
    public Marker[] Markers { get; protected set; }
}
