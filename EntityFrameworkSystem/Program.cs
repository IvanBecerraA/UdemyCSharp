using DB;
using Microsoft.EntityFrameworkCore;


DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = 
    new DbContextOptionsBuilder<CsharpDbContext>();
optionsBuilder.UseSqlServer("Server=localhost;Database=CSharpDB;Trusted_Connection;");


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
            Show(optionsBuilder);
            break;
        case 2:
            Add(optionsBuilder);
            break;

    }
} while (again);


static void ShowMenu()
{
    Console.WriteLine("\n-------------Menu------------");
    Console.WriteLine("1.- Mostrar");
    Console.WriteLine("2.- Agregar");
    Console.WriteLine("3.- Editar");
    Console.WriteLine("4.- Eliminar");
    Console.WriteLine("5.- Salir");
}


static void Show(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
{
    Console.Clear();
    Console.WriteLine("Cervezas en la base de datos: ");
    using (var context = new CsharpDbContext(optionsBuilder.Options))
    {
        //List<Beer> beers = context.Beers.ToList();
        List<Beer> beers = context.Beers.Where(b => b.BrandId == 2)
            .Include(b => b.Brand)
            .OrderBy(b => b.Name)
            .ToList();

        List<Beer> beers2 = (from b in context.Beers
                             where b.BrandId == 2
                             orderby b.Name
                             select b)
                             .Include(b => b.Brand)
                             .ToList();

        foreach (Beer beer in beers)
        {
            Console.WriteLine($"Id: {beer.Id}, Nombre: {beer.Name}, Brand: {beer.Brand.Name}");
        }
    }
}


static void Add(DbContextOptionsBuilder<CsharpDbContext> optionsBuilder)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cervaza");
    Console.WriteLine("Escribe el nombre: ");
    string name = Console.ReadLine();
    Console.WriteLine("Escribe el id de la marca: ");
    int brandId = int.Parse(Console.ReadLine());
    using (var context = new CsharpDbContext(optionsBuilder.Options))
    {
        Beer beer = new Beer()
        {
            Name = name,
            BrandId = brandId
        };
        context.Add(beer);
        context.SaveChanges();
    }
}