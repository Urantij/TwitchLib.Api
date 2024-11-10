using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Helix.Models.Extensions.Transactions;

/// <summary>
/// Details about the digital product’s cost.
/// </summary>
public class Cost
{
    /// <summary>
    /// The amount exchanged for the digital product.
    /// </summary>
    [JsonPropertyName("amount")]
    public int Amount { get; protected set; }

    /// <summary>
    /// The type of currency exchanged. 
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; protected set; }
}
