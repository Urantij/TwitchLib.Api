using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Users.Internal;

/// <summary>
/// A user extension.
/// </summary>
public class UserExtension
{
    /// <summary>
    /// An ID that identifies the extension.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The extension's version.
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; protected set; }

    /// <summary>
    /// The extension's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the extension is configured and can be activated.
    /// </summary>
    [JsonPropertyName("can_activate")]
    public bool CanActivate { get; protected set; }

    /// <summary>
    /// The extension types that you can activate for this extension.
    /// </summary>
    [JsonPropertyName("type")]
    public string[] Type { get; protected set; }
}
