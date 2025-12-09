using _31_SQL_Connexion;
using System.Data.SqlClient;
using System.Security;
using System.Threading.Channels;


try
{

    BeerDB beerDB = new BeerDB("localhost", "CSharpDB", "sa", "sasa");
    bool again = true;
    int op = 0;

    do
    {
        ShowMenu();
        Console.WriteLine("Elige una opción: ");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Show(beerDB);
                break;
            case 2:
                Add(beerDB);
                break;
            case 3:
                Edit(beerDB);
                break;
            case 5:
                again = false;
                break;
            default:
                again = false;
                break;
        }
    } while (again);


}
catch (SqlException ex)
{
    Console.WriteLine($"Error al conectar la DB: {ex}");
}


static void ShowMenu()
{
    Console.WriteLine("\n-------------Menu------------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}

static void Show(BeerDB beerDB) 
{
    Console.Clear();
    Console.WriteLine("Cervezas de la DB");
    List<Beer> beers = beerDB.GetAll();
    foreach (Beer beer in beers)
    {
        Console.WriteLine($"Id: {beer.Id}, Nombre: {beer.Name}");
    }
}

static void Add(BeerDB beerDB)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cerveza");
    Console.WriteLine("Escribe el nombre: ");
    string name = Console.ReadLine();
    Console.WriteLine("Escribe el nombre de la marca: ");
    int brandId = int.Parse(Console.ReadLine());
    Beer beer = new Beer(name, brandId);
    beerDB.Add(beer);
}

static void Edit(BeerDB beerDB)
{
    Console.Clear();
    Show(beerDB);
    Console.WriteLine("Editar Cerveza");
    Console.WriteLine("Escribe el id de tu cerveza a editar: ");
    int id = int.Parse(Console.ReadLine());

    Beer beer = beerDB.Get(id);
    if (beer != null)
    {
        Console.WriteLine("Escribe el nombre: ");
        string name = Console.ReadLine();
        Console.WriteLine("Escribe el id de la marca: ");
        int brandId = int.Parse(Console.ReadLine());

        beer.Name = name;
        beer.BrandId = brandId;

        beerDB.Edit(beer);
    }
    else
    {
        Console.WriteLine("La cerveza no existe");
    }
}