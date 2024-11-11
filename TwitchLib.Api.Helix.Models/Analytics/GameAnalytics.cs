using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Analytics;

/// <summary>
/// <para></para>
/// </summary>
public class GameAnalytics
{
  /// <summary>
  /// <para>An ID that identifies the game that the analytic report was generated for.</para>
  /// </summary>
  [JsonPropertyName("game_id")]
  public string GameId { get; protected set; }

  /// <summary>
  /// <para>The URL that you use to download the analytic report.</para>
  /// <para><b>The URL is valid for 5 minutes.</b></para>
  /// </summary>
  [JsonPropertyName("URL")]
  public string Url { get; protected set; }

  /// <summary>
  /// <para>The type of analytic report.</para>
  /// </summary>
  [JsonPropertyName("type")]
  public string Type { get; protected set; }

  /// <summary>
  /// <para>The reporting period’s start and end dates.</para>
  /// </summary>
  [JsonPropertyName("date_range")]
  public DateRange DateRange { get; protected set; }

  public GameAnalytics(string gameId = null, string url = null, string type = null, DateRange dateRange = null)
  {
    GameId = gameId;
    Url = url;
    Type = type;
    DateRange = dateRange;
  }
}
