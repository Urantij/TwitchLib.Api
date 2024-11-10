﻿using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Moderation.AutomodSettings;

/// <summary>
/// Automod Settings Request object.
/// </summary>
public class AutomodSettings
{
    /// <summary>
    /// The default AutoMod level for the broadcaster.
    /// </summary>
    [JsonPropertyName("overall_level")]
    public int? OverallLevel;

    /// <summary>
    /// The Automod level for discrimination against disability.
    /// </summary>
    [JsonPropertyName("disability")]
    public int? Disability;

    /// <summary>
    /// The Automod level for hostility involving aggression.
    /// </summary>
    [JsonPropertyName("aggression")]
    public int? Aggression;

    /// <summary>
    /// The AutoMod level for discrimination based on sexuality, sex, or gender.
    /// </summary>
    [JsonPropertyName("sexuality_sex_or_gender")]
    public int? SexualitySexOrGender;

    /// <summary>
    /// The Automod level for discrimination against women.
    /// </summary>
    [JsonPropertyName("misogyny")]
    public int? Misogyny;

    /// <summary>
    /// The Automod level for hostility involving name calling or insults.
    /// </summary>
    [JsonPropertyName("bullying")]
    public int? Bullying;

    /// <summary>
    /// The Automod level for profanity.
    /// </summary>
    [JsonPropertyName("swearing")]
    public int? Swearing;

    /// <summary>
    /// The Automod level for racial discrimination.
    /// </summary>
    [JsonPropertyName("race_ethnicity_or_religion")]
    public int? RaceEthnicityOrReligion;

    /// <summary>
    /// The Automod level for sexual content.
    /// </summary>
    [JsonPropertyName("sex_based_terms")]
    public int? SexBasedTerms;
}
