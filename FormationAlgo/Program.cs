// Demander l'age de l'utilisateur
Console.Write("Veuillez saisir votre âge : ");
string saisieAge = Console.ReadLine();
bool isAgeSuccess = int.TryParse(saisieAge, out int age);

if (isAgeSuccess == false)
{
    Console.Write("Veuillez saisir votre âge : ");
    saisieAge = Console.ReadLine();
    isAgeSuccess = int.TryParse(saisieAge, out age);
}

// Lui demander s'il est une fille ou un garçon 
// 1. Fille
// 2. Garçon
Console.Clear();
Console.WriteLine("Êtes-vous une fille ou un garçon ?");
// Console.WriteLine("1. Fille\r\n2. Garçon");
// Console.WriteLine("1. Fille" + Environment.NewLine + "2. Garçon");
Console.WriteLine("1. Fille");
Console.WriteLine("2. Garçon");
Console.WriteLine();
Console.Write("Sélectionnez 1 ou 2 : ");
string saisieGenre = Console.ReadLine();
bool isGenreSuccess = int.TryParse(saisieGenre, out int choixGenre);

if (isGenreSuccess == false)
{
    Console.WriteLine("Êtes-vous une fille ou un garçon ?");
    Console.WriteLine("1. Fille");
    Console.WriteLine("2. Garçon");
    Console.WriteLine();
    Console.Write("Sélectionnez 1 ou 2 : ");
    saisieGenre = Console.ReadLine();
    isGenreSuccess = int.TryParse(saisieGenre, out choixGenre);
}

if (isAgeSuccess && isGenreSuccess)
{
    //A partir de ces informations, afficher le texte :
    //Tu es mineur(e)
    //ou
    //Tu es majeur(e)
    string messageFinal = "Tu es ";

    if (age < 18)
        messageFinal += "mineur"; //messageFinal = messageFinal + "mineure.";
    else
        messageFinal += "majeur";

    if (choixGenre == 1)
        messageFinal += "e";

    Console.WriteLine(messageFinal);
}
else
{
    Console.WriteLine("Problème malgré 2 tentatives !");
}
