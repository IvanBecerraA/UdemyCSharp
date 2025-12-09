

var beers = new List<Beer>()
{
    new Beer() {Name="Corona", Country="México"},
    new Beer() {Name="Delirium", Country="Bélgica"},
    new Beer() {Name="Erdinger", Country="Alemania"},
};

var countries = new List<Country>()
{
    new Country() {Name="México", Continent="América"},
    new Country() {Name="Bélgica", Continent="Europa"},
    new Country() {Name="Alemania", Continent="Europa"},
};


var beersWithContinent = from beer in beers
                         join country in countries on beer.Country equals country.Name
                         select new { beer.Name, beer.Country, Continente = country.Continent};
foreach (var beer in beersWithContinent)
    Console.WriteLine(beer);





public class Beer
{
    public string Name { get; set; }
    public string Country { get; set; }
}

public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
}