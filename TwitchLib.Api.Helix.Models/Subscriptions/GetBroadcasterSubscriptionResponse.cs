using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Subscriptions;

/// <summary>
/// Get broadcaster subsriptions response object.
/// </summary>
public class GetBroadcasterSubscriptionsResponse
{
    /// <summary>
    /// The list of users that subscribe to the broadcaster.
    /// </summary>
    [JsonPropertyName("data")]
    public Subscription[] Data { get; protected set; }

    /// <summary>
    /// Contains the information used to page through the list of results.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }

    /// <summary>
    /// The total number of users that subscribe to this broadcaster.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; protected set; }

    /// <summary>
    /// The current number of subscriber points earned by this broadcaster.
    /// </summary>
    [JsonPropertyName("points")]
    public int Points { get; protected set; }
}