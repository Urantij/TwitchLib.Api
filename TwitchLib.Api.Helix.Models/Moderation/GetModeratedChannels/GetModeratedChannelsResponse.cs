using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;
using TwitchLib.Api.Helix.Models.Common;
using TwitchLib.Api.Helix.Models.Moderation.GetModerators;

namespace TwitchLib.Api.Helix.Models.Moderation.GetModeratedChannels;

/// <summary>
/// List of channels that the specified user has moderator privileges in.
/// </summary>
public class GetModeratedChannelsResponse
{
    /// <summary>
    /// The list of channels that the user has moderator privileges in.
    /// </summary>
    [JsonPropertyName("data")]
    public ModeratedChannel[] Data { get; protected set; }
    /// <summary>
    /// Contains the information used to page through the list of results. The object is empty if there are no more pages left to page through.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
