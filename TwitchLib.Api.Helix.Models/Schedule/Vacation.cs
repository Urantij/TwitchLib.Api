﻿using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Schedule;

/// <summary>
/// The dates when the broadcaster is on vacation and not streaming.
/// </summary>
public class Vacation
{
    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation starts.
    /// </summary>
    [JsonPropertyName("start_time")]
    public DateTime StartTime { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the broadcaster’s vacation ends.
    /// </summary>
    [JsonPropertyName("end_time")]
    public DateTime EndTime { get; protected set; }
}