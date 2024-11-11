using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Teams;

/// <summary>
/// Team Base model
/// </summary>
public abstract class TeamBase
{
    protected TeamBase(string banner = null, string backgroundImageUrl = null, string createdAt = null, string updatedAt = null, string info = null, string thumbnailUrl = null, string teamName = null, string teamDisplayName = null, string id = null)
    {
        Banner = banner;
        BackgroundImageUrl = backgroundImageUrl;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
        Info = info;
        ThumbnailUrl = thumbnailUrl;
        TeamName = teamName;
        TeamDisplayName = teamDisplayName;
        Id = id;
    }

    /// <summary>
    /// A URL to the team’s banner.
    /// </summary>
    [JsonPropertyName("banner")]
    public string Banner { get; protected set; }

    /// <summary>
    /// A URL to the team’s background image.
    /// </summary>
    [JsonPropertyName("background_image_url")]
    public string BackgroundImageUrl { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the team was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public string CreatedAt { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of the last time the team was updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public string UpdatedAt { get; protected set; }

    /// <summary>
    /// The team’s description.
    /// The description may contain formatting such as Markdown, HTML, newline (\n) characters, etc.
    /// </summary>
    [JsonPropertyName("info")]
    public string Info { get; protected set; }

    /// <summary>
    /// A URL to a thumbnail image of the team’s logo.
    /// </summary>
    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; protected set; }

    /// <summary>
    /// The team’s name.
    /// </summary>
    [JsonPropertyName("team_name")]
    public string TeamName { get; protected set; }

    /// <summary>
    /// The team’s display name.
    /// </summary>
    [JsonPropertyName("team_display_name")]
    public string TeamDisplayName { get; protected set; }

    /// <summary>
    /// An ID that identifies the team.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }
}