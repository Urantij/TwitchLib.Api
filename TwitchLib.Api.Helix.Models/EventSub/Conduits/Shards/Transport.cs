using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.Shards;

/// <summary>
/// The transport details used to send the notifications.
/// </summary>
public class Transport
{
    /// <summary>
    /// <para>The transport method. Possible values are:</para>
    /// <para>webhook, websocket</para>
    /// </summary>
    [JsonPropertyName("method")]
    public string Method { get; protected set; }

    /// <summary>
    /// <para>The callback URL where the notifications are sent. Included only if method is set to webhook.</para>
    /// </summary>
    [JsonPropertyName("callback")]
    public string Callback { get; protected set; }

    /// <summary>
    /// <para>An ID that identifies the WebSocket that notifications are sent to. Included only if method is set to websocket.</para>
    /// </summary>
    [JsonPropertyName("session_id")]
    public string SessionId { get; protected set; }

    /// <summary>
    /// <para>The UTC date and time that the WebSocket connection was established. Included only if method is set to websocket.</para>
    /// </summary>
    [JsonPropertyName("connected_at")]
    public string ConnectedAt { get; protected set; }

    /// <summary>
    /// <para>The UTC date and time that the WebSocket connection was lost. Included only if method is set to websocket.</para>
    /// </summary>
    [JsonPropertyName("disconnected_at")]
    public string DisconnectedAt { get; protected set; }
}