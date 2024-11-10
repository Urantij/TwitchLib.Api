using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Polls.CreatePoll;

/// <summary>
/// Create poll response object.
/// </summary>
public class CreatePollResponse
{
    /// <summary>
    /// A list that contains the single poll that you created.
    /// </summary>
    [JsonPropertyName("data")]
    public Poll[] Data { get; protected set; }
}
