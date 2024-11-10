using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Entitlements.UpdateDropsEntitlements;

/// <summary>
/// The Drop entitlement’s fulfillment update status response object.
/// </summary>
public class UpdateDropsEntitlementsResponse
{
    /// <summary>
    /// A list that indicates which entitlements were successfully updated and those that weren’t.
    /// </summary>
    [JsonPropertyName("data")]
    public DropEntitlementUpdate[] DropEntitlementUpdates { get; protected set; }
}