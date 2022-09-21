using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a 504 Http Statuscode</summary>
    public class GatewayTimeoutException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public GatewayTimeoutException(string data, string response)
            : base(data)
        {
            this.response = response;
        }
    }
}