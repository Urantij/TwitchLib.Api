using System.Text.Json.Serialization;
using System;

namespace TwitchLib.Api.Helix.Models.Channels.GetChannelEditors;

/// <summary>
/// <para>A user that is a channel editor for the broadcaster.</para>
/// </summary>
public class ChannelEditor
{
  /// <summary>
  /// <para>An ID that uniquely identifies a user with editor permissions.</para>
  /// </summary>
  [JsonPropertyName("user_id")]
  public string UserId { get; protected set; }

  /// <summary>
  /// <para>The user’s display name.</para>
  /// </summary>
  [JsonPropertyName("user_name")]
  public string UserName { get; protected set; }

  /// <summary>
  /// <para>The date and time when the user became one of the broadcaster’s editors.</para>
  /// </summary>
  [JsonPropertyName("created_at")]
  public DateTime CreatedAt { get; protected set; }
}
