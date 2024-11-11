using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// A Team.
/// </summary>
public class Team : TeamBase
{
    public Team(string banner = null, string backgroundImageUrl = null, string createdAt = null, string updatedAt = null, string info = null, string thumbnailUrl = null, string teamName = null, string teamDisplayName = null, string id = null, TeamMember[] users = null) : base(banner, backgroundImageUrl, createdAt, updatedAt, info, thumbnailUrl, teamName, teamDisplayName, id)
    {
        Users = users;
    }

    /// <summary>
    /// The list of team members.
    /// </summary>
    [JsonPropertyName("users")]
    public TeamMember[] Users { get; protected set; }
}