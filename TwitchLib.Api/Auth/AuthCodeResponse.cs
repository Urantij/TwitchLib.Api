using System.Text.Json.Serialization;

namespace TwitchLib.Api.Auth
{
    /// <summary>
    /// Auth Code Response
    /// </summary>
    public class AuthCodeResponse
    {
        public AuthCodeResponse(string accessToken = null, string refreshToken = null, int expiresIn = default, string[] scopes = null, string tokenType = null)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            ExpiresIn = expiresIn;
            Scopes = scopes;
            TokenType = tokenType;
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

        /// <summary>
        /// Token Type
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }
    }
}