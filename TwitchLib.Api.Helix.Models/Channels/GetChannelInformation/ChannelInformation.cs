using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Channels.GetChannelInformation;

/// <summary>
/// <para>Information about a channel</para>
/// </summary>
public class ChannelInformation
{
  /// <summary>
  /// <para>An ID that uniquely identifies the broadcaster.</para>
  /// </summary>
  [JsonPropertyName("broadcaster_id")]
  public string BroadcasterId { get; protected set; }

  /// <summary>
  /// <para>The broadcaster’s login name.</para>
  /// </summary>
  [JsonPropertyName("broadcaster_login")]
  public string BroadcasterLogin { get; protected set; }

  /// <summary>
  /// <para>The broadcaster’s display name.</para>
  /// </summary>
  [JsonPropertyName("broadcaster_name")]
  public string BroadcasterName { get; protected set; }

  /// <summary>
  /// <para>An ID that uniquely identifies the game that the broadcaster is playing or last played.</para> 
  /// <para>The value is an empty string if the broadcaster has never played a game.</para>
  /// </summary>
  [JsonPropertyName("game_id")]
  public string GameId { get; protected set; }

  /// <summary>
  /// <para>The broadcaster’s preferred language.</para>
  /// <para>The value is an ISO 639-1 two-letter language code (for example, en for English). The value is set to “other” if the language is not a Twitch supported language.</para>
  /// </summary>
  [JsonPropertyName("broadcaster_language")]
  public string BroadcasterLanguage { get; protected set; }

  /// <summary>
  /// <para> 	The name of the game that the broadcaster is playing or last played.</para>
  /// <para>The value is an empty string if the broadcaster has never played a game.</para>
  /// </summary>
  [JsonPropertyName("game_name")]
  public string GameName { get; protected set; }

  /// <summary>
  /// <para>The title of the stream that the broadcaster is currently streaming or last streamed.</para>
  /// <para>The value is an empty string if the broadcaster has never streamed.</para>
  /// </summary>
  [JsonPropertyName("title")]
  public string Title { get; protected set; }

  /// <summary>
  /// <para>The value of the broadcaster’s stream delay setting, in seconds.</para>
  /// <para>This field’s value defaults to zero unless 1) the request specifies a user access token, 2) the ID in the broadcaster_id query parameter matches the user ID in the access token, and 3) the broadcaster has partner status and they set a non-zero stream delay value.</para>
  /// </summary>
  [JsonPropertyName("delay")]
  public int Delay { get; protected set; }

  /// <summary>
  /// <para>The tags applied to the channel.</para>
  /// </summary>
  [JsonPropertyName("tags")]
  public string[] Tags { get; protected set; }

  /// <summary>
  /// <para>The Content Classification Labels (CCL) applied to the channel.</para>
  /// </summary>
  [JsonPropertyName("content_classification_labels")]
  public string[] ContentClassificationLabels { get; protected set; }

  /// <summary>
  /// <para>Boolean flag indicating if the channel has branded content.</para>
  /// </summary>
  [JsonPropertyName("is_branded_content")]
  public bool IsBrandedContent { get; protected set; }
}
