using System.Text.Json.Serialization;

namespace TwitchLib.Api.Helix.Models.Bits.ExtensionBitsProducts;

/// <summary>
/// Adds or updates a Bits product that the extension created response object.
/// </summary>
public class UpdateExtensionBitsProductResponse
{
    /// <summary>
    /// A list of Bits products that the extension created. The list is in ascending SKU order.
    /// </summary>
    [JsonPropertyName("data")]
    public ExtensionBitsProduct[] Data { get; protected set; }
}
