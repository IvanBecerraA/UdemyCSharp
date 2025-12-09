using System.Text.Json;





Beer myBeer = new Beer()
{
    Name = "Picantus",
    Brand = "Erdinger"
};

string json = JsonSerializer.Serialize(myBeer);

Console.WriteLine(json);

Beer myBeer2 = JsonSerializer.Deserialize<Beer>(json);



Beer[] beers = new Beer[]
{
    new Beer()
    {
        Name = "Pikantus",
        Brand = "Erdinger"
    },
    new Beer()
    {
        Name = "Corona",
        Brand = "Modelo"
    }
};

string json2 = JsonSerializer.Serialize(beers);
Console.WriteLine(json2);

Beer[] beers2 = JsonSerializer.Deserialize<Beer[]>(json2);



public class Beer
{
    public string Name { get; set; }
    public string Brand { get; set; }
}