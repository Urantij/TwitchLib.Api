﻿using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.ShieldModeStatus;

/// <summary>
/// Object with the broadcaster’s Shield Mode status.
/// </summary>
public class ShieldModeStatus
{
    /// <summary>
    /// A Boolean value that determines whether Shield Mode is active.
    /// Is true if the broadcaster activated Shield Mode; otherwise, false.
    /// </summary>
    [JsonPropertyName("is_active")]
    public bool IsActive { get; protected set; }
    /// <summary>
    /// An ID that identifies the moderator that last activated Shield Mode.
    /// Is an empty string if Shield Mode hasn’t been previously activated.
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public string ModeratorId { get; protected set; }
    /// <summary>
    /// The moderator’s login name. Is an empty string if Shield Mode hasn’t been previously activated.
    /// </summary>
    [JsonPropertyName("moderator_login")]
    public string ModeratorLogin { get; protected set; }
    /// <summary>
    /// The moderator’s display name. Is an empty string if Shield Mode hasn’t been previously activated.
    /// </summary>
    [JsonPropertyName("moderator_name")]
    public string ModeratorName { get; protected set; }
    /// <summary>
    /// The UTC timestamp (in RFC3339 format) of when Shield Mode was last activated.
    /// Is an empty string if Shield Mode hasn’t been previously activated.
    /// </summary>
    [JsonPropertyName("last_activated_at")]
    public string LastActivatedAt { get; protected set; }
}
