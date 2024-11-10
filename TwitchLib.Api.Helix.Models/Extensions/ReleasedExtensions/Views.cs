using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Extensions.ReleasedExtensions;

/// <summary>
/// Describes view-related information such as how the extension is displayed on mobile devices.
/// </summary>
public class Views
{
    /// <summary>
    /// Describes how the extension is displayed on mobile devices.
    /// </summary>
    [JsonPropertyName("mobile")]
    public Mobile Mobile { get; protected set; }

    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a panel extension.
    /// </summary>
    [JsonPropertyName("panel")]
    public Panel Panel { get; protected set; }

    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
    /// </summary>
    [JsonPropertyName("video_overlay")]
    public VideoOverlay VideoOverlay { get; protected set; }

    /// <summary>
    /// Describes how the extension is rendered if the extension may be activated as a video-component extension.
    /// </summary>
    [JsonPropertyName("component")]
    public Component Component { get; protected set; }
}
