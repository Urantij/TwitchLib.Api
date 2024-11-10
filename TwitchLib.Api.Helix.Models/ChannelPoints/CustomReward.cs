using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints;

/// <summary>
/// Custom reward that the specified broadcaster created.
/// </summary>
public class CustomReward
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
  /// The ID that uniquely identifies this custom reward.
  /// </summary>
  [JsonPropertyName("id")]
  public string Id { get; protected set; }

  /// <summary>
  /// The title of the reward.
  /// </summary>
  [JsonPropertyName("title")]
  public string Title { get; protected set; }

  /// <summary>
  /// The prompt shown to the viewer when they redeem the reward if user input is required (see the IsUserInputRequired field).
  /// </summary>
  [JsonPropertyName("prompt")]
  public string Prompt { get; protected set; }

  /// <summary>
  /// The cost of the reward in Channel Points.
  /// </summary>
  [JsonPropertyName("cost")]
  public int Cost { get; protected set; }


  /// <summary>
  /// A set of custom images for the reward. This field is null if the broadcaster didn’t upload images.
  /// </summary>
  [JsonPropertyName("image")]
  public Image Image { get; protected set; }


  /// <summary>
  /// A set of default images for the reward.
  /// </summary>
  [JsonPropertyName("default_image")]
  public DefaultImage DefaultImage { get; protected set; }


  /// <summary>
  /// The background color to use for the reward. The color is in Hex format (for example, #00E5CB).
  /// </summary>
  [JsonPropertyName("background_color")]
  public string BackgroundColor { get; protected set; }


  /// <summary>
  /// A Boolean value that determines whether the reward is enabled. Is true if enabled; otherwise, false. Disabled rewards aren’t shown to the user.
  /// </summary>
  [JsonPropertyName("is_enabled")]
  public bool IsEnabled { get; protected set; }


  /// <summary>
  /// A Boolean value that determines whether the user must enter information when redeeming the reward. Is true if the user is prompted.
  /// </summary>
  [JsonPropertyName("is_user_input_required")]
  public bool IsUserInputRequired { get; protected set; }


  /// <summary>
  /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.
  /// </summary>
  [JsonPropertyName("max_per_stream_setting")]
  public MaxPerStreamSetting MaxPerStreamSetting { get; protected set; }


  /// <summary>
  /// The settings used to determine whether to apply a maximum to the number of redemptions allowed per user per live stream.
  /// </summary>
  [JsonPropertyName("max_per_user_per_stream_setting")]
  public MaxPerUserPerStreamSetting MaxPerUserPerStreamSetting { get; protected set; }

  /// <summary>
  /// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
  /// </summary>
  [JsonPropertyName("global_cooldown_setting")]
  public GlobalCooldownSetting GlobalCooldownSetting { get; protected set; }

  /// <summary>
  ///  A Boolean value that determines whether to pause the reward. Set to true to pause the reward. Viewers can’t redeem paused rewards, however the reward will still be visible with "Reward is temporarily unavailable. Check back for it soon." message. 
  /// </summary>
  [JsonPropertyName("is_paused")]
  public bool IsPaused { get; protected set; }

  /// <summary>
  /// A Boolean value that determines whether the reward is currently in stock. Is true if the reward is in stock. Viewers can’t redeem out of stock rewards.
  /// </summary>
  [JsonPropertyName("is_in_stock")]
  public bool IsInStock { get; protected set; }

  /// <summary>
  /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If false, status is set to UNFULFILLED and follows the normal request queue process.
  /// </summary>
  [JsonPropertyName("should_redemptions_skip_request_queue")]
  public bool ShouldRedemptionsSkipQueue { get; protected set; }

  /// <summary>
  /// The number of redemptions redeemed during the current live stream. The number counts against the MaxPerStreamSetting limit. This field is null if the broadcaster’s stream isn’t live or MaxPerStreamSetting isn’t enabled.
  /// </summary>
  [JsonPropertyName("redemptions_redeemed_current_stream")]
  public int? RedemptionsRedeemedCurrentStream { get; protected set; }

  /// <summary>
  /// The timestamp of when the cooldown period expires. Is null if the reward isn’t in a cooldown state. See the GlobalCooldownSetting field.
  /// </summary>
  [JsonPropertyName("cooldown_expires_at")]
  public string CooldownExpiresAt { get; protected set; }
}
