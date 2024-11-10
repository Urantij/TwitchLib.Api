using System.Text.Json.Serialization;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Helix.Models.Predictions;

/// <summary>
/// A single prediction.
/// </summary>
public class Prediction
{
    /// <summary>
    /// An ID that identifies this prediction.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// An ID that identifies the broadcaster
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string BroadcasterName { get; protected set; }

    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }

    /// <summary>
    /// The question that the prediction asks.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; protected set; }

    /// <summary>
    /// The ID of the winning outcome. Is null unless status is RESOLVED.
    /// </summary>
    [JsonPropertyName("winning_outcome_id")]
    public string WinningOutcomeId { get; protected set; }

    /// <summary>
    /// The list of possible outcomes for the prediction.
    /// </summary>
    [JsonPropertyName("outcomes")]
    public Outcome[] Outcomes { get; protected set; }

    /// <summary>
    /// The length of time (in seconds) that the prediction will run for.
    /// </summary>
    [JsonPropertyName("prediction_window")]
    public string PredictionWindow { get; protected set; }

    /// <summary>
    /// The prediction’s status.
    /// </summary>
    [JsonPropertyName("status")]
    public PredictionStatus Status { get; protected set; }

    /// <summary>
    /// The UTC date and time of when the Prediction began.
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; protected set; }

    /// <summary>
    /// The UTC date and time of when the Prediction ended. If status is ACTIVE, this is set to null.
    /// </summary>
    [JsonPropertyName("ended_at")]
    public string EndedAt { get; protected set; }

    /// <summary>
    /// The UTC date and time of when the Prediction was locked. If status is not LOCKED, this is set to null.
    /// </summary>
    [JsonPropertyName("locked_at")]
    public string LockedAt { get; protected set; }        
}
