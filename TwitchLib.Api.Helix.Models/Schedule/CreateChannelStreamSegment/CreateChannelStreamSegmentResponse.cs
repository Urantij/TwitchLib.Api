using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Schedule.CreateChannelStreamSegment;

/// <summary>
/// Create channel streams segment response object.
/// </summary>
public class CreateChannelStreamSegmentResponse
{
    /// <summary>
    /// The broadcaster’s streaming scheduled.
    /// </summary>
    [JsonPropertyName("data")]
    public ChannelStreamSchedule Schedule { get; protected set; }
}