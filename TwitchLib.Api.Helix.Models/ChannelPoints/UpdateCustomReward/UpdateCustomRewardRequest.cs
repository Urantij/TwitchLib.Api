using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints.UpdateCustomReward;

/// <summary>
/// Updates a custom reward. The app used to create the reward is the only app that may update the reward.
/// 
/// Requires a user access token that includes the channel:manage:redemptions scope.
/// </summary>
// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/migrate-from-newtonsoft?pivots=dotnet-8-0#jsonobjectattribute
// [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
public class UpdateCustomRewardRequest
{
  /// <summary>
  /// The reward’s title. The title may contain a maximum of 45 characters and it must be unique amongst all of the broadcaster’s custom rewards.
  /// </summary>
  [JsonPropertyName("title")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public string Title { get; set; }

  /// <summary>
  /// The prompt shown to the viewer when they redeem the reward. Specify a prompt if IsUserInputRequired is true. The prompt is limited to a maximum of 200 characters.
  /// </summary>
  [JsonPropertyName("prompt")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public string Prompt { get; set; }

  /// <summary>
  /// The cost of the reward, in channel points. The minimum is 1 point.
  /// </summary>
  [JsonPropertyName("cost")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public int? Cost { get; set; }

  /// <summary>
  /// The background color to use for the reward. Specify the color using Hex format (for example, #00E5CB).
  /// </summary>
  [JsonPropertyName("background_color")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public string BackgroundColor { get; set; }

  /// <summary>
  /// A Boolean value that indicates whether the reward is enabled. Set to true to enable the reward. Viewers see only enabled rewards.
  /// </summary>
  [JsonPropertyName("is_enabled")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? IsEnabled { get; set; }

  /// <summary>
  /// A Boolean value that determines whether users must enter information to redeem the reward. Set to true if user input is required. See the Prompt field.
  /// </summary>
  [JsonPropertyName("is_user_input_required")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? IsUserInputRequired { get; set; }

  /// <summary>
  /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per live stream (see the MaxPerStream field). Set to true to limit redemptions.
  /// </summary>
  [JsonPropertyName("is_max_per_stream_enabled")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? IsMaxPerStreamEnabled { get; set; }

  /// <summary>
  ///  The maximum number of redemptions allowed per live stream. Applied only if IsMaxPerUserPerStreamEnabled is true. The minimum value is 1.
  /// </summary>
  [JsonPropertyName("max_per_stream")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public int? MaxPerStream { get; set; }

  /// <summary>
  /// A Boolean value that determines whether to limit the maximum number of redemptions allowed per user per stream (see MaxPerUserPerStream). The minimum value is 1. Set to true to limit redemptions.
  /// </summary>
  [JsonPropertyName("is_max_per_user_per_stream_enabled")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? IsMaxPerUserPerStreamEnabled { get; set; }

  /// <summary>
  /// The maximum number of redemptions allowed per user per stream. Applied only if IsMaxPerUserPerStreamEnabled is true.
  /// </summary>
  [JsonPropertyName("max_per_user_per_stream")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public int? MaxPerUserPerStream { get; set; }

  /// <summary>
  ///  A Boolean value that determines whether to apply a cooldown period between redemptions. Set to true to apply a cooldown period. For the duration of the cooldown period, see GlobalCooldownSeconds.
  /// </summary>
  [JsonPropertyName("is_global_cooldown_enabled")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? IsGlobalCooldownEnabled { get; set; }

  /// <summary>
  /// The cooldown period, in seconds. Applied only if IsGlobalCooldownEnabled is true. The minimum value is 1; however, for it to be shown in the Twitch UX, the minimum value is 60.
  /// </summary>
  [JsonPropertyName("global_cooldown_seconds")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public int? GlobalCooldownSeconds { get; set; }

  /// <summary>
  ///  A Boolean value that determines whether to pause the reward. Set to true to pause the reward. Viewers can’t redeem paused rewards, however the reward will still be visible with "Reward is temporarily unavailable. Check back for it soon." message. 
  /// </summary>
  [JsonPropertyName("is_paused")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? IsPaused { get; set; }

  /// <summary>
  /// A Boolean value that determines whether redemptions should be set to FULFILLED status immediately when a reward is redeemed. If false, status is set to UNFULFILLED and follows the normal request queue process.
  /// </summary>
  [JsonPropertyName("should_redemptions_skip_request_queue")]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public bool? ShouldRedemptionsSkipRequestQueue { get; set; }
}
