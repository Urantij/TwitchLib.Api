using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits;


/// <summary>
/// Information about the client�s conduit.
/// </summary>
public class Conduit
{
    /// <summary>
    /// <para>Conduit ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// <para>Number of shards associated with this conduit.</para>
    /// </summary>
    [JsonPropertyName("shard_count")]
    public int ShardCount { get; protected set; }
}