using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Predictions.EndPrediction;

/// <summary>
/// End prediction response object.
/// </summary>
public class EndPredictionResponse
{
    /// <summary>
    /// A list that contains the single prediction that you updated.
    /// </summary>
    [JsonPropertyName("data")]
    public Prediction[] Data { get; protected set; }
}
