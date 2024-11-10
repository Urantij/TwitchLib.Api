using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar;

/// <summary>
/// The session details
/// </summary>
public class GuestStarSession
{
    /// <summary>
    /// ID uniquely representing the Guest Star session.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// List of guests currently interacting with the Guest Star session.
    /// </summary>
    [JsonPropertyName("guests")]
    public GuestStarGuest[] Guests { get; protected set; }
}