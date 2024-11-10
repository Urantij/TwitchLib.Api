using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// Get teams response object.
/// </summary>
public class GetTeamsResponse
{
    /// <summary>
    /// A list that contains the single team that you requested.
    /// </summary>
    [JsonPropertyName("data")]
    public Team[] Teams { get; protected set; }
}