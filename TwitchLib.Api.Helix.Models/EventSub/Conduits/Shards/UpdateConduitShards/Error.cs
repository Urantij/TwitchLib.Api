using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.Shards.UpdateConduitShards;

/// <summary>
/// Unsuccessful update conduit shard errors.
/// </summary>
public class Error
{
    /// <summary>
    /// <para>Shard ID.</para>
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// <para>The error that occurred while updating the shard.</para>
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; protected set; }

    /// <summary>
    /// <para>Error codes used to represent a specific error condition while attempting to update shards.</para>
    /// </summary>
    [JsonPropertyName("code")]
    public string Code { get; protected set; }
}