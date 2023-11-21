// Saisie nombre compris entre 1 et 3
Console.WriteLine("Veuillez saisir un nombre entre 1 et 3 (compris) :");
string saisie = Console.ReadLine();

int nombre = int.Parse(saisie);

bool saisieValide = nombre >= 1 && nombre <= 3;
bool saisieInvalide = !saisieValide;

// Contrôle de la saisie
while (saisieInvalide)
{
    Console.WriteLine("Ce nombre n'est pas compris entre 1 et 3 (compris).");
    Console.WriteLine("Veuillez saisir un nombre entre 1 et 3 (compris) :");
    saisie = Console.ReadLine();

    nombre = int.Parse(saisie);
    saisieValide = nombre >= 1 && nombre <= 3;
    saisieInvalide = !saisieValide;
}

// Message si réponse OK
Console.WriteLine($"Bravo ! Vous avez saisi {nombre} !");


