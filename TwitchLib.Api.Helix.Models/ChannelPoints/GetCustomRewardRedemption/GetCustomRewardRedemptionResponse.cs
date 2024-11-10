using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.ChannelPoints.GetCustomRewardRedemption;

/// <summary>
/// The response for getting a list of redemptions for a custom reward.
/// </summary>
public class GetCustomRewardRedemptionResponse
{
  /// <summary>
  /// The list of redemptions for the specified reward. The list is empty if there are no redemptions that match the redemption criteria.
  /// </summary>
  [JsonPropertyName("data")]
  public RewardRedemption[] Data { get; protected set; }

  /// <summary>
  /// Contains the information used to page through the list of results
  /// </summary>
  [JsonPropertyName("pagination")]
  public Pagination Pagination { get; protected set; }
}
