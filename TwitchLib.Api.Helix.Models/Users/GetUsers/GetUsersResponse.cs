using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Users.GetUsers;

/// <summary>
/// Get users response object.
/// </summary>
public class GetUsersResponse
{
    /// <summary>
    /// The list of users.
    /// </summary>
    [JsonPropertyName("data")]
    public User[] Users { get; protected set; }
}
