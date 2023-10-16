using System.Text.Json.Serialization;

namespace ASiNet.APIs.CrossoutDB.Domain;
public class Item
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
    [JsonPropertyName("localizedName")]
    public string? LocalizedName { get; set; }
    [JsonPropertyName("availableName")]
    public string? AvailableName { get; set; }
    [JsonPropertyName("description")]
    public string? Description { get; set; }
    [JsonPropertyName("sellOffers")]
    public int SellOffers { get; set; }
    [JsonPropertyName("sellPrice")]
    public double SellPrice { get; set; }
    [JsonPropertyName("buyOrders")]
    public int BuyOrders { get; set; }
    [JsonPropertyName("buyPrice")]
    public double BuyPrice { get; set; }
    [JsonPropertyName("meta")]
    public int Meta { get; set; }
    [JsonPropertyName("removed")]
    public int Removed { get; set; }
    [JsonPropertyName("craftable")]
    public int Craftable { get; set; }
    [JsonPropertyName("popularity")]
    public int Popularity { get; set; }
    [JsonPropertyName("workbenchRarity")]
    public int WorkbenchRarity { get; set; }
    [JsonPropertyName("craftingSellSum")]
    public double CraftingSellSum { get; set; }
    [JsonPropertyName("craftingBuySum")]
    public double CraftingBuySum { get; set; }
    [JsonPropertyName("amount")]
    public int Amount { get; set; }
    [JsonPropertyName("rarityId")]
    public int RarityId { get; set; }
    [JsonPropertyName("rarityName")]
    public string RarityName { get; set; } = null!;
    [JsonPropertyName("categoryId")]
    public int CategoryId { get; set; }
    [JsonPropertyName("categoryName")]
    public string CategoryName { get; set; } = null!;
    [JsonPropertyName("typeId")]
    public int TypeId { get; set; }
    [JsonPropertyName("typeName")]
    public string TypeName { get; set; } = null!;
    [JsonPropertyName("recipeId")]
    public int RecipeId { get; set; }
    [JsonPropertyName("factionNumber")]
    public int FactionId { get; set; }
    [JsonPropertyName("faction")]
    public string FactionName { get; set; } = null!;
    [JsonPropertyName("demandSupplyRatio")]
    public double DemandSupplyRatio { get; set; }
    [JsonPropertyName("margin")]
    public double Margin { get; set; }
    [JsonPropertyName("roi")]
    public double Roi { get; set; }
    [JsonPropertyName("craftingMargin")]
    public double CraftingMargin { get; set; }
    [JsonPropertyName("craftVsBuy")]
    public string CraftVsBuy { get; set; } = null!;
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; } = null!;
    [JsonPropertyName("lastUpdateTime")]
    public string UpdateTime { get; set; } = null!;
    [JsonPropertyName("formatDemandSupplyRatio")]
    public string FormatDemandSupplyRatio { get; set; } = null!;
    [JsonPropertyName("formatMargin")]
    public string FormatMargin { get; set; } = null!;
    [JsonPropertyName("formatRoi")]
    public string FormatRoi { get; set; } = null!;
    [JsonPropertyName("formatCraftingMargin")]
    public string FormatCraftingMargin { get; set; } = null!;
    [JsonPropertyName("formatBuyPrice")]
    public string FormatBuyPrice { get; set; } = null!;
    [JsonPropertyName("formatSellPrice")]
    public string FormatSellPrice { get; set; } = null!;
    [JsonPropertyName("formatCraftingSellSum")]
    public string FormatCraftingSellSum { get; set; } = null!;
    [JsonPropertyName("formatCraftingBuySum")]
    public string FormatCraftingBuySum { get; set; } = null!;
    [JsonPropertyName("image")]
    public string Image { get; set; } = null!;
    [JsonPropertyName("imagePath")]
    public string ImagePath { get; set; } = null!;

    [JsonPropertyName("sortedStats")]
    public ItemStatContainer[] SortedStats { get; set; } = null!;
}
