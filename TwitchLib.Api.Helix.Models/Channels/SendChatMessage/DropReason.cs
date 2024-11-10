using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Channels.SendChatMessage
{
    public class DropReason
    {
        /// <summary>
        /// 	Code for why the message was dropped.
        /// </summary>
        [JsonPropertyName("code")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Code { get; set; } = string.Empty;
        /// <summary>
        /// Message for why the message was dropped.
        /// </summary>
        [JsonPropertyName("message")]
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Message { get; set; } = string.Empty;
    }
}
