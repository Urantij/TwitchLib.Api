using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.ShieldModeStatus.GetShieldModeStatus;

/// <summary>
/// Get shield mode status response object.
/// </summary>
public class GetShieldModeStatusResponse
{
    /// <summary>
    /// A list that contains a single object with the broadcaster’s Shield Mode status.
    /// </summary>
    [JsonPropertyName("data")]
    public ShieldModeStatus[] Data { get; protected set; }
}
