using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Charity.GetCharityCampaignDonations;

/// <summary>
/// <para>Donations that users have made to the broadcaster's active charity campaign.</para>
/// </summary>
public class CharityCampaignDonationsResponseModel
{
  /// <summary>
  /// <para>An ID that identifies the donation. The ID is unique across campaigns.</para>
  /// </summary>
  [JsonPropertyName("id")]
  public string Id { get; protected set; }

  /// <summary>
  /// <para>An ID that identifies the charity campaign that the donation applies to.</para>
  /// </summary>
  [JsonPropertyName("campaign_id")]
  public string CampaignId { get; protected set; }

  /// <summary>
  /// <para>An ID that identifies a user that donated money to the campaign.</para>
  /// </summary>
  [JsonPropertyName("user_id")]
  public string UserId { get; protected set; }

  /// <summary>
  /// <para>The user’s login name. (Name is lowercase)</para>
  /// </summary>
  [JsonPropertyName("user_login")]
  public string UserLogin { get; protected set; }

  /// <summary>
  /// <para>The user’s display name. (Name has capitalization)</para>
  /// </summary>
  [JsonPropertyName("user_name")]
  public string UserName { get; protected set; }

  /// <summary>
  /// <para>An object that contains the amount of money that the user donated.</para>
  /// </summary>
  [JsonPropertyName("amount")]
  public Amount Amount { get; protected set; }
}
