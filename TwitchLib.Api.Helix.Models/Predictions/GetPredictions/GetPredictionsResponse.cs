using System.Text.Json.Serialization;
using TwitchLib.Api.Helix.Models.Common;

namespace TwitchLib.Api.Helix.Models.Predictions.GetPredictions
{
    public class GetPredictionsResponse
    {
        public GetPredictionsResponse(Prediction[] data = null, Pagination pagination = null)
        {
            Data = data;
            Pagination = pagination;
        }

        [JsonPropertyName("data")]
        public Prediction[] Data { get; protected set; }
        [JsonPropertyName("pagination")]
        public Pagination Pagination { get; protected set; }
    }
}
