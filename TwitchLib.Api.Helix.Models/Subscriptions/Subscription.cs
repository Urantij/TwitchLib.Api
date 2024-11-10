using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Subscriptions;

/// <summary>
/// Information about the user’s subscription.
/// </summary>
public class Subscription
{
    /// <summary>
    /// An ID that identifies the broadcaster.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string BroadcasterName { get; protected set; }

    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the subscription is a gift subscription.
    /// </summary>
    [JsonPropertyName("is_gift")]
    public bool IsGift { get; protected set; }

    /// <summary>
    /// The type of subscription.
    /// </summary>
    [JsonPropertyName("tier")]
    public string Tier { get; protected set; }

    /// <summary>
    /// The name of the subscription.
    /// </summary>
    [JsonPropertyName("plan_name")]
    public string PlanName { get; protected set; }

    /// <summary>
    /// An ID that identifies the subscribing user.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }

    /// <summary>
    /// The user’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }

    /// <summary>
    /// The user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }

    /// <summary>
    /// The ID of the user that gifted the subscription.
    /// </summary>
    [JsonPropertyName("gifter_id")]
    public string GiftertId { get; protected set; }

    /// <summary>
    /// The gifter’s login name. 
    /// </summary>
    [JsonPropertyName("gifter_name")]
    public string GifterName { get; protected set; }

    /// <summary>
    /// The gifter’s display name.
    /// </summary>
    [JsonPropertyName("gifter_login")]
    public string GifterLogin { get; protected set; }
}
