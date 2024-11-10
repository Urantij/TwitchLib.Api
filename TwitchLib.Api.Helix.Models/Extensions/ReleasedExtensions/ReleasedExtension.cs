using System.Text.Json.Serialization;
using TwitchLib.Api.Core.Enums;

namespace TwitchLib.Api.Helix.Models.Extensions.ReleasedExtensions;

/// <summary>
/// A specified extension.
/// </summary>
public class ReleasedExtension
{
    /// <summary>
    /// The name of the user or organization that owns the extension.
    /// </summary>
    [JsonPropertyName("author_name")]
    public string AuthorName { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the extension has features that use Bits. 
    /// </summary>
    [JsonPropertyName("bits_enabled")]
    public bool BitsEnabled { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether a user can install the extension on their channel.
    /// </summary>
    [JsonPropertyName("can_install")]
    public bool CanInstall { get; protected set; }

    /// <summary>
    /// The location of where the extension’s configuration is stored.
    /// </summary>
    [JsonPropertyName("configuration_location")]
    public string ConfigurationLocation { get; protected set; }

    /// <summary>
    /// A longer description of the extension. It appears on the details page.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; protected set; }

    /// <summary>
    /// A URL to the extension’s Terms of Service.
    /// </summary>
    [JsonPropertyName("eula_tos_url")]
    public string EulaTosUrl { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the extension can communicate with the installed channel’s chat.
    /// </summary>
    [JsonPropertyName("has_chat_support")]
    public bool HasChatSupport { get; protected set; }

    /// <summary>
    /// A URL to the default icon that’s displayed in the Extensions directory.
    /// </summary>
    [JsonPropertyName("icon_url")]
    public string IconUrl { get; protected set; }

    /// <summary>
    /// A list that contains URLs to different sizes of the default icon.
    /// </summary>
    [JsonPropertyName("icon_urls")]
    public IconUrls IconUrls { get; protected set; }

    /// <summary>
    /// The extension’s ID.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; protected set; }

    /// <summary>
    /// The extension’s name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; protected set; }

    /// <summary>
    /// A URL to the extension’s privacy policy.
    /// </summary>
    [JsonPropertyName("privacy_policy_url")]
    public string PrivacyPolicyUrl { get; protected set; }

    /// <summary>
    /// A Boolean value that determines whether the extension wants to explicitly ask viewers to link their Twitch identity.
    /// </summary>
    [JsonPropertyName("request_identity_link")]
    public bool RequestIdentityLink { get; protected set; }

    /// <summary>
    /// A list of URLs to screenshots that are shown in the Extensions marketplace.
    /// </summary>
    [JsonPropertyName("screenshot_urls")]
    public string[] ScreenshotUrls { get; protected set; }

    /// <summary>
    /// The extension’s state. 
    /// </summary>
    [JsonPropertyName("state")]
    public ExtensionState State { get; protected set; }

    /// <summary>
    /// Indicates whether the extension can view the user’s subscription level on the channel that the extension is installed on. 
    /// </summary>
    [JsonPropertyName("subscriptions_support_level")]
    public string SubscriptionsSupportLevel { get; protected set; }

    /// <summary>
    /// A short description of the extension that streamers see when hovering over the discovery splash screen in the Extensions manager.
    /// </summary>
    [JsonPropertyName("summary")]
    public string Summary { get; protected set; }

    /// <summary>
    /// The email address that users use to get support for the extension.
    /// </summary>
    [JsonPropertyName("support_email")]
    public string SupportEmail { get; protected set; }

    /// <summary>
    /// The extension’s version number.
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; protected set; }

    /// <summary>
    /// A brief description displayed on the channel to explain how the extension works.
    /// </summary>
    [JsonPropertyName("viewer_summary")]
    public string ViewerSummary { get; protected set; }

    /// <summary>
    /// Describes all views-related information such as how the extension is displayed on mobile devices.
    /// </summary>
    [JsonPropertyName("views")]
    public Views Views { get; protected set; }

    /// <summary>
    /// Allowlisted configuration URLs for displaying the extension.
    /// </summary>
    [JsonPropertyName("allowlisted_config_urls")]
    public string[] AllowlistedConfigUrls { get; protected set; }

    /// <summary>
    /// Allowlisted panel URLs for displaying the extension.
    /// </summary>
    [JsonPropertyName("allowlisted_panel_urls")]
    public string[] AllowlistedPanelUrls { get; protected set; }
}
