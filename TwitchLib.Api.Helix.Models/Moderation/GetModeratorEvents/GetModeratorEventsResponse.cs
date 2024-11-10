using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Moderation.GetModeratorEvents
{
    public class GetModeratorEventsResponse
    {
        [JsonPropertyName("data")]
        public ModeratorEvent[] Data { get; protected set; }
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; protected set; }
    }
}
