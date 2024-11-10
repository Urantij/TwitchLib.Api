using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreamKey;

/// <summary>
/// The channel’s stream key.
/// </summary>
public class StreamKey
{
    /// <summary>
    /// The channel’s stream key.
    /// </summary>
    [JsonPropertyName("stream_key")]
    public string Key { get; protected set; }
}
