int i = 0;

while (i < 10)
{
    Console.WriteLine("Iteración de i " + i);
    i++;
}

int j = 0;
while (j < 100)
{
    if (j == 5)
    {
        j++;
        continue;
    }

    if (j > 10)
        break;

    Console.WriteLine("Iteración de j: " + j);
    j++;
}


string[] arreglo = new string[6]
{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Karla",
    "Luis"
};


int index = 0;
while (index < arreglo.Length)
{
    Console.WriteLine(arreglo[index++]);
}


bool run = false;
do
{
    Show();
}  while (run);


void Show()
{
    Console.WriteLine("Entro una vez y ya");
}