using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// A Team.
/// </summary>
public class Team : TeamBase
{
    /// <summary>
    /// The list of team members.
    /// </summary>
    [JsonPropertyName("users")]
    public TeamMember[] Users { get; protected set; }
}