bool nombreSaisiEstInvalide = false;

do
{
    // Receuillir la saisie du nombre de l'utilisateur
    Console.WriteLine("Veuillez saisir un nombre entre 10 et 20 (compris) :");
    string saisie = Console.ReadLine();
    int nombreSaisi = int.Parse(saisie);
    nombreSaisiEstInvalide = nombreSaisi < 10 || nombreSaisi > 20;
    // En fonction de la saisie, afficher "Trop grand" ou "Trop petit"
    if (nombreSaisi < 10)
    {
        Console.WriteLine("Trop petit !");
    }
    else if (nombreSaisi > 20)
    {
        Console.WriteLine("Trop grand !");
    }
}
while (nombreSaisiEstInvalide);

Console.WriteLine("C'est bon, tu peux passer");