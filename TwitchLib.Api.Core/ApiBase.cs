﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using TwitchLib.Api.Core.Enums;
using TwitchLib.Api.Core.Exceptions;
using TwitchLib.Api.Core.Interfaces;
using TwitchLib.Api.Core.Models;

namespace TwitchLib.Api.Core
{
    public class ApiBase
    {
        private readonly TwitchLibJsonSerializer _jsonSerializer;
        protected readonly IApiSettings Settings;
        private readonly IRateLimiter _rateLimiter;
        private readonly IHttpCallHandler _http;

        internal const string BaseHelix = "https://api.twitch.tv/helix";
        internal const string BaseAuth = "https://id.twitch.tv/oauth2";

        private DateTime? _serverBasedAccessTokenExpiry;
        private string _serverBasedAccessToken;

        public ApiBase(IApiSettings settings, IRateLimiter rateLimiter, IHttpCallHandler http)
        {
            Settings = settings; 
            _rateLimiter = rateLimiter;
            _http = http;
            _jsonSerializer = new TwitchLibJsonSerializer();
        }

        public async ValueTask<string> GetAccessTokenAsync(string accessToken = null)
        {
            if (!string.IsNullOrWhiteSpace(accessToken))
                return accessToken;
            if (!string.IsNullOrWhiteSpace(Settings.AccessToken))
                return Settings.AccessToken;
            if (!string.IsNullOrWhiteSpace(Settings.Secret) && !string.IsNullOrWhiteSpace(Settings.ClientId) && !Settings.SkipAutoServerTokenGeneration)
            {
                if (_serverBasedAccessTokenExpiry == null || _serverBasedAccessTokenExpiry - TimeSpan.FromMinutes(1) < DateTime.Now)
                    return await GenerateServerBasedAccessToken().ConfigureAwait(false);

                return _serverBasedAccessToken;
            }

            return null;
        }

        internal async Task<string> GenerateServerBasedAccessToken()
        {
            var result = await _http.GeneralRequestAsync($"{BaseAuth}/token?client_id={Settings.ClientId}&client_secret={Settings.Secret}&grant_type=client_credentials", "POST", null, ApiVersion.Auth, Settings.ClientId, null).ConfigureAwait(false);
            if (result.Key == 200)
            {
                var data = JsonNode.Parse(result.Value);
                var offset = int.Parse(data?["expires_in"]?.ToString() ?? string.Empty);
                _serverBasedAccessTokenExpiry = DateTime.Now + TimeSpan.FromSeconds(offset);
                _serverBasedAccessToken = data?["access_token"]?.ToString();
                return _serverBasedAccessToken;
            }
            return null;
        }

        internal void ForceAccessTokenAndClientIdForHelix(string clientId, string accessToken, ApiVersion api)
        {
            if (api != ApiVersion.Helix)
                return;
            if (!string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(accessToken))
                return;
            throw new ClientIdAndOAuthTokenRequired("As of May 1, all calls to Twitch's Helix API require Client-ID and OAuth access token be set. Example: api.Settings.AccessToken = \"twitch-oauth-access-token-here\"; api.Settings.ClientId = \"twitch-client-id-here\";");
        }

        protected async Task<string> TwitchGetAsync(string resource, ApiVersion api, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => (await _http.GeneralRequestAsync(url, "GET", null, api, clientId, accessToken).ConfigureAwait(false)).Value).ConfigureAwait(false);
        }

        protected async Task<T> TwitchGetGenericAsync<T>(string resource, ApiVersion api, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null, JsonSerializerContext serializerContext = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            JsonSerializerOptions options = GenerateOptions(serializerContext);

            return await _rateLimiter.Perform(async () =>
            {
                string content = (await _http.GeneralRequestAsync(url, "GET", null, api, clientId, accessToken)
                    .ConfigureAwait(false)).Value;

                return JsonSerializer.Deserialize<T>(content, options);
            }).ConfigureAwait(false);
        }

        protected async Task<T> TwitchPatchGenericAsync<T>(string resource, ApiVersion api, string payload, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>((await _http.GeneralRequestAsync(url, "PATCH", payload, api, clientId, accessToken).ConfigureAwait(false)).Value, _twitchLibJsonDeserializer)).ConfigureAwait(false);
        }

        protected async Task<KeyValuePair<int, string>> TwitchPatchAsync(string resource, ApiVersion api, string payload, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => (await _http.GeneralRequestAsync(url, "PATCH", payload, api, clientId, accessToken).ConfigureAwait(false))).ConfigureAwait(false);
        }

        protected async Task<KeyValuePair<int, string>> TwitchDeleteAsync(string resource, ApiVersion api, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => (await _http.GeneralRequestAsync(url, "DELETE", null, api, clientId, accessToken).ConfigureAwait(false))).ConfigureAwait(false);
        }

        protected async Task<T> TwitchPostGenericAsync<T>(string resource, ApiVersion api, string payload, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>((await _http.GeneralRequestAsync(url, "POST", payload, api, clientId, accessToken).ConfigureAwait(false)).Value, _twitchLibJsonDeserializer)).ConfigureAwait(false);
        }

        protected async Task<T> TwitchPostGenericModelAsync<T>(string resource, ApiVersion api, RequestModel model, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, api: api, overrideUrl: customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>((await _http.GeneralRequestAsync(url, "POST", model != null ? _jsonSerializer.SerializeObject(model) : "", api, clientId, accessToken).ConfigureAwait(false)).Value, _twitchLibJsonDeserializer)).ConfigureAwait(false);
        }

        protected async Task<T> TwitchDeleteGenericAsync<T>(string resource, ApiVersion api, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>((await _http.GeneralRequestAsync(url, "DELETE", null, api, clientId, accessToken).ConfigureAwait(false)).Value, _twitchLibJsonDeserializer)).ConfigureAwait(false);
        }

        protected async Task<T> TwitchPutGenericAsync<T>(string resource, ApiVersion api, string payload = null, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>((await _http.GeneralRequestAsync(url, "PUT", payload, api, clientId, accessToken).ConfigureAwait(false)).Value, _twitchLibJsonDeserializer)).ConfigureAwait(false);
        }

        protected async Task<string> TwitchPutAsync(string resource, ApiVersion api, string payload, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => (await _http.GeneralRequestAsync(url, "PUT", payload, api, clientId, accessToken).ConfigureAwait(false)).Value).ConfigureAwait(false);
        }

        protected async Task<KeyValuePair<int, string>> TwitchPostAsync(string resource, ApiVersion api, string payload, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, string clientId = null, string customBase = null)
        {
            var url = ConstructResourceUrl(resource, getParams, api, customBase);

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => await _http.GeneralRequestAsync(url, "POST", payload, api, clientId, accessToken).ConfigureAwait(false)).ConfigureAwait(false);
        }


        protected Task PutBytesAsync(string url, byte[] payload)
        {
            return _http.PutBytesAsync(url, payload);
        }

        internal Task<int> RequestReturnResponseCode(string url, string method, List<KeyValuePair<string, string>> getParams = null)
        {
            return _http.RequestReturnResponseCodeAsync(url, method, getParams);
        }

        protected async Task<T> GetGenericAsync<T>(string url, List<KeyValuePair<string, string>> getParams = null, string accessToken = null, ApiVersion api = ApiVersion.Helix, string clientId = null)
        {
            if (getParams != null)
            {
                for (var i = 0; i < getParams.Count; i++)
                {
                    if (i == 0)
                        url += $"?{getParams[i].Key}={Uri.EscapeDataString(getParams[i].Value)}";
                    else
                        url += $"&{getParams[i].Key}={Uri.EscapeDataString(getParams[i].Value)}";
                }
            }

            if (string.IsNullOrWhiteSpace(clientId) && !string.IsNullOrWhiteSpace(Settings.ClientId))
                clientId = Settings.ClientId;

            accessToken = await GetAccessTokenAsync(accessToken).ConfigureAwait(false);
            ForceAccessTokenAndClientIdForHelix(clientId, accessToken, api);

            return await _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>((await _http.GeneralRequestAsync(url, "GET", null, api, clientId, accessToken).ConfigureAwait(false)).Value, _twitchLibJsonDeserializer)).ConfigureAwait(false);
        }

        internal Task<T> GetSimpleGenericAsync<T>(string url, List<KeyValuePair<string, string>> getParams = null)
        {
            if (getParams != null)
            {
                for (var i = 0; i < getParams.Count; i++)
                {
                    if (i == 0)
                        url += $"?{getParams[i].Key}={Uri.EscapeDataString(getParams[i].Value)}";
                    else
                        url += $"&{getParams[i].Key}={Uri.EscapeDataString(getParams[i].Value)}";
                }
            }
            return _rateLimiter.Perform(async () => JsonSerializer.Deserialize<T>(await SimpleRequestAsync(url).ConfigureAwait(false), _twitchLibJsonDeserializer));
        }

        // credit: https://stackoverflow.com/questions/14290988/populate-and-return-entities-from-downloadstringcompleted-handler-in-windows-pho
        private Task<string> SimpleRequestAsync(string url)
        {
            var tcs = new TaskCompletionSource<string>();
            var client = new WebClient();

            client.DownloadStringCompleted += DownloadStringCompletedEventHandler;
            client.DownloadString(new Uri(url));

            return tcs.Task;

            // local function
            void DownloadStringCompletedEventHandler(object sender, DownloadStringCompletedEventArgs args)
            {
                if (args.Cancelled)
                    tcs.SetCanceled();
                else if (args.Error != null)
                    tcs.SetException(args.Error);
                else
                    tcs.SetResult(args.Result);

                client.DownloadStringCompleted -= DownloadStringCompletedEventHandler;
            }
        }

        protected JsonSerializerOptions GenerateOptions(JsonSerializerContext context)
        {
            return new JsonSerializerOptions()
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = context
            };
        }

        private readonly JsonSerializerOptions _twitchLibJsonDeserializer = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            // NullValueHandling = NullValueHandling.Ignore, 
            // MissingMemberHandling = MissingMemberHandling.Ignore
        };

        private class TwitchLibJsonSerializer
        {
            private readonly LowercaseNamingPolicy _namingPolicy = new();

            public string SerializeObject(object o)
            {
                JsonSerializerOptions options = new()
                {
                    PropertyNamingPolicy = _namingPolicy,
                    WriteIndented = true,
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
                    // TypeInfoResolver = context,
                    // NullValueHandling = NullValueHandling.Ignore
                };
                
                return JsonSerializer.Serialize(o, o.GetType(), options);
            }
            
            private class LowercaseNamingPolicy : JsonNamingPolicy
            {
                public override string ConvertName(string name)
                {
                    return name.ToLower();
                }
            }
        }

        private string ConstructResourceUrl(string resource = null, List<KeyValuePair<string, string>> getParams = null, ApiVersion api = ApiVersion.Helix, string overrideUrl = null)
        {
            var url = "";
            if (overrideUrl == null)
            {
                if (resource == null)
                    throw new Exception("Cannot pass null resource with null override url");
                switch (api)
                {
                    case ApiVersion.Helix:
                        url = $"{BaseHelix}{resource}";
                        break;
                    case ApiVersion.Auth:
                        url = $"{BaseAuth}{resource}";
                        break;
                }
            }
            else
            {
                url = resource == null ? overrideUrl : $"{overrideUrl}{resource}";
            }
            if (getParams != null)
            {
                for (var i = 0; i < getParams.Count; i++)
                {
                    if (i == 0)
                        url += $"?{getParams[i].Key}={Uri.EscapeDataString(getParams[i].Value)}";
                    else
                        url += $"&{getParams[i].Key}={Uri.EscapeDataString(getParams[i].Value)}";
                }
            }
            return url;
        }
    }
}
