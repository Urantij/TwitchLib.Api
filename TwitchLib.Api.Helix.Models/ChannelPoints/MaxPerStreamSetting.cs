﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints;

/// <summary>
/// The settings used to determine whether to apply a maximum to the number of redemptions allowed per live stream.
/// </summary>
public class MaxPerStreamSetting
{
  /// <summary>
  /// A Boolean value that determines whether the reward applies a limit on the number of redemptions allowed per live stream. Is true if the reward applies a limit.
  /// </summary>
  [JsonPropertyName("is_enabled")]
  public bool IsEnabled { get; protected set; }

  /// <summary>
  /// The maximum number of redemptions allowed per live stream.
  /// </summary>
  [JsonPropertyName("max_per_stream")]
  public int MaxPerStream { get; protected set; }
}
