using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.Shards.UpdateConduitShards;

/// <summary>
/// Update conduit shards Response object.
/// </summary>
public class UpdateConduitShardsResponse
{
    /// <summary>
    /// <para>List of successful shard updates.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public Shard[] Shards { get; protected set; }

    /// <summary>
    /// <para>List of unsuccessful updates.</para>
    /// </summary>
    [JsonPropertyName("errors")]
    public Error[] Errors { get; protected set; }
}