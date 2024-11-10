using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints;

/// <summary>
/// The settings used to determine whether to apply a cooldown period between redemptions and the length of the cooldown.
/// </summary>
public class GlobalCooldownSetting
{
  /// <summary>
  /// A Boolean value that determines whether to apply a cooldown period. Is true if a cooldown period is enabled.
  /// </summary>
  [JsonPropertyName("is_enabled")]
  public bool IsEnabled { get; protected set; }

  /// <summary>
  /// The cooldown period, in seconds.
  /// </summary>
  [JsonPropertyName("global_cooldown_seconds")]
  public int GlobalCooldownSeconds { get; protected set; }
}
