// Demander à l'utilisateur de saisir un nombre
Console.WriteLine("Veuillez saisir un nombre : ");

// Recueillir le nombre saisi
string saisie = Console.ReadLine();

// Calculer le carré du nombre saisi
// résultat = saisie * saisie;
int nombre = int.Parse(saisie);
int resultat = nombre * nombre;

// Afficher le résultat
Console.WriteLine($"Le carré de {nombre} est {resultat}");