using System.Text.Json.Serialization;

namespace ASiNet.APIs.CrossoutDB.Domain;
public class ItemStatContainer
{
    [JsonPropertyName("key")]
    public string Key { get; set; } = null!;
    [JsonPropertyName("value")]
    public object? Value { get; set; }
    [JsonPropertyName("displayValue")]
    public bool DisplayValue { get; set; }
    [JsonPropertyName("stat")]
    public ItemStat Stat { get; set; } = null!;
}
