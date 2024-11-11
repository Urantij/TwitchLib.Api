using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreams;

/// <summary>
/// Get streams response object.
/// </summary>
public class GetStreamsResponse
{
    public GetStreamsResponse(Stream[] streams = null, Pagination pagination = null)
    {
        Streams = streams;
        Pagination = pagination;
    }

    /// <summary>
    /// The list of streams.
    /// </summary>
    [JsonPropertyName("data")]
    public Stream[] Streams { get; protected set; }

    /// <summary>
    /// The information used to page through the list of results.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
