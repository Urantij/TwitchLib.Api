﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints;

/// <summary>
/// A set of default images for the reward.
/// </summary>
public class DefaultImage
{
  /// <summary>
  /// The URL to a small version of the image.
  /// </summary>
  [JsonPropertyName("url_1x")]
  public string Url1x { get; }

  /// <summary>
  /// The URL to a medium version of the image.
  /// </summary>
  [JsonPropertyName("url_2x")]
  public string Url2x { get; }

  /// <summary>
  /// The URL to a large version of the image.
  /// </summary>
  [JsonPropertyName("url_4x")]
  public string Url4x { get; }
}
