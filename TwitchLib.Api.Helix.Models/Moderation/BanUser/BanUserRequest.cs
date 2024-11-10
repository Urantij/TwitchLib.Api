﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.BanUser;

/// <summary>
/// Ban user request object.
/// </summary>
public class BanUserRequest
{
    /// <summary>
    /// The ID of the user to ban or put in a timeout.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    /// <summary>
    /// The reason the you’re banning the user or putting them in a timeout. 
    /// The text is user defined and is limited to a maximum of 500 characters.
    /// </summary>
    [JsonPropertyName("reason")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string Reason { get; set; } = string.Empty;

    /// <summary>
    /// To ban a user indefinitely, don’t include this field.
    /// To put a user in a timeout, include this field and specify the timeout period, in seconds. 
    /// The minimum timeout is 1 second and the maximum is 1,209,600 seconds (2 weeks).
    /// </summary>
    [JsonPropertyName("duration")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public int? Duration { get; set; }
}