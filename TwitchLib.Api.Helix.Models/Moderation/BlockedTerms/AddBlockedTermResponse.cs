using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.BlockedTerms;

/// <summary>
/// Add blocked term response object.
/// </summary>
public class AddBlockedTermResponse
{
    /// <summary>
    /// A list that contains the single blocked term that the broadcaster added.
    /// </summary>
    [JsonPropertyName("data")]
    public BlockedTerm[] Data { get; protected set; }
}
