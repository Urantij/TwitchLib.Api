using System;
using System.Collections.Generic;
using System.Text.Json.Nodes;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.ThirdParty.AuthorizationFlow
{
    public class PingResponse
    {
        public bool Success { get; protected set; }
        public string Id { get; protected set; }

        public int Error { get; protected set; }
        public string Message { get; protected set; }

        public List<AuthScopes> Scopes { get; protected set; }
        public string Token { get; protected set; }
        public string Refresh { get; protected set; }
        public string Username { get; protected set; }
        public string ClientId { get; protected set; }

        public PingResponse(string jsonStr)
        {
            var json = JsonNode.Parse(jsonStr);
            if (json == null)
                throw new Exception($"{nameof(PingResponse)} unable to parse json");
            
            Success = bool.Parse(json["success"].ToString());
            if(!Success)
            {
                Error = int.Parse(json["error"].ToString());
                Message = json["message"].ToString();
            } else
            {
                Scopes = new List<AuthScopes>();
                foreach (var scope in json["scopes"].AsArray())
                    Scopes.Add(Core.Common.Helpers.StringToScope(scope.ToString()));
                Token = json["token"].ToString();
                Refresh = json["refresh"].ToString();
                Username = json["username"].ToString();
                ClientId = json["client_id"].ToString();
            }
        }
    }
}
