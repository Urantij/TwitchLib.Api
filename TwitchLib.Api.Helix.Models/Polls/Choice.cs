using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Polls
{
    /// <summary>
    /// A choice that viewers can choose from.
    /// </summary>
    public class Choice
    {
        /// <summary>
        /// An ID that identifies this choice.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; protected set; }

        /// <summary>
        /// The choice's title. The title may contain a maximum of 25 characters.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; protected set; }

        /// <summary>
        /// The total number of votes cast for this choice.
        /// </summary>
        [JsonPropertyName("votes")]
        public int Votes { get; protected set; }

        /// <summary>
        /// The number of votes cast using Channel Points.
        /// </summary>
        [JsonPropertyName("channel_points_votes")]
        public int ChannelPointsVotes { get; protected set; }

        /// <summary>
        /// Not used; will be set to 0.
        /// </summary>
        [JsonPropertyName("bits_votes")]
        public int BitsVotes { get; protected set; }
    }
}
