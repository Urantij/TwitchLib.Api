using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Streams.GetStreamTags
{
    public class GetStreamTagsResponse
    {
        [JsonPropertyName("data")]
        public Tag[] Data { get; protected set; }
    }
}
