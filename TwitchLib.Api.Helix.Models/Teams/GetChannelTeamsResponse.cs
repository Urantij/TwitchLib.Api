using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// Get channel teams response object.
/// </summary>
public class GetChannelTeamsResponse
{
    /// <summary>
    /// The list of teams that the broadcaster is a member of.
    /// </summary>
    [JsonPropertyName("data")]
    public ChannelTeam[] ChannelTeams { get; protected set; }
}