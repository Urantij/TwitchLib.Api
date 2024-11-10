using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.EventSub;

/// <summary>
/// Get eventsub subscriptions response object.
/// </summary>
public class GetEventSubSubscriptionsResponse
{
    /// <summary>
    /// The total number of subscriptions you’ve created.
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; protected set; }

    /// <summary>
    /// An array of subscription objects. The list is empty if you don’t have any subscriptions.
    /// </summary>
    [JsonPropertyName("data")]
    public EventSubSubscription[] Subscriptions { get; protected set; }

    /// <summary>
    /// The sum of all of your subscription costs.
    /// </summary>
    [JsonPropertyName("total_cost")]
    public int TotalCost { get; protected set; }

    /// <summary>
    /// The maximum total cost that you’re allowed to incur for all subscriptions you create.
    /// </summary>
    [JsonPropertyName("max_total_cost")]
    public int MaxTotalCost { get; protected set; }

    /// <summary>
    /// An object that contains the cursor used to get the next page of subscriptions.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}