using System.Text.Json.Serialization;

namespace ASiNet.APIs.CrossoutDB.Domain;
public class Languages
{
    [JsonPropertyName("availableLanguages")]
    public Language[] Available { get; set; } = null!;

    [JsonPropertyName("defaultLanguages")]
    public Language Default { get; set; } = null!;
}
