using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Extensions.ReleasedExtensions;

/// <summary>
/// Describes how the extension is rendered if the extension may be activated as a video-overlay extension.
/// </summary>
public class VideoOverlay
{
    /// <summary>
    /// The HTML file that is shown to viewers on the channel page when the extension is activated on the Video - Overlay slot.
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string ViewerUrl { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the extension can link to non-Twitch domains.
    /// </summary>
    [JsonPropertyName("can_link_external_content")]
    public bool CanLinkExternalContent { get; protected set; }
}
