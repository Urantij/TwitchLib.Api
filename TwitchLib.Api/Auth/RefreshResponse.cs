using System.Text.Json.Serialization;

namespace TwitchLib.Api.Auth
{
    /// <summary>
    /// Refresh Response
    /// </summary>
    public class RefreshResponse
    {
        public RefreshResponse(string accessToken = null, string refreshToken = null, int expiresIn = default, string[] scopes = null)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            ExpiresIn = expiresIn;
            Scopes = scopes;
        }

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
