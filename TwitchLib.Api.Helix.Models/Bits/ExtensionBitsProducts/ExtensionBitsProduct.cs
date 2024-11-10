﻿using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Bits.ExtensionBitsProducts;

/// <summary>
/// List of Bits products that belongs to the extension.
/// </summary>
public class ExtensionBitsProduct
{
    /// <summary>
    /// The product’s SKU. The SKU is unique across an extension’s products.
    /// </summary>
    [JsonPropertyName("sku")]
    public string Sku { get; protected set; }

    /// <summary>
    /// An object that contains the product’s cost information.
    /// </summary>
    [JsonPropertyName("cost")]
    public Cost Cost { get; protected set; }

    /// <summary>
    /// A Boolean value that indicates whether the product is in development. If true, the product is not available for public use.
    /// </summary>
    [JsonPropertyName("in_development")]
    public bool InDevelopment { get; protected set; }

    /// <summary>
    /// The product’s name as displayed in the extension.
    /// </summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; protected set; }

    /// <summary>
    /// The date and time, in RFC3339 format, when the product expires.
    /// </summary>
    [JsonPropertyName("expiration")]
    public DateTime Expiration { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether Bits product purchase events are broadcast to all instances of an extension on a channel.
    /// </summary>
    [JsonPropertyName("is_broadcast")]
    public bool IsBroadcast { get; protected set; }
}
