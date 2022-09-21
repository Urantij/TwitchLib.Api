using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a request that doesn't have a clientid attached.</summary>
    public class BadRequestException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public BadRequestException(string apiData, string response)
            : base(apiData)
        {
            this.response = response;
        }
    }
}
