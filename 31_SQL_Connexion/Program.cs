using _31_SQL_Connexion;
using System.Data.SqlClient;


try
{

    BeerDB db = new BeerDB("localhost", "CSharpDB", "sa", "sasa");
    List<Beer> beers = db.GetAll();
    foreach (Beer beer in beers )
    {
        Console.WriteLine(beer.Name);
    }
}
catch (SqlException ex)
{
    Console.WriteLine($"Error al conectar la DB: {ex}");
}
