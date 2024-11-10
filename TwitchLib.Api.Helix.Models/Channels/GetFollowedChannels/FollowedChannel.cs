using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Channels.GetFollowedChannels;

/// <summary>
/// <para>The broadcaster a user is following.</para>
/// </summary>
public class FollowedChannel
{
  /// <summary>
  /// <para>An ID that uniquely identifies the broadcaster that this user is following.</para>
  /// </summary>
  [JsonPropertyName("broadcaster_id")]
  public string BroadcasterId { get; protected set; }

  /// <summary>
  /// <para>The broadcaster’s login name. (Name is lowercase)</para>
  /// </summary>
  [JsonPropertyName("broadcaster_login")]
  public string BroadcasterLogin { get; protected set; }

  /// <summary>
  /// <para>The broadcaster’s display name. (Name has capitalization)</para>
  /// </summary>
  [JsonPropertyName("broadcaster_name")]
  public string BroadcasterName { get; protected set; }

  /// <summary>
  /// <para>The UTC timestamp when the user started following the broadcaster.</para>
  /// </summary>
  [JsonPropertyName("followed_at")]
  public string FollowedAt { get; protected set; }
}