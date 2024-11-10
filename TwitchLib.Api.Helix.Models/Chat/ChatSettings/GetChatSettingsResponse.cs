﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Chat.ChatSettings;

/// <summary>
/// The broadcaster’s chat settings response model
/// </summary>
public class GetChatSettingsResponse
{
    /// <summary>
    /// The list of chat settings. The list contains a single object with all the settings.
    /// </summary>
    [JsonPropertyName("data")]
    public ChatSettingsResponseModel[] Data { get; protected set; }
}
