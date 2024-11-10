using System.Text.Json.Serialization;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Helix.Models.Entitlements.UpdateDropsEntitlements;

/// <summary>
/// The Drop entitlement’s fulfillment update status.
/// </summary>
public class DropEntitlementUpdate
{
    /// <summary>
    /// A string that indicates whether the status of the entitlements in the ids field were successfully updated.
    /// </summary>
    [JsonPropertyName("status")]
    public DropEntitlementUpdateStatus Status { get; protected set; }

    /// <summary>
    /// The list of entitlements that the status in the status field applies to.
    /// </summary>
    [JsonPropertyName("ids")]
    public string[] Ids { get; protected set; }
}