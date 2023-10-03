// Récupération du nombre
Console.WriteLine("Veuillez saisir un nombre pour savoir s'il est positif ou négatif: ");
string saisie = Console.ReadLine();

// Conversion de string vers decimal
decimal nombre = decimal.Parse(saisie);

// Affichage conditionnel
if (nombre > 0)
{
    Console.WriteLine("Le nombre est positif");
}
else if (nombre < 0)
{
    Console.WriteLine("Le nombre est négatif");
}
else
{
    Console.WriteLine("Le nombre est positif ET négatif (c'est zéro)");
}