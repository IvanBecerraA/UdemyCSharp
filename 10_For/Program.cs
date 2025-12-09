

string[] friends = new string[6]
{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Karla",
    "Luis"
};


bool run = false;
for (int i = 0; i < friends.Length && run; i++)
{
    Console.WriteLine(friends[i]);
}

