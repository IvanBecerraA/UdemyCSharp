Operation mySum = Functions.Sum;
Console.WriteLine(mySum(3, 5));

mySum = Functions.Mul;
Console.WriteLine(mySum(3, 5));

Show show = Functions.ConsoleShow;
show("Hola mundo!");

Show cw = Console.WriteLine;
cw("Hola mundo2!")

delegate int Operation(int a, int b);
delegate void Show(string message);


public class Functions
{
    public static int Sum(int x, int y) => x + y;

    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string m) => Console.WriteLine(m);
}