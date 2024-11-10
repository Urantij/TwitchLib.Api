using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar.CreateGuestStarSession;

/// <summary>
/// End guest start session response object
/// </summary>
public class EndGuestStarSessionResponse
{
    /// <summary>
    /// <para>Summary of the session details when the session was ended.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public GuestStarSession[] Data { get; protected set; }
}