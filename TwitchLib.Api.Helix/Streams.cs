﻿using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TwitchLib.Api.Core;
using TwitchLib.Api.Core.Enums;
using TwitchLib.Api.Core.Exceptions;
using TwitchLib.Api.Core.Interfaces;
using TwitchLib.Api.Helix.Models.Streams.CreateStreamMarker;
using TwitchLib.Api.Helix.Models.Streams.GetFollowedStreams;
using TwitchLib.Api.Helix.Models.Streams.GetStreamKey;
using TwitchLib.Api.Helix.Models.Streams.GetStreamMarkers;
using TwitchLib.Api.Helix.Models.Streams.GetStreams;
using TwitchLib.Api.Helix.Models.Streams.GetStreamTags;

namespace TwitchLib.Api.Helix
{
    [JsonSerializable(typeof(GetStreamsResponse))]
    public partial class GetStreamsResponseContext : JsonSerializerContext
    {
            
    }

    /// <summary>
    /// Streams related APIs
    /// </summary>
    public class Streams : ApiBase
    {
        public Streams(IApiSettings settings, IRateLimiter rateLimiter, IHttpCallHandler http) : base(settings, rateLimiter, http)
        {
        }

        /// <summary>
        /// Gets information about active streams.
        /// <para>Streams are returned sorted by number of current viewers, in descending order.</para>
        /// <para>Across multiple pages of results, there may be duplicate or missing streams, as viewers join and leave streams.</para>
        /// </summary>
        /// <param name="after">Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response.</param>
        /// <param name="first">Maximum number of objects to return. Maximum: 100. Default: 20.</param>
        /// <param name="gameIds">Returns streams broadcasting a specified game ID. You can specify up to 100 IDs.</param>
        /// <param name="languages">
        /// Filter by Stream language.
        /// <para>You can specify up to 100 languages.</para>
        /// <para>A language value must be either the ISO 639-1 two-letter code for a supported stream language or “other”.</para>
        /// </param>
        /// <param name="userIds">Returns streams broadcast by one or more specified user IDs. You can specify up to 100 IDs.</param>
        /// <param name="userLogins">Returns streams broadcast by one or more specified user login names. You can specify up to 100 names.</param>
        /// <param name="accessToken">optional access token to override the use of the stored one in the TwitchAPI instance</param>
        /// <returns cref="GetStreamsResponse"></returns>
        public Task<GetStreamsResponse> GetStreamsAsync(string after = null, int first = 20, List<string> gameIds = null, List<string> languages = null, List<string> userIds = null, List<string> userLogins = null, string accessToken = null, string type = null)
        {
            var getParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("first", first.ToString()),
            };

            if (!string.IsNullOrWhiteSpace(after))
                getParams.Add(new KeyValuePair<string, string>("after", after));

            if (gameIds != null && gameIds.Count > 0)
            {
                getParams.AddRange(gameIds.Select(gameId => new KeyValuePair<string, string>("game_id", gameId)));
            }

            if (languages != null && languages.Count > 0)
            {
                getParams.AddRange(languages.Select(language => new KeyValuePair<string, string>("language", language)));
            }

            if (userIds != null && userIds.Count > 0)
            {
                getParams.AddRange(userIds.Select(userId => new KeyValuePair<string, string>("user_id", userId)));
            }

            if (userLogins != null && userLogins.Count > 0)
            {
                getParams.AddRange(userLogins.Select(userLogin => new KeyValuePair<string, string>("user_login", userLogin)));
            }

            if (type != null && (type == GetStreamsType.All || type == GetStreamsType.Live))
            {
                getParams.Add(new KeyValuePair<string, string>("type", type));
            }

            return TwitchGetGenericAsync<GetStreamsResponse>("/streams", ApiVersion.Helix, getParams, accessToken, serializerContext: GetStreamsResponseContext.Default);
        }

        /// <summary>
        /// Gets the list of stream tags that are set on the specified channel.
        /// </summary>
        /// <param name="broadcasterId">The user ID of the channel to get the tags from.</param>
        /// <param name="accessToken">optional access token to override the use of the stored one in the TwitchAPI instance</param>
        /// <returns cref="GetStreamTagsResponse"></returns>
        /// <exception cref="BadParameterException"></exception>
        public Task<GetStreamTagsResponse> GetStreamTagsAsync(string broadcasterId, string accessToken = null)
        {
            if (string.IsNullOrWhiteSpace(broadcasterId))
            {
                throw new BadParameterException("BroadcasterId must be set");
            }

            var getParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("broadcaster_id", broadcasterId)
            };

            return TwitchGetGenericAsync<GetStreamTagsResponse>("/streams/tags", ApiVersion.Helix, getParams, accessToken);
        }

        /// <summary>
        /// Gets the channel stream key for a user.
        /// <para>Required scope: channel:read:stream_key</para>
        /// </summary>
        /// <param name="broadcasterId">User ID of the broadcaster</param>
        /// <param name="accessToken">optional access token to override the use of the stored one in the TwitchAPI instance</param>
        /// <returns cref="GetStreamKeyResponse"></returns>
        public Task<GetStreamKeyResponse> GetStreamKeyAsync(string broadcasterId, string accessToken = null)
        {
            var getParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("broadcaster_id", broadcasterId)
            };

            return TwitchGetGenericAsync<GetStreamKeyResponse>("/streams/key", ApiVersion.Helix, getParams, accessToken);
        }

        /// <summary>
        /// Creates a marker in the stream of a user specified by user ID
        /// <para>A marker is an arbitrary point in a stream that the broadcaster wants to mark; e.g., to easily return to later. </para>
        /// <para>Markers can be created by the stream owner or editors. </para>
        /// Required scope: channel:manage:broadcast
        /// </summary>
        /// <param name="request" cref="CreateStreamMarkerRequest"></param>
        /// <param name="accessToken">optional access token to override the use of the stored one in the TwitchAPI instance</param>
        /// <returns cref="CreateStreamMarkerResponse"></returns>
        public Task<CreateStreamMarkerResponse> CreateStreamMarkerAsync(CreateStreamMarkerRequest request, string accessToken = null)
        {
            return TwitchPostGenericAsync<CreateStreamMarkerResponse>("/streams/markers", ApiVersion.Helix, JsonSerializer.Serialize(request), null, accessToken);
        }

        /// <summary>
        /// Gets a list of markers for either a specified user’s most recent stream or a specified VOD/video (stream), ordered by recency.
        /// <para>A marker is an arbitrary point in a stream that the broadcaster wants to mark; e.g., to easily return to later.</para>
        /// <para>The only markers returned are those created by the user identified by the Bearer token.</para>
        /// <para>Only one of userId and videoId must be specified.</para>
        /// <para>Required scope: user:read:broadcast</para>
        /// </summary>
        /// <param name="userId">
        /// ID of the broadcaster from whose stream markers are returned.
        /// <para>Only one of userId and videoId must be specified.</para>
        /// </param>
        /// <param name="videoId">
        /// ID of the VOD/video whose stream markers are returned.
        /// <para>Only one of userId and videoId must be specified.</para>
        /// </param>
        /// <param name="first">Number of values to be returned when getting videos by user or game ID. Limit: 100. Default: 20.</param>
        /// <param name="after">Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response.</param>
        /// <param name="accessToken">optional access token to override the use of the stored one in the TwitchAPI instance</param>
        /// <returns cref="GetStreamMarkersResponse"></returns>
        /// <exception cref="BadParameterException"></exception>
        public Task<GetStreamMarkersResponse> GetStreamMarkersAsync(string userId = null, string videoId = null, int first = 20, string after = null, string accessToken = null)
        {
            if (string.IsNullOrWhiteSpace(userId) && string.IsNullOrWhiteSpace(videoId))
                throw new BadParameterException("One of userId and videoId has to be specified");

            if (!string.IsNullOrWhiteSpace(userId) && !string.IsNullOrWhiteSpace(videoId))
                throw new BadParameterException("userId and videoId are mutually exclusive");

            if (first < 1 || first > 100)
                throw new BadParameterException("first cannot be less than 1 or greater than 100");

            var getParams = new List<KeyValuePair<string, string>>();

            if (!string.IsNullOrWhiteSpace(userId))
                getParams.Add(new KeyValuePair<string, string>("user_id", userId));

            if (!string.IsNullOrWhiteSpace(videoId))
                getParams.Add(new KeyValuePair<string, string>("video_id", videoId));

            getParams.Add(new KeyValuePair<string, string>("first", first.ToString()));

            if (!string.IsNullOrWhiteSpace(after))
                getParams.Add(new KeyValuePair<string, string>("after", after));

            return TwitchGetGenericAsync<GetStreamMarkersResponse>("/streams/markers", ApiVersion.Helix, getParams, accessToken);
        }

        /// <summary>
        /// Gets information about active streams belonging to channels that the authenticated user follows.
        /// <para>Streams are returned sorted by number of current viewers, in descending order.</para>
        /// <para>Across multiple pages of results, there may be duplicate or missing streams, as viewers join and leave streams.</para>
        /// <para>userId must match the User ID in the bearer token.</para>
        /// <para>Required scope: user:read:follows</para>
        /// </summary>
        /// <param name="userId">Results will only include active streams from the channels that this Twitch user follows.</param>
        /// <param name="first">Maximum number of objects to return. Maximum: 100. Default: 100.</param>
        /// <param name="after">Cursor for forward pagination: tells the server where to start fetching the next set of results, in a multi-page response.</param>
        /// <param name="accessToken">optional access token to override the use of the stored one in the TwitchAPI instance</param>
        /// <returns cref="GetFollowedStreamsResponse"></returns>
        /// <exception cref="BadParameterException"></exception>
        public Task<GetFollowedStreamsResponse> GetFollowedStreamsAsync(string userId, int first = 100, string after = null, string accessToken = null)
        {
            if (first < 1 || first > 100)
                throw new BadParameterException("first cannot be less than 1 or greater than 100");

            var getParams = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("user_id", userId),
                new KeyValuePair<string, string>("first", first.ToString())
            };

            if (!string.IsNullOrWhiteSpace(after))
                getParams.Add(new KeyValuePair<string, string>("after", after));

            return TwitchGetGenericAsync<GetFollowedStreamsResponse>("/streams/followed", ApiVersion.Helix, getParams, accessToken);
        }
    }

}
