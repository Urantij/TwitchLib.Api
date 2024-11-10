using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Extensions.Transactions;

/// <summary>
/// The transactions.
/// </summary>
public class Transaction
{
    /// <summary>
    /// An ID that identifies the transaction.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of the transaction.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; protected set; }

    /// <summary>
    /// The ID of the broadcaster that owns the channel where the transaction occurred.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }

    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string BroadcasterName { get; protected set; }

    /// <summary>
    /// The ID of the user that purchased the digital product.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// The user’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The type of transaction.
    /// </summary>
    [JsonPropertyName("product_type")]
    public string ProductType { get; protected set; }

    /// <summary>
    /// Contains details about the digital product.
    /// </summary>
    [JsonPropertyName("product_data")]
    public ProductData ProductData { get; protected set; }
}
