using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.Shards.UpdateConduitShards;

/// <summary>
/// Shard to update.
/// </summary>
public class ShardUpdate
{
    /// <summary>
    /// <para>Shard ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// <para>The transport details that you want Twitch to use when sending you notifications.</para>
    /// </summary>
    [JsonPropertyName("transport")]
    public TransportUpdate Transport { get; set; }
    
}