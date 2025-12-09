using System.Collections.Generic;
using System.Linq;

List<Beer> beers = new List<Beer>() 
{ 
    new Beer(){Name="Corona", Country="México"},
    new Beer(){Name="Delirium", Country="Bélgica"},
    new Beer(){Name="Erdinger", Country="Alemania"},
};

foreach (Beer beer in beers )
    Console.WriteLine(beer.ToString());




Console.WriteLine("--------------------");

// SELECT
var beersName = from b in beers
                select new 
                { 
                    Name = b.Name,
                    Letters = b.Name.Length
                };

foreach (var beer in beersName)
    Console.WriteLine($"{beer.Name} {beer.Letters}");





Console.WriteLine("--------------------");

var beersNameReal = from b in beersName
                    select new
                    {
                        Name = b.Name,
                    };
foreach (var beer in beersNameReal) 
    Console.WriteLine(beer.Name);





Console.WriteLine("--------------------");

var beerMexico = from b in beers
                 where b.Country == "México"
                 || b.Country == "Alemania"
                 select b;
foreach (var beer in beerMexico)
    Console.WriteLine(beer);






Console.WriteLine("--------------------");

var orderedBeers = from b in beers
                   orderby b.Country descending
                   select b;
foreach (var beer in orderedBeers)
    Console.WriteLine(beer);


public class Beer
{
    public string Name { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, País: {Country}";
    }
}