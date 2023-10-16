using ASiNet.APIs.CrossoutDB;
using ASiNet.APIs.CrossoutDB.Domain;

var api = new CrossoutDbClient();

Console.WriteLine((await api.Item(4, language: new() { IsoName = "ru"})).LocalizedName);

Console.ReadKey();