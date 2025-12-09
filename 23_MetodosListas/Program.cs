

List<int> numbers = new List<int>()
{
    4,3,5,19
};

Show(numbers);

numbers.Insert(0,1);

Show(numbers);



if (numbers.Contains(33))
    Console.WriteLine("existe");
else
    Console.WriteLine("no existe");



int pos = numbers.IndexOf(19);
Console.WriteLine(pos);

numbers.Sort();
Show(numbers);


var numbers2 = new List<int>()
{
    300,200,400
};
numbers.AddRange(numbers2);
Show(numbers);

static void Show(List<int> numbers)
{
    Console.WriteLine("-- Números --");
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
}