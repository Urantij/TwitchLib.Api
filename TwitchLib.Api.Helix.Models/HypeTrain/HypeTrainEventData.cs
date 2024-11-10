using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.HypeTrain;

/// <summary>
/// The event’s data.
/// </summary>
public class HypeTrainEventData
{
    /// <summary>
    /// An ID that identifies this Hype Train.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The ID of the broadcaster that’s running the Hype Train.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) that this Hype Train started.
    /// </summary>
    [JsonPropertyName("started_at")]
    public string StartedAt { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) that the Hype Train ends.
    /// </summary>
    [JsonPropertyName("expires_at")]
    public string ExpiresAt { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) that another Hype Train can start.
    /// </summary>
    [JsonPropertyName("cooldown_end_time")]
    public string CooldownEndTime { get; protected set; }

    /// <summary>
    /// The highest level that the Hype Train reached.
    /// </summary>
    [JsonPropertyName("level")]
    public int Level { get; protected set; }

    /// <summary>
    /// The value needed to reach the next level.
    /// </summary>
    [JsonPropertyName("goal")]
    public int Goal { get; protected set; }

    /// <summary>
    /// The current total amount raised.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; protected set; }

    /// <summary>
    /// The top contributors for each contribution type. 
    /// For example, the top contributor using BITS (by aggregate) and the top contributor using SUBS (by count).
    /// </summary>
    [JsonPropertyName("top_contribution")]
    public HypeTrainContribution[] TopContribution { get; protected set; }

    /// <summary>
    /// The most recent contribution towards the Hype Train’s goal.
    /// </summary>
    [JsonPropertyName("last_contribution")]
    public HypeTrainContribution LastContribution { get; protected set; }
}