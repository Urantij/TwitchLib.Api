using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Polls.EndPoll;

/// <summary>
/// End poll response object.
/// </summary>
public class EndPollResponse
{
    /// <summary>
    /// A list that contains the poll that you ended.
    /// </summary>
    [JsonPropertyName("data")]
    public Poll[] Data { get; protected set; }
}
