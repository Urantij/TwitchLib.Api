using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Users.Internal;

namespace TwitchLib.Api.Helix.Models.Users.GetUserExtensions;

/// <summary>
/// Get user extensions response object.
/// </summary>
public class GetUserExtensionsResponse
{
    /// <summary>
    /// The list of extensions that the user has installed.
    /// </summary>
    [JsonPropertyName("data")]
    public UserExtension[] Users { get; protected set; }
}
