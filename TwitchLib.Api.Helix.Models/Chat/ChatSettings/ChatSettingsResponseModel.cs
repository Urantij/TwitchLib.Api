using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.ChatSettings;

/// <summary>
/// Chat settings response model
/// </summary>
public class ChatSettingsResponseModel
{
    /// <summary>
    /// The ID of the broadcaster specified in the request.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether chat messages must contain only emotes.
    /// </summary>
    [JsonPropertyName("emote_mode")]
    public bool EmoteMode { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only.
    /// </summary>
    [JsonPropertyName("follower_mode")]
    public bool FollowerMode { get; protected set; }

    /// <summary>
    /// The length of time, in minutes, that users must follow the broadcaster before being able to participate in the chat room. Is null if follower_mode is false.
    /// </summary>
    [JsonPropertyName("follower_mode_duration")]
    public int? FollowerModeDuration { get; protected set; }

    /// <summary>
    /// The moderator’s ID.
    /// </summary>
    [JsonPropertyName("moderator_id")]
    public bool ModeratorId { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the broadcaster adds a short delay before chat messages appear in the chat room. 
    /// </summary>
    [JsonPropertyName("non_moderator_chat_delay")]
    public bool NonModeratorChatDelay { get; protected set; }

    /// <summary>
    /// The amount of time, in seconds, that messages are delayed before appearing in chat. 
    /// </summary>
    [JsonPropertyName("non_moderator_chat_delay_duration")]
    public int? NonModeratorChatDelayDuration { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.
    /// </summary>
    [JsonPropertyName("slow_mode")]
    public bool SlowMode { get; protected set; }

    /// <summary>
    /// The amount of time, in seconds, that users must wait between sending messages.
    /// </summary>
    [JsonPropertyName("slow_mode_wait_time")]
    public int? SlowModeWaitDuration { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether only users that subscribe to the broadcaster’s channel may talk in the chat room.
    /// </summary>
    [JsonPropertyName("subscriber_mode")]
    public bool SubscriberMode { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.
    /// </summary>
    [JsonPropertyName("unique_chat_mode")]
    public bool UniqueChatMode { get; protected set; }




}
