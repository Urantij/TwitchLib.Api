using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.ChannelPoints;

/// <summary>
/// The reward that the user redeemed.
/// </summary>
public class Reward
{
  /// <summary>
  /// The ID that uniquely identifies the redeemed reward.
  /// </summary>
  [JsonPropertyName("id")]
  public string Id { get; protected set; }

  /// <summary>
  /// The reward’s title.
  /// </summary>
  [JsonPropertyName("title")]
  public string Title { get; protected set; }

  /// <summary>
  /// The prompt displayed to the viewer if user input is required.
  /// </summary>
  [JsonPropertyName("prompt")]
  public string Prompt { get; protected set; }

  /// <summary>
  /// The reward’s cost, in Channel Points.
  /// </summary>
  [JsonPropertyName("cost")]
  public int Cost { get; protected set; }
}
