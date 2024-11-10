﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Bits.ExtensionBitsProducts;

/// <summary>
/// List of Bits products that belongs to the extension response object.
/// </summary>
public class GetExtensionBitsProductsResponse
{
    /// <summary>
    /// A list of Bits products that the extension created. The list is in ascending SKU order. 
    /// </summary>
    [JsonPropertyName("data")]
    public ExtensionBitsProduct[] Data { get; protected set; }
}
