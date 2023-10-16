using System.Text.Json.Serialization;

namespace ASiNet.APIs.CrossoutDB.Domain;
public class ItemType
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}
