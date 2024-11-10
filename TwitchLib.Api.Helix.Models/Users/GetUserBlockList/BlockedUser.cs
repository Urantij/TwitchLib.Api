using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Users.GetUserBlockList;

/// <summary>
/// A block user.
/// </summary>
public class BlockedUser
{
    /// <summary>
    /// An ID that identifies the blocked user.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The blocked user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// The blocked user’s display name.
    /// </summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; protected set; }
}
