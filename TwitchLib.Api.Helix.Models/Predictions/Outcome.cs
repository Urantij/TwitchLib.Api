using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Predictions;

/// <summary>
/// A possible outcomes for the prediction.
/// </summary>
public class Outcome
{
    /// <summary>
    /// An ID that identifies this outcome.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The outcome’s text.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; protected set; }

    /// <summary>
    /// The number of unique viewers that chose this outcome.
    /// </summary>
    [JsonPropertyName("users")]
    public int ChannelPoints { get; protected set; }

    /// <summary>
    /// The number of Channel Points spent by viewers on this outcome.
    /// </summary>
    [JsonPropertyName("channel_points")]
    public int ChannelPointsVotes { get; protected set; }

    /// <summary>
    /// A list of viewers who were the top predictors; otherwise, null if none.
    /// </summary>
    [JsonPropertyName("top_predictors")]
    public TopPredictor[] TopPredictors { get; protected set; }

    /// <summary>
    /// The color that visually identifies this outcome in the UX.
    /// </summary>
    [JsonPropertyName("color")]
    public string Color { get; protected set; }
}
