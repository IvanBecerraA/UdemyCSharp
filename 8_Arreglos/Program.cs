string[] friends = new string[7]{
    "Pancho",
    "Paco",
    "Ana",
    "Ruben",
    "Karla",
    "Luis",
    null
};

friends[6] = "Iván";

foreach (string friend in friends)
{
    Console.WriteLine(friend);
}

