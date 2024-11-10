using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.Shards.UpdateConduitShards;

/// <summary>
/// Request object for update conduit shards.
/// </summary>
public class UpdateConduitShardsRequest
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("conduit_id")]
    public string ConduitId { get; set; }

    /// <summary>
    /// <para>List of shards to update.</para>
    /// </summary>
    [JsonPropertyName("shards")]
    public ShardUpdate[] Shards { get; set; }
}