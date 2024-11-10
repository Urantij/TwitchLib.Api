using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Extensions.ReleasedExtensions;

/// <summary>
/// Describes how the extension is rendered if the extension may be activated as a panel extension.
/// </summary>
public class Panel
{
    /// <summary>
    /// The HTML file that is shown to viewers on the channel page when the extension is activated in a Panel slot.
    /// </summary>
    [JsonPropertyName("viewer_url")]
    public string ViewerUrl { get; protected set; }

    /// <summary>
    /// The height, in pixels, of the panel component that the extension is rendered in.
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the extension can link to non-Twitch domains.
    /// </summary>
    [JsonPropertyName("can_link_external_content")]
    public bool CanLinkExternalContent { get; protected set; }
}
