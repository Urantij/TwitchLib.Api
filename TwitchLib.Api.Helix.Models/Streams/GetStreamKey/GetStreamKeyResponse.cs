using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreamKey;

/// <summary>
/// Get stream key response object.
/// </summary>
public class GetStreamKeyResponse
{
    /// <summary>
    /// A list that contains the channel’s stream key.
    /// </summary>
    [JsonPropertyName("data")]
    public StreamKey[] Streams { get; protected set; }
}
