using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.UpdateConduits;

/// <summary>
/// Request object for Update Conduits.
/// </summary>
public class UpdateConduitsRequest
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// <para>The new number of shards for this conduit.</para>
    /// </summary>
    [JsonPropertyName("shard_count")]
    public int ShardCount { get; set; }
}