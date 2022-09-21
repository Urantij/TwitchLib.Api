using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a provided scope was not permitted.</summary>
    public class BadScopeException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public BadScopeException(string data, string response)
            : base(data)
        {
            this.response = response;
        }
    }
}