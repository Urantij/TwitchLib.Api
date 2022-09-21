using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a 502 Http Statuscode</summary>
    public class BadGatewayException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public BadGatewayException(string data, string response)
            : base(data)
        {
            this.response = response;
        }
    }
}