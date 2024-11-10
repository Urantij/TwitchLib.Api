﻿using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Entitlements.GetDropsEntitlements;

/// <summary>
/// An organization’s list of entitlements that have been granted to a game, a user, or both response object.
/// </summary>
public class GetDropsEntitlementsResponse
{
    /// <summary>
    /// The list of entitlements.
    /// </summary>
    [JsonPropertyName("data")]
    public DropsEntitlement[] DropEntitlements { get; protected set; }

    /// <summary>
    /// The information used to page through the list of results.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
