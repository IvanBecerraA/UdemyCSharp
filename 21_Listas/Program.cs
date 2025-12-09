using System.Collections.Generic;





List<int> numbers = new List<int>();
numbers.Add(5);
numbers.Add(2);

Console.WriteLine(numbers.Count);

List<int> numbers2 = new List<int>() 
{
    1, 6, 7, 10, 14
};

Console.WriteLine(numbers2.Count);

numbers2.Add(55);
Console.WriteLine(numbers2.Count);

numbers.Clear();
Console.WriteLine(numbers.Count);


List<string> countries = new List<string>()
{
    "México", "Argentina", "Chile"
};

Console.WriteLine(countries.Count);
