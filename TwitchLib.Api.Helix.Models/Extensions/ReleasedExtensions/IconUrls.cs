using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Extensions.ReleasedExtensions;

/// <summary>
/// A list that contains URLs to different sizes of the default icon.
/// </summary>
public class IconUrls
{
    /// <summary>
    /// Size100x100
    /// </summary>
    [JsonPropertyName("100x100")]
    public string Size100x100 { get; protected set; }

    /// <summary>
    /// Size24x24
    /// </summary>
    [JsonPropertyName("24x24")]
    public string Size24x24 { get; protected set; }

    /// <summary>
    /// Size300x200
    /// </summary>
    [JsonPropertyName("300x200")]
    public string Size300x200 { get; protected set; }
}
