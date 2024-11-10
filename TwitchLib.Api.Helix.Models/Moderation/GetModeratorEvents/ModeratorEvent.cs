using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.GetModeratorEvents
{
    public class ModeratorEvent
    {
        [JsonPropertyName("id")]
        public string Id { get; protected set; }
        [JsonPropertyName("event_type")]
        public string EventType { get; protected set; }
        [JsonPropertyName("event_timestamp")]
        public DateTime EventTimestamp { get; protected set; }
        [JsonPropertyName("version")]
        public string Version { get; protected set; }
        [JsonPropertyName("event_data")]
        public EventData EventData { get; protected set; }
    }
}
