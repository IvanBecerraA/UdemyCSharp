using DB;
using Microsoft.EntityFrameworkCore;


DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = 
    new DbContextOptionsBuilder<CsharpDbContext>();
optionsBuilder.UseSqlServer("Server=localhost;Database=CSharpDB;Trusted_Connection;");


using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options))
{
    var beers = context.Beers.ToList();

    foreach (var beer in beers)
    {
        Console.WriteLine(beer.Name);
    }

}




