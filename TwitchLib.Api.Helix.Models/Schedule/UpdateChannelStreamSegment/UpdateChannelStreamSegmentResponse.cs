using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Schedule.UpdateChannelStreamSegment;

/// <summary>
/// Update channel stream segment response object.
/// </summary>
public class UpdateChannelStreamSegmentResponse
{
    /// <summary>
    /// The broadcaster’s streaming schedule.
    /// </summary>
    [JsonPropertyName("data")]
    public ChannelStreamSchedule Schedule { get; protected set; }
}