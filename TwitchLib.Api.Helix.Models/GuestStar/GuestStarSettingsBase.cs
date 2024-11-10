using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.GuestStar;

/// <summary>
/// Guest Star Settings Base
/// </summary>
public abstract class GuestStarSettingsBase
{
    /// <summary>
    /// Flag determining if Guest Star moderators have access to control whether a guest is live once assigned to a slot.
    /// </summary>
    [JsonPropertyName("is_moderator_send_live_enabled")]
    public bool IsModeratorSendLiveEnabled { get; protected set; }
    /// <summary>
    /// Number of slots the Guest Star call interface will allow the host to add to a call. Required to be between 1 and 6.
    /// </summary>
    [JsonPropertyName("slot_count")]
    public int SlotCount { get; protected set; }
    /// <summary>
    /// Flag determining if Browser Sources subscribed to sessions on this channel should output audio
    /// </summary>
    [JsonPropertyName("is_browser_source_audio_enabled")]
    public bool IsBrowserSourceAudioEnabled { get; protected set; }
    /// <summary>
    /// This setting determines how the guests within a session should be laid out within the browser source. Can be one of the following values:
    /// <para>TILED_LAYOUT: All live guests are tiled within the browser source with the same size.</para>
    /// <para>SCREENSHARE_LAYOUT: All live guests are tiled within the browser source with the same size. If there is an active screen share, it is sized larger than the other guests.</para>
    /// </summary>
    [JsonPropertyName("group_layout")]
    public string GroupLayout { get; protected set; }
}