// ?? : 5-
// Poussin : 6, 7
// Pupille : 8, 9
// Minime : 10, 11
// Cadet : 12+

Console.WriteLine("Veuillez saisir l'âge de l'enfant : ");
string saisieAge = Console.ReadLine();
int age = int.Parse(saisieAge);

// Si l'âge saisi est inférieur à 0, on va proposer de corriger la saisie
if (age < 0)
{
    int ageInverse = -age;   // age * -1
    Console.WriteLine($"La saisie est négative. Vouliez-vous dire {ageInverse} ans ? (y / n)");
    string reponseUtilisateur = Console.ReadLine();

    if (reponseUtilisateur.ToLower() == "y" || reponseUtilisateur.ToLower() == "yes")
    {
        age = ageInverse;
    }
    else
    {
        Console.WriteLine("T'es con !");
        Environment.Exit(0);
    }
}

// Algorithme avec des plages de valeurs
if (age < 6)  // équivalent à if (age <= 5) parce que age est un entier
{
    Console.WriteLine("Tu es trop petit, reviens plus tard !");
}
else if (age >= 6 && age <= 7)
{
    Console.WriteLine("Tu es Poussin !");
}
else if (age >= 8 && age <= 9)
{
    Console.WriteLine("Tu es Pupille !");
}
else if (age >= 10  && age <= 11)
{
    Console.WriteLine("Tu es Minime !");
}
else
{
    Console.WriteLine("Tu es Cadet !");
}
