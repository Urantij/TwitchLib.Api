using System;

namespace TwitchLib.Api.Core.Exceptions
{
    /// <inheritdoc />
    /// <summary>Exception representing a 500 Http Statuscode</summary>
    public class InternalServerErrorException : Exception
    {
        public readonly string response;

        /// <inheritdoc />
        /// <summary>Exception constructor</summary>
        public InternalServerErrorException(string data, string response)
            : base(data)
        {
            this.response = response;
        }
    }
}