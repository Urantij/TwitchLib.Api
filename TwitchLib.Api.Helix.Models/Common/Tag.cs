using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Common;

/// <summary>
/// Stream tag that the broadcaster or Twitch added to their channel.
/// </summary>
public class Tag
{
    /// <summary>
    /// An ID that identifies this tag.
    /// </summary>
    [JsonPropertyName("tag_id")]
    public string TagId { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the tag is an automatic tag.
    /// </summary>
    [JsonPropertyName("is_auto")]
    public bool IsAuto { get; protected set; }

    /// <summary>
    /// A dictionary that contains the localized names of the tag. 
    /// </summary>
    [JsonPropertyName("localization_names")]
    public Dictionary<string, string> LocalizationNames { get; protected set; }

    /// <summary>
    /// A dictionary that contains the localized descriptions of the tag.
    /// </summary>
    [JsonPropertyName("localization_descriptions")]
    public Dictionary<string, string> LocalizationDescriptions { get; protected set; }
}
