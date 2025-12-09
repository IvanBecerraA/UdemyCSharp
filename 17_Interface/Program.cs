

Shark[] sharks = new Shark[]
{
    new Shark("Tiburonsin", 56),
    new Shark("Jaws", 65)
};

ShowFish(sharks);
ShowAnimals(sharks);

IFish[] fish = new IFish[]{
    new Siren(100),
    new Shark("Tiburonsin", 56),
};

ShowFish(fish);


static void ShowAnimals(IAnimal[] animals)
{
    Console.WriteLine("- Mostramos los peces -");
    int i = 0;
    while (i < animals.Length)
    {
        Console.WriteLine(animals[i++].Name);
    }
}


static void ShowFish(IFish[] fishs)
{
    Console.WriteLine("- Mostramos los animales -");
    int i = 0;
    while (i < fishs.Length)
    {
        Console.WriteLine(fishs[i++].Swim());
    }
}

public class Siren: IFish
{
    public int Speed { get; set; }

    public Siren(int speed)
    {
        this.Speed = speed;
    }

    public string Swim()
    {
        return $"La Sirena nada a {Speed}km/h";
    }
}

public class Shark: IAnimal, IFish
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Shark(string name, int speed)
    {
        this.Name = name;
        this.Speed = speed;
    }

    public string Swim()
    {
        return $"{Name} Nada {Speed} km/h";
    }
}


public interface IAnimal
{
    public string Name { get; set; }
}

public interface IFish
{
    public int Speed { get; set; }
    public string Swim();
}