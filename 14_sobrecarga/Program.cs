


Math math = new Math();

Console.WriteLine(math.Sum(1,2));
Console.WriteLine(math.Sum("a", "2"));

int[] numbers = new int[] { 1, 2, 5 };
Console.WriteLine(math.Sum(numbers));


class Math
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Sum(string a, string b)
    {
        //try
        //{
            return int.Parse(a) + int.Parse(b);
        //} catch
        //{
        //    return 0;
        //}
    }

    public int Sum(int[] numbers)
    {
        int result = 0;
        int i = 0;

        while (i < numbers.Length) 
        {
            result += numbers[i];
            i++;
        }
        return result;
    }
}