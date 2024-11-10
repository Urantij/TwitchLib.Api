using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar.GetGuestStarSession;

/// <summary>
/// Get guest star session response object.
/// </summary>
public class GetGuestStarSessionResponse
{
    /// <summary>
    /// <para>A list that contains the channels guest star sessions</para>
    /// </summary>
    [JsonPropertyName("data")]
    public GuestStarSession[] Data { get; protected set; }
}