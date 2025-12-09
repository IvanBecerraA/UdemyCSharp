



using System.IO;

try
{
    string content = File.ReadAllText("D:\\Cursos\\C# H de leon\\Variables\\26_Excepciones\\txt\\txt.txt");
    Console.WriteLine(content);

    //string content2 = File.ReadAllText("D:\\Cursos\\C# H de leon\\Variables\\26_Excepciones\\txt\\txt2.txt");
    //Console.WriteLine(content2);

    throw new Exception("ocurrio algo raro");

}
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Error al leer el archivo: {ex}");
} 
catch (Exception ex)
{
    Console.WriteLine($"Error al leer el archivo: {ex}");
}
finally
{
    Console.WriteLine("Aquí me he ejecutado pase lo que pase");
}

Console.WriteLine("Aquí sigue funcinando");