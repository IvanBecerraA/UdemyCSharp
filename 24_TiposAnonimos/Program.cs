




var ivan = new
{
    Name = "Iván",
    Country = "Chile"
};

Console.WriteLine($"{ivan.Name}, {ivan.Country}");

var beers = new[]
{
    new { Name= "Red", Brand= "Delirium"},
    new { Name= "London Porter", Brand = "Fullers"}
};

foreach (var b in beers) 
{
    Console.WriteLine($"cerveza {b.Name} {b.Brand}");
}