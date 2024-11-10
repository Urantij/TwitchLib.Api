using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Auth
{
    /// <summary>
    /// Validate Access Token
    /// </summary>
    public class ValidateAccessTokenResponse
    {
        /// <summary>
        /// Client Id
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; protected set; }

        /// <summary>
        /// Login Name
        /// </summary>
        [JsonPropertyName("login")]
        public string Login { get; protected set; }

        /// <summary>
        /// Scopes
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; protected set; }

        /// <summary>
        /// User Id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; protected set; }

        /// <summary>
        /// Expires In
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; protected set; }
    }
}
