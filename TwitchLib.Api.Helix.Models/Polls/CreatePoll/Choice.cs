﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Polls.CreatePoll;

/// <summary>
/// A choice that viewers may choose from.
/// </summary>
public class Choice
{
    /// <summary>
    /// One of the choices the viewer may select. 
    /// The choice may contain a maximum of 25 characters.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }
}
