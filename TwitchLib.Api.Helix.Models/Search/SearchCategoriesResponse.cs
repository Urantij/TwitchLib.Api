using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Search;

/// <summary>
/// Search categories response object.
/// </summary>
public class SearchCategoriesResponse
{
    /// <summary>
    /// The list of games or categories that match the query. The list is empty if there are no matches.
    /// </summary>
    [JsonPropertyName("data")]
    public Game[] Games { get; protected set; }

    /// <summary>
    /// The information used to page through the list of results.
    /// </summary>
    [JsonPropertyName("pagination")]
    public Pagination Pagination { get; protected set; }
}
