using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.HypeTrain;

/// <summary>
/// A hype train object.
/// </summary>
public class HypeTrain
{
    /// <summary>
    /// An ID that identifies this event.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The type of event. The string is in the form, hypetrain.{event_name}.
    /// </summary>
    [JsonPropertyName("event_type")]
    public string EventType { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) that the event occurred.
    /// </summary>
    [JsonPropertyName("event_timestamp")]
    public string EventTimeStamp { get; protected set; }

    /// <summary>
    /// The version number of the definition of the event’s data.
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; protected set; }

    /// <summary>
    /// The event’s data.
    /// </summary>
    [JsonPropertyName("event_data")]
    public HypeTrainEventData EventData { get; protected set; }
}