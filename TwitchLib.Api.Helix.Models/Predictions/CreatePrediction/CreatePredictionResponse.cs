using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Predictions.CreatePrediction;

/// <summary>
/// Create prediction respsone object.
/// </summary>
public class CreatePredictionResponse
{
    /// <summary>
    /// A list that contains the single prediction that you created.
    /// </summary>
    [JsonPropertyName("data")]
    public Prediction[] Data { get; protected set; }
}
