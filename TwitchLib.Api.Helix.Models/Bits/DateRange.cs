using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Bits;

/// <summary>
/// The reporting window’s start and end dates
/// </summary>
public class DateRange
{
    /// <summary>
    /// The reporting window’s start date.
    /// </summary>
    [JsonPropertyName("started_at")]
    public DateTime StartedAt { get; protected set; }

    /// <summary>
    /// The reporting window’s end date.
    /// </summary>
    [JsonPropertyName("ended_at")]
    public DateTime EndedAt { get; protected set; }
}
