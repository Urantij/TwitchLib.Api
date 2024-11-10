using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Chat.GetChatters;

/// <summary>
/// The list of users that are connected to the broadcaster’s chat session response item.
/// </summary>
public class GetChattersResponse
{
    /// <summary>
    /// List of login names that are connected to the broadcaster’s chat room.
    /// </summary>
    [JsonPropertyName("data")]
    public Chatter[] Data { get; protected set; }

    /// <summary>
    /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }

    /// <summary>
    /// The total number of users that are connected to the broadcaster’s chat room.
    /// <para>As you page through the list, the number of users may change as users join and leave the chat room.</para>
    /// </summary>
    [JsonPropertyName("total")]
    public int Total { get; protected set; }
}