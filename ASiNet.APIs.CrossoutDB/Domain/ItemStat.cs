using System.Text.Json.Serialization;

namespace ASiNet.APIs.CrossoutDB.Domain;
public class ItemStat
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    [JsonPropertyName("order")]
    public int Order { get; set; }
    [JsonPropertyName("type")]
    public int Type { get; set; }
    [JsonPropertyName("override")]
    public object? Override { get; set; }
    [JsonPropertyName("showProgressBar")]
    public bool ShowProgressBar { get; set; }
    [JsonPropertyName("showPercentage")]
    public bool ShowPercentage { get; set; }
    [JsonPropertyName("showAddition")]
    public bool ShowAddition { get; set; }
    [JsonPropertyName("showSubtraction")]
    public bool ShowSubtraction { get; set; }
    [JsonPropertyName("customClasses")]
    public string CustomClasses { get; set; } = null!;
}
