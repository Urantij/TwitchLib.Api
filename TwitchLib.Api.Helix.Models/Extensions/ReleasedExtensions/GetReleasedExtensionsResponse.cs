using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Extensions.ReleasedExtensions;

/// <summary>
/// Get released extensions response object.
/// </summary>
public class GetReleasedExtensionsResponse
{
    /// <summary>
    /// A list that contains the specified extension.
    /// </summary>
    [JsonPropertyName("data")]
    public ReleasedExtension[] Data { get; protected set; }
}
