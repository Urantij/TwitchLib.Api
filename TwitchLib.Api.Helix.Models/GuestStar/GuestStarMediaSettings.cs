using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar;

/// <summary>
/// Information about the guest’s audio settings
/// </summary>
public class GuestStarMediaSettings
{
    /// <summary>
    /// Flag determining whether the guest has an appropriate audio/video device available to be transmitted to the session.
    /// </summary>
    [JsonPropertyName("is_available")]
    public bool IsAvailable { get; protected set; }
    /// <summary>
    /// Flag determining whether the host is allowing the guest’s audio/video to be seen or heard within the session.
    /// </summary>
    [JsonPropertyName("is_host_enabled")]
    public bool IsHostEnabled { get; protected set; }
    /// <summary>
    /// Flag determining whether the guest is allowing their audio/video to be transmitted to the session.
    /// </summary>
    [JsonPropertyName("is_guest_enabled")]
    public bool IsGuestEnabled { get; protected set; }
}