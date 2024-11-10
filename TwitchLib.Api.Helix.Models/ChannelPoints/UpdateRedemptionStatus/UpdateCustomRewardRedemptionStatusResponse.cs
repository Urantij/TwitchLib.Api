using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints.UpdateRedemptionStatus;

/// <summary>
/// The response for updating a redemption’s status.
/// </summary>
public class UpdateRedemptionStatusResponse
{
  /// <summary>
  /// The state of the redemption. Possible values are: CANCELED, FULFILLED, UNFULFILLED
  /// </summary>
  [JsonPropertyName("data")]
  public RewardRedemption[] Data { get; protected set; }
}
