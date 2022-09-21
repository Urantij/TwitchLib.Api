using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing an invalid resource</summary>
    public class BadResourceException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public BadResourceException(string apiData, string response)
            : base(apiData)
        {
            this.response = response;
        }
    }
}