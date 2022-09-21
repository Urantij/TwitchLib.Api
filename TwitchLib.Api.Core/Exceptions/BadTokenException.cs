using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a token not correctly associated with the given user.</summary>
    public class BadTokenException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public BadTokenException(string data, string response)
            : base(data)
        {
            this.response = response;
        }
    }
}
