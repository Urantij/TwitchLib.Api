using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Games;

/// <summary>
/// Get games response object.
/// </summary>
public class GetGamesResponse
{
    /// <summary>
    /// The list of categories and games. The list is empty if the specified categories and games weren’t found.
    /// </summary>
    [JsonPropertyName("data")]
    public Game[] Data { get; protected set; }
}
