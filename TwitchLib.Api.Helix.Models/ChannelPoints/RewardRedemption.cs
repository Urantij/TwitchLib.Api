using System.Text.Json.Serialization;
using System;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Helix.Models.ChannelPoints;

/// <summary>
/// A redemption for a custom reward.
/// </summary>
public class RewardRedemption
{
  /// <summary>
  /// The ID that uniquely identifies the broadcaster.
  /// </summary>
  [JsonPropertyName("broadcaster_id")]
  public string BroadcasterId { get; protected set; }

  /// <summary>
  /// The broadcaster’s login name. (Name is lowercase)
  /// </summary>
  [JsonPropertyName("broadcaster_login")]
  public string BroadcasterLogin { get; protected set; }

  /// <summary>
  /// The broadcaster’s display name. (Name has capitalization)
  /// </summary>
  [JsonPropertyName("broadcaster_name")]
  public string BroadcasterName { get; protected set; }

  /// <summary>
  /// The ID that uniquely identifies this redemption.
  /// </summary>
  [JsonPropertyName("id")]
  public string Id { get; protected set; }

  /// <summary>
  /// The user’s login name. (Name is lowercase)
  /// </summary>
  [JsonPropertyName("user_login")]
  public string UserLogin { get; protected set; }

  /// <summary>
  /// The ID that uniquely identifies the user that redeemed the reward.
  /// </summary>
  [JsonPropertyName("user_id")]
  public string UserId { get; protected set; }

  /// <summary>
  /// The user’s display name. (Name has capitalization)
  /// </summary>
  [JsonPropertyName("user_name")]
  public string UserName { get; protected set; }

  /// <summary>
  /// The text that the user entered at the prompt when they redeemed the reward; otherwise, an empty string if user input was not required.
  /// </summary>
  [JsonPropertyName("user_input")]
  public string UserInput { get; protected set; }

  /// <summary>
  /// The state of the redemption. Possible values are: CANCELED, FULFILLED, UNFULFILLED
  /// </summary>
  [JsonPropertyName("status")]
  public CustomRewardRedemptionStatus Status { get; protected set; }

  /// <summary>
  /// The date and time of when the reward was redeemed.
  /// </summary>
  [JsonPropertyName("redeemed_at")]
  public DateTime RedeemedAt { get; protected set; }

  /// <summary>
  /// The reward that the user redeemed.
  /// </summary>
  [JsonPropertyName("reward")]
  public Reward Reward { get; protected set; }
}
