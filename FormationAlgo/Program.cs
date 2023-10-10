// Récupération de deux nombres
Console.WriteLine("Veuillez saisir un premier nombre");
string saisie1 = Console.ReadLine();
int nombre1 = int.Parse(saisie1);

Console.WriteLine("Veuillez saisir un deuxième nombre");
string saisie2 = Console.ReadLine();
int nombre2 = int.Parse(saisie2);

// Tests sur le résultat du produit
// Rappel : Le produit de 2 nombres est négatif si l'un des 2 nombres est
// négatif, mais pas les deux
bool nombre1Negatif = nombre1 < 0;
bool nombre2Negatif = nombre2 < 0;
bool unSeulNegatif = nombre1Negatif ^ nombre2Negatif;

if (unSeulNegatif)
{
    Console.WriteLine("Le produit sera négatif");
}
else
{
    Console.WriteLine("Le produit sera positif");
}


// Version Michael : si les 2 nombres sont de signe opposé
if (nombre1 < 0 && nombre2 > 0 || nombre1 > 0 && nombre2 < 0)
{
    Console.WriteLine("Le produit sera négatif");
}
else
{
    Console.WriteLine("Le produit sera positif");
}