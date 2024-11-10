using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Users.GetUserFollows
{
    public class GetUsersFollowsResponse
    {
        [JsonPropertyName("data")]
        public Follow[] Follows { get; protected set; }
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; protected set; }
        [JsonPropertyName("total")]
        public long TotalFollows { get; protected set; }
    }
}
