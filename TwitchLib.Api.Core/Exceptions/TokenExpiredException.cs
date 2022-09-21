using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a detection that the OAuth token expired</summary>
    public class TokenExpiredException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public TokenExpiredException(string data, string response)
            : base(data)
        {
            this.response = response;
        }
    }
}