using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Predictions.CreatePrediction;

/// <summary>
/// Request - An outcome that the viewers may choose from.
/// </summary>
public class Outcome
{
    /// <summary>
    /// The question that the broadcaster is asking.
    /// The title is limited to a maximum of 45 characters.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}
