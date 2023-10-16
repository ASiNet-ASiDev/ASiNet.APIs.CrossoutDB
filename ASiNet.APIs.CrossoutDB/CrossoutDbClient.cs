using System.Net.Http.Json;
using System.Text.Json;
using ASiNet.APIs.CrossoutDB.Domain;
using Microsoft.AspNetCore.WebUtilities;

namespace ASiNet.APIs.CrossoutDB;

public class CrossoutDbClient
{
    public CrossoutDbClient(string baseUri = "http://crossoutdb.com/")
    {
        _client = new();
        _client.BaseAddress = new(baseUri);
    }

    private HttpClient _client;

    public async Task<bool> Health()
    {
        var result = await _client.GetAsync("/api/v2/health");

        if(result.StatusCode == System.Net.HttpStatusCode.OK)
            return true;
        return false;
    }

    public async Task<Languages?> Languages()
    {
        var result = await _client.GetAsync("/api/v2/languages");

        if (result.StatusCode == System.Net.HttpStatusCode.OK)
            return await result.Content.ReadFromJsonAsync<Languages>();
        return null;
    }

    public async Task<Rarity[]?> Rarities()
    {
        var result = await _client.GetAsync("/api/v2/rarities");

        if (result.StatusCode == System.Net.HttpStatusCode.OK)
            return await result.Content.ReadFromJsonAsync<Rarity[]>();
        return null;
    }

    public async Task<Faction[]?> Factions()
    {
        var result = await _client.GetAsync("/api/v2/factions");

        if (result.StatusCode == System.Net.HttpStatusCode.OK)
            return await result.Content.ReadFromJsonAsync<Faction[]>();
        return null;
    }

    public async Task<ItemType[]?> Types()
    {
        var result = await _client.GetAsync("/api/v2/types");

        if (result.StatusCode == System.Net.HttpStatusCode.OK)
            return await result.Content.ReadFromJsonAsync<ItemType[]>();
        return null;
    }

    public async Task<Category[]?> Categories()
    {
        var result = await _client.GetAsync("/api/v2/categories");

        if (result.StatusCode == System.Net.HttpStatusCode.OK)
            return await result.Content.ReadFromJsonAsync<Category[]>();
        return null;
    }

    public async IAsyncEnumerable<Item> Items(
        Language? language = null,
        Rarity? rarity = null,
        Category? category = null,
        Faction? faction = null,
        string? query = null, 
        string? removedItems = null, 
        string? metaItems = null)
    {
        var parameters = new Dictionary<string, string>();
        FillParameters(parameters, 
            () => ("language", language?.IsoName),
            () => ("rarity", rarity?.Name),
            () => ("category", category?.Name),
            () => ("faction", faction?.Name),
            () => ("removedItems", removedItems),
            () => ("metaItems", metaItems),
            () => ("query", query)
            );

        var result = await _client.GetAsync(QueryHelpers.AddQueryString("/api/v2/items", parameters));


        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var objects = (await result.Content.ReadFromJsonAsync<object[]>())?
                .Select(x => x.ToString())
                .Where(x => !string.IsNullOrWhiteSpace(x));
            if(objects is null)
                yield break;
            foreach (var item in objects)
            {
                yield return JsonSerializer.Deserialize<Item>(item!) ?? throw new Exception();
            }
        }
    }

    public async Task<Item?> Item(
        int Id,
        Language? language = null,
        Rarity? rarity = null,
        Category? category = null,
        Faction? faction = null,
        string? query = null,
        string? removedItems = null,
        string? metaItems = null)
    {
        var parameters = new Dictionary<string, string>();
        FillParameters(parameters,
            () => ("language", language?.IsoName),
            () => ("rarity", rarity?.Name),
            () => ("category", category?.Name),
            () => ("faction", faction?.Name),
            () => ("removedItems", removedItems),
            () => ("metaItems", metaItems),
            () => ("query", query)
            );

        var result = await _client.GetAsync(QueryHelpers.AddQueryString($"/api/v2/item/{Id}", parameters));


        if (result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            var obj = (await result.Content.ReadFromJsonAsync<object[]>())?.First().ToString();
            if(!string.IsNullOrEmpty(obj))
                return JsonSerializer.Deserialize<Item>(obj);
        }
        return null;
    }



    private void FillParameters(Dictionary<string, string> parameters, params Func<(string Key, string? Value)>[] objects)
    {
        foreach (var obj in objects)
        {
            var result = obj.Invoke();
            if(!string.IsNullOrWhiteSpace(result.Value))
                parameters.Add(result.Key, result.Value);
        }
    }
}
