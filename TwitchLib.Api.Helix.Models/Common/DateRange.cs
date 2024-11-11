using System.Text.Json.Serialization;
using System;

namespace TwitchLib.Api.Helix.Models.Common;

/// <summary>
/// <para>The reporting period's start and end dates</para>
/// </summary>
public class DateRange
{
  /// <summary>
  /// <para>The reporting period's start date.</para>
  /// </summary>
  [JsonPropertyName("started_at")]
  public DateTime StartedAt { get; protected set; }

  /// <summary>
  /// <para>The reporting period's end date.</para>
  /// </summary>
  [JsonPropertyName("ended_at")]
  public DateTime EndedAt { get; protected set; }

  public DateRange(DateTime startedAt = default, DateTime endedAt = default)
  {
    StartedAt = startedAt;
    EndedAt = endedAt;
  }
}
