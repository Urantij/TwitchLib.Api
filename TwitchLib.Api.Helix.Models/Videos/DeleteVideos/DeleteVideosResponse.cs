using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Videos.DeleteVideos;

/// <summary>
/// Delete videos response object.
/// </summary>
public class DeleteVideosResponse
{
    /// <summary>
    /// The list of IDs of the videos that were deleted.
    /// </summary>
    [JsonPropertyName("data")]
    public string[] Data { get; protected set; }
}
