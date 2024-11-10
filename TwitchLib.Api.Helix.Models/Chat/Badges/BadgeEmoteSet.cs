using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.Badges;

/// <summary>
/// Badge set from teh list of chat badges.
/// </summary>
public class BadgeEmoteSet
{
    /// <summary>
    /// An ID that identifies this set of chat badges. For example, Bits or Subscriber.
    /// </summary>
    [JsonPropertyName("set_id")]
    public string SetId { get; protected set; }

    /// <summary>
    /// The list of chat badges in this set.
    /// </summary>
    [JsonPropertyName("versions")]
    public BadgeVersion[] Versions { get; protected set; }
}
