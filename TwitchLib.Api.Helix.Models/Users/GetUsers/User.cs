using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Users.GetUsers;

/// <summary>
/// A user.
/// </summary>
public class User
{
    /// <summary>
    /// An ID that identifies the user.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The user�s login name.
    /// </summary>
    [JsonPropertyName("login")]
    public string Login { get; protected set; }

    /// <summary>
    /// The user�s display name.
    /// </summary>
    [JsonPropertyName("display_name")]
    public string DisplayName { get; protected set; }

    /// <summary>
    /// The UTC date and time that the user�s account was created. The timestamp is in RFC3339 format.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; protected set; }

    /// <summary>
    /// The type of user.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; protected set; }

    /// <summary>
    /// The type of broadcaster.
    /// </summary>
    [JsonPropertyName("broadcaster_type")]
    public string BroadcasterType { get; protected set; }

    /// <summary>
    /// The user�s description of their channel.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; protected set; }

    /// <summary>
    /// A URL to the user�s profile image.
    /// </summary>
    [JsonPropertyName("profile_image_url")]
    public string ProfileImageUrl { get; protected set; }

    /// <summary>
    /// A URL to the user�s offline image.
    /// </summary>
    [JsonPropertyName("offline_image_url")]
    public string OfflineImageUrl { get; protected set; }

    /// <summary>
    /// The number of times the user�s channel has been viewed.
    /// </summary>
    [Obsolete]
    [JsonPropertyName("view_count")]
    public long ViewCount { get; protected set; }

    /// <summary>
    /// The user�s verified email address. 
    /// The object includes this field only if the user access token includes the user:read:email scope.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; protected set; }
}
