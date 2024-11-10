using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Channels.GetChannelFollowers;

/// <summary>
/// A user that follow the specified broadcaster. 
/// </summary>
public class ChannelFollower
{
    /// <summary>
    /// An ID that uniquely identifies the user that’s following the broadcaster.
    /// </summary>
    [JsonPropertyName("user_id")]
    public string UserId { get; protected set; }
    
    /// <summary>
    /// The user’s login name.
    /// </summary>
    [JsonPropertyName("user_login")]
    public string UserLogin { get; protected set; }
    
    /// <summary>
    /// The user’s display name.
    /// </summary>
    [JsonPropertyName("user_name")]
    public string UserName { get; protected set; }
    
    /// <summary>
    /// The UTC timestamp when the user started following the broadcaster.
    /// </summary>
    [JsonPropertyName("followed_at")]
    public string FollowedAt { get; protected set;  }
}