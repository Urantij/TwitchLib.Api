using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.EventSub.Conduits.CreateConduits;

/// <summary>
/// Create a new conduit response object.
/// </summary>
public class CreateConduitsResponse
{
    /// <summary>
    /// <para>List of information about the client’s conduits.</para>
    /// </summary>
    [JsonPropertyName("data")]
    public Conduit[] Data { get; protected set; }
}