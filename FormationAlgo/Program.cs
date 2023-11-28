// On veut le tableau suivant : [0, 1, 2, 3, 4, 5]

// Solution ultra rapide :
int[] tableau = new int[] { 0, 1, 2, 3, 4, 5 };



// Solution plus évolutive sans boucle for :
int[] tableau1 = new int[6];

tableau1[0] = 0;
tableau1[1] = 1;
tableau1[2] = 2;
tableau1[3] = 3;
tableau1[4] = 4;
tableau1[5] = 5;

// Solution plus évolutive avec boucle for :
int[] tableau2 = new int[6];

for (int i = 0; i < 6; i++)
{
    tableau2[i] = i;
}


// Solution avec saisie utilisateur :
Console.WriteLine("Veuillez saisir le nombre de cases du tableau : ");
string saisie = Console.ReadLine();
int nombreCases = int.Parse(saisie);

int[] tableau3 = new int[nombreCases];

for (int i = 0; i < tableau3.Length; i++)
{
    tableau3[i] = i;
}

Console.WriteLine(string.Join(", ", tableau3));

