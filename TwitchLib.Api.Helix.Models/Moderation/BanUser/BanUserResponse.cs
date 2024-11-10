using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.BanUser;

/// <summary>
/// Ban user response object.
/// </summary>
public class BanUserResponse
{
    /// <summary>
    /// Identifies the user and type of ban.
    /// </summary>
    [JsonPropertyName("data")]
    public BannedUser[] Data { get; protected set; }
}
