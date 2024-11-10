using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Schedule;

/// <summary>
/// The type of content.
/// </summary>
public class Category
{
    /// <summary>
    /// An ID that identifies the category that best represents the content.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The name of the category.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; protected set; }
}