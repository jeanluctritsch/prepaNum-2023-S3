// Demande de saisie du nombre
Console.WriteLine("Veuillez saisir un nombre:");
string saisieNombre = Console.ReadLine();
int nombre = int.Parse(saisieNombre);

if (nombre > 0)
{
    // Si le nombre est positif
    Console.WriteLine("Le nombre est positif");
}
else if (nombre < 0)
{
    // Si le nombre est négatif
    Console.WriteLine("Le nombre est négatif");
}
else
{
    // Autres cas
    Console.WriteLine("Le nombre est zéro. Il est négatif ET positif.");
}







