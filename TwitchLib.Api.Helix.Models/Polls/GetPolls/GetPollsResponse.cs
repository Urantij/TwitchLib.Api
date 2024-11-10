using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Polls.GetPolls;

/// <summary>
/// Get polls response object.
/// </summary>
public class GetPollsResponse
{
    /// <summary>
    /// A list of polls.
    /// </summary>
    [JsonPropertyName("data")]
    public Poll[] Data { get; protected set; }

    /// <summary>
    /// Contains the information used to page through the list of results.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
