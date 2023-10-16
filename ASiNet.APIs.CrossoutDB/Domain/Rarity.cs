using System.Text.Json.Serialization;

namespace ASiNet.APIs.CrossoutDB.Domain;
public class Rarity
{
    [JsonPropertyName("order")]
    public int Order { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    [JsonPropertyName("primarycolor")]
    public string PrimaryColor { get; set; } = null!;
    [JsonPropertyName("secondarycolor")]
    public string SecondaryColor { get; set; } = null!;
}
