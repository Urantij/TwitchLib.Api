using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Badges.GetGlobalChatBadges;

/// <summary>
/// Twitch’s list of chat badges response object.
/// </summary>
public class GetGlobalChatBadgesResponse
{
    /// <summary>
    /// The list of chat badges. The list is sorted in ascending order by set_id, and within a set, the list is sorted in ascending order by id.
    /// </summary>
    [JsonPropertyName("data")]
    public BadgeEmoteSet[] EmoteSet { get; protected set; }
}
