using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// A team member.
/// </summary>
public class TeamMember
{
    public TeamMember(string userId = null, string userName = null, string userLogin = null)
    {
        UserId = userId;
        UserName = userName;
        UserLogin = userLogin;
    }

    /// <summary>
    /// An ID that identifies the team member.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The team member’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The team member’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }
}