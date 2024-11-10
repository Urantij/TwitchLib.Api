using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Predictions.CreatePrediction;

/// <summary>
/// Create prediction request object.
/// </summary>
public class CreatePredictionRequest
{
    /// <summary>
    /// The ID of the broadcaster that’s running the prediction.
    /// This ID must match the user ID in the user access token.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; set; }

    /// <summary>
    /// The question that the broadcaster is asking.
    /// The title is limited to a maximum of 45 characters.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// The list of possible outcomes that the viewers may choose from.
    /// The list must contain a minimum of 2 choices and up to a maximum of 10 choices.
    /// </summary>
    [JsonPropertyName("outcomes")]
    public Outcome[] Outcomes { get; set; }

    /// <summary>
    /// The length of time (in seconds) that the prediction will run for.
    /// The minimum is 30 seconds and the maximum is 1800 seconds (30 minutes).
    /// </summary>
    [JsonPropertyName("prediction_window")]
    public int PredictionWindowSeconds { get; set; }
}
