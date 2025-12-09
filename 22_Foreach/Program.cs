using System.Collections.Generic;







List<int> numbers = new List<int>() 
{
    23,3,5,10,22,12
};

foreach (var number in numbers)
{
    Console.WriteLine(number);
}



var students = new List<People>()
{
    new People() { Name = "Iván", Country = "Chile"},
    new People() { Name = "Sophia", Country = "Francia"},
    new People() { Name = "Amelia", Country = "Australia"},
};

Show(students);

students.RemoveAt(0);

Show(students);


static void Show(List<People> students)
{
    Console.WriteLine("-- Personas --");
    foreach (var student in students)
    {
        Console.WriteLine($"Nombre: {student.Name}, País: {student.Country}");
    }
}

class People
{
    public string Name { get; set; }
    public string Country { get; set; }
}