// Úkol 1
bool proceed = true;
string finalSentence = "";
while (proceed)
{
    Console.WriteLine("Zadej slovo");
    string userInput3 = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput3))
    {
        Console.WriteLine(finalSentence);
        proceed = false;
    }
    else if (!string.IsNullOrEmpty(userInput3))
    {
        finalSentence += userInput3;
    }
}

// Úkol 2
string userInput1 = Console.ReadLine();
int userInput2 = 6;

for (int i = 1; i < userInput2; i++)
{
    Console.WriteLine($"{i}. {userInput1}");
}

/*
//Úkol 3
Console.Write("Zadejte slovo: ");
string slovo = Console.ReadLine();
int pocetOpakovani = 1;

while (!string.IsNullOrEmpty(slovo))
{
    for (int i = 0; i < pocetOpakovani; i++)
    {
        Console.Write(slovo + " ");
    }

    Console.WriteLine(); // Nový řádek pro další slovo
    pocetOpakovani++;

    Console.Write("Zadejte další slovo (nebo stiskněte Enter pro ukončení): ");
    slovo = Console.ReadLine();
*/