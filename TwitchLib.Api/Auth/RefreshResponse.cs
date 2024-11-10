using System.Text.Json.Serialization;

namespace TwitchLib.Api.Auth
{
    /// <summary>
    /// Refresh Response
    /// </summary>
    public class RefreshResponse
    {
        /// <summary>
        /// Access Token
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; protected set; }

        /// <summary>
        /// Refresh Token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; protected set; }
        
        /// <summary>
        /// Expires In
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; protected set; }

        /// <summary>
        /// Scopes
        /// </summary>
        [JsonPropertyName("scope")]
        public string[] Scopes { get; protected set; }
    }
}
