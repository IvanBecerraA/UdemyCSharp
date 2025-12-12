Operation mySum = Functions.Sum;
//Console.WriteLine(mySum(3, 5));

mySum = Functions.Mul;
//Console.WriteLine(mySum(3, 5));

Show show = Functions.ConsoleShow;
//show("Hola mundo!");

Show cw = Console.WriteLine;
cw += Functions.ConsoleShow; // Multi difucion
//cw("Hola mundo2!");

//Functions.Some("Iván", "Becerra", cw);

// Action no retorna
#region Action

string hi = "Hola";
Action<string> showMessage = Console.WriteLine;
Action<string, string> showMessage2 = (a, b) => Console.WriteLine($"{a} {b}");
Action<string, string> showMessage3 = (a, b) =>
{
    Console.WriteLine($"{hi} {a} {b}");
};
Action<string, string, string> showMessage4 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");



//showMessage2("Iván", "Becerra");
//showMessage4("Iván", "Becerra", "Dev");

//Functions.SomeAction("Iván", "Becerra", (a) => Console.WriteLine("soy una expresión lambda. " + a));

//Functions.SomeAction("Iván", "Becerra", showMessage);


#endregion

// Func retorna
#region Func

Func<int> numberRandom = () => new Random().Next(0, 100);
//Console.WriteLine(numberRandom());

Func<int,int> numberRandomLimit = (limit) => new Random().Next(0, limit);
//Console.WriteLine(numberRandomLimit(10));

#endregion


#region Predicate

Predicate<string> hasSpace = (word) => word.Contains(" ");
Console.WriteLine(hasSpace("tengo espacio"));

Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("tengoa"));

Console.WriteLine("----------------------");
var words = new List<string>() 
{
    "beer",
    "patito",
    "sandia",
    "hola mundo",
    "c#"
};
var wordsNew = words.FindAll((w) => !hasSpaceOrA(w));
foreach (var w in wordsNew) Console.WriteLine(w);
#endregion


#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string message2);
public delegate void Show3(string message, string message2, string message3);
#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;

    public static int Mul(int num1, int num2) => num1 * num2;

    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastName}");
        Console.WriteLine("Hago algo al final");
    }


}