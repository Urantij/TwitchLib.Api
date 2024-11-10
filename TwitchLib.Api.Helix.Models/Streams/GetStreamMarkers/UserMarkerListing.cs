using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreamMarkers;

/// <summary>
/// A marker grouped by the user that created the marks.
/// </summary>
public class UserMarkerListing
{
    /// <summary>
    /// The ID of the user that created the marker.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The user’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// A list of videos that contain marker.
    /// </summary>
    [JsonPropertyName("videos")]
    public Video[] Videos { get; protected set; }
}
