using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Predictions;

/// <summary>
/// A viewer who was the top predictor
/// </summary>
public class TopPredictor
{
    /// <summary>
    /// An ID that identifies the viewer.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The viewer’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The viewer’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// The number of Channel Points the viewer spent.
    /// </summary>
    [JsonPropertyName("channel_points_used")]
    public int ChannelPointsUsed { get; protected set; }

    /// <summary>
    /// The number of Channel Points distributed to the viewer.
    /// </summary>
    [JsonPropertyName("channel_points_won")]
    public int ChannelPointsWon { get; protected set; }
}
