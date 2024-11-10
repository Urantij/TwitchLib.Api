﻿using System;
using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Polls;

/// <summary>
/// Contains a single poll.
/// </summary>
public class Poll
{
    /// <summary>
    /// An ID that identifies the poll.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// An ID that identifies the broadcaster that created the poll.
    /// </summary>
    [JsonPropertyName("broadcaster_id")]
    public string BroadcasterId { get; protected set; }

    /// <summary>
    /// The broadcaster’s display name.
    /// </summary>
    [JsonPropertyName("broadcaster_name")]
    public string BroadcasterName { get; protected set; }

    /// <summary>
    /// The broadcaster’s login name.
    /// </summary>
    [JsonPropertyName("broadcaster_login")]
    public string BroadcasterLogin { get; protected set; }

    /// <summary>
    /// The question that viewers are voting on. Maximum of 60 characters.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; protected set; }

    /// <summary>
    /// A list of choices that viewers can choose from. 
    /// The list will contain a minimum of two choices and up to a maximum of five choices.
    /// </summary>
    [JsonPropertyName("choices")]
    public Choice[] Choices { get; protected set; }

    /// <summary>
    /// Not used; will be set to false.
    /// </summary>
    [JsonPropertyName("bits_voting_enabled")]
    public bool BitsVotingEnabled { get; protected set; }

    /// <summary>
    /// Not used; will be set to 0.
    /// </summary>
    [JsonPropertyName("bits_per_vote")]
    public int BitsPerVote { get; protected set; }

    /// <summary>
    /// A Boolean value that indicates whether viewers may cast additional votes using Channel Points. 
    /// </summary>
    [JsonPropertyName("channel_points_voting_enabled")]
    public bool ChannelPointsVotingEnabled { get; protected set; }

    /// <summary>
    /// The number of points the viewer must spend to cast one additional vote.
    /// </summary>
    [JsonPropertyName("channel_points_per_vote")]
    public int ChannelPointsPerVote { get; protected set; }

    /// <summary>
    /// The poll’s status.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; protected set; }

    /// <summary>
    /// The length of time (in seconds) that the poll will run for.
    /// </summary>
    [JsonPropertyName("duration")]
    public int DurationSeconds { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the poll began.
    /// </summary>
    [JsonPropertyName("started_at")]
    public DateTime StartedAt { get; protected set; }

    /// <summary>
    /// The UTC date and time (in RFC3339 format) of when the poll ended. If status is ACTIVE, this field is set to null.
    /// </summary>
    [JsonPropertyName("ended_at")]
    public DateTime EndedAt { get; protected set; }
}
