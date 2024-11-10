using System;
using System.Text.Json.Serialization;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Helix.Models.Entitlements.GetDropsEntitlements;

/// <summary>
/// An organization’s entitlement that has been granted to a game, a user, or both.
/// </summary>
public class DropsEntitlement
{
    /// <summary>
    /// An ID that identifies the entitlement.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// An ID that identifies the benefit (reward).
    /// </summary>
    [JsonPropertyName("benefit_id")]
    public string BenefitId { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the entitlement was granted.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; protected set; }

    /// <summary>
    /// An ID that identifies the user who was granted the entitlement.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// An ID that identifies the game the user was playing when the reward was entitled.
    /// </summary>
    [JsonPropertyName("game_id")]
    public string GameId { get; protected set; }

    /// <summary>
    /// The entitlement’s fulfillment status.
    /// </summary>
    [JsonPropertyName("fulfillment_status")]
    public FulfillmentStatus FulfillmentStatus { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the entitlement was last updated.
    /// </summary>
    [JsonPropertyName("last_updated")]
    public DateTime LastUpdated { get; protected set; }
}
