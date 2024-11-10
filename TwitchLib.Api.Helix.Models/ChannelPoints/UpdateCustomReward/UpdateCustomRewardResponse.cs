using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints.UpdateCustomReward;

/// <summary>
/// The response for updating a custom reward.
/// </summary>
public class UpdateCustomRewardResponse
{
  /// <summary>
  /// The list contains the single reward that you updated.
  /// </summary>
  [JsonPropertyName("data")]
  public CustomReward[] Data { get; protected set; }
}
