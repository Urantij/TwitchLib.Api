using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.AutomodSettings;

/// <summary>
/// Update automod settings reponse object.
/// </summary>
public class UpdateAutomodSettingsResponse
{
    /// <summary>
    /// The list of AutoMod settings. 
    /// The list contains a single object that contains all the AutoMod settings.
    /// </summary>
    [JsonPropertyName("data")]
    public AutomodSettings[] Data { get; protected set; }
}
