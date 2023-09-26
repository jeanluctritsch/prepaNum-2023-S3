// Saisie PrixHT
Console.WriteLine("Veuillez saisir le prix HT d'un article :");
string prixHTSaisi = Console.ReadLine();
prixHTSaisi = prixHTSaisi.Replace('.', ',');
decimal prixHT = decimal.Parse(prixHTSaisi);

// Saisie Nombre Articles
Console.WriteLine("Veuillez saisir le nombre d'articles souhaités : ");
string nbArticlesSaisi = Console.ReadLine();
int nbArticles = int.Parse(nbArticlesSaisi);

// Saisie Taux de TVA
Console.WriteLine("Veuillez saisir le taux de TVA de l'article (en %) : ");
string tauxTVASaisi = Console.ReadLine();
tauxTVASaisi = tauxTVASaisi.Replace('.', ',');
decimal tauxTVA = decimal.Parse(tauxTVASaisi);

// Calcul du prix total TTC
decimal tvaUnitaire = prixHT * tauxTVA / 100;

decimal prixTTCUnitaire = prixHT + tvaUnitaire;

decimal prixTTCTotal = prixTTCUnitaire * nbArticles;


// Affichage du prix total TTC
Console.WriteLine($"Le prix total TTC est de {prixTTCTotal} euros");