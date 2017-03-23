using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrainement
{
    class Program
    {
        static void Main(string[] args)
        {
            // corps de la fonction
            Demo();
            Console.ReadKey();
        }

        static /* => etat de la fonction */ void /* => type de retour */ Demo() /* => nom de la fonction */
        {
            string texte;
            string phrase;
            int nbPhrases, nbMots, nbCaracteres; 
            const double PI = 3.1415926;
            const string DEB_LISTE = " - ";

            phrase = "Le C# est un langage morderne et puissant!";
            texte = phrase;
            texte = texte + " C'est fou non!? \n";
            texte += DEB_LISTE + "Application console\n";
            texte += DEB_LISTE + "Application fenêtrée Winforms et WPF\n";

            Console.WriteLine(texte);


            char lettre;

            lettre = phrase[4];

            Console.WriteLine(lettre);


            short s = 2;
            // equivalence
            s = 3;
            s += 1;
            s++;

            Console.WriteLine("La valeur de s est : " + s);

            int[] tabPos = new int[4]; // déclaration d'un tableau de 3 entiers.
            int[] tabEx = new int[3] { 3, 4, 10 };
            tabPos[0] = 3;
            Console.WriteLine(tabPos[0] + "\n");
           
            // initialisé un string vide
            string str = string.Empty;

            // taille d'un tableau
            int tailleTab = tabPos.Length;

            // BOUCLE FOR
            for (int i = 0 /* initialisation de i */; i < tabEx.Length /* contrôle de la condition d'arrêt */; i++ /* incrémentation */)
            {
                Console.WriteLine(tabEx[i]);
            }

            // parcours de tableau en sens inverse
            for (int i = tabEx.Length-1; i >= 0; i--)
            {
                Console.WriteLine(tabEx[i]);
            }

            // BOUCLE WHILE
            int j = 0;
            while (j < tabEx.Length)
            {
                Console.WriteLine(tabEx[j]);
                j++;
            }

            Console.Clear();

            // compter le nombre de ligne dans la variable 'texte'

            nbPhrases = 0;
            for (int i=0; i<texte.Length; i++)
            {
                if (texte[i] == '\n')
                {
                    nbPhrases++;
                }
            }

            Console.WriteLine("Il y a " + nbPhrases + " phrases dans la variable \"texte\".");
            Console.Clear();

            // EXERCICE : compter le nombre de mot dans la variable 'phrase'

            nbMots = 1;
            for ( int i=0; i<phrase.Length; i++)
            {
                if (phrase[i] == '-')
                {
                    nbMots--;
                }
                else if (phrase[i] == '\n' || phrase[i] == ' ' || phrase[i] == '\'')
                {
                    nbMots++;
                }
            }

            Console.WriteLine(phrase + "\n");
            Console.WriteLine("Il y a " + nbMots + " mots dans la variable \"phrase\".");

            // EXERCICE : compter le nombre de mot dans la variable 'texte' /!\ FAUX /!\

            nbMots = 1;
            for (int i = 0; i < texte.Length; i++)
            {
                if (texte[i] == '-')
                {
                    nbMots--;
                }
                else if (texte[i] == '\n' || texte[i] == ' ' || texte[i] == '\'')
                {
                    nbMots++;
                }
            }

            Console.WriteLine("{0} et pourquoi pas {1}\n", texte,nbMots);       // |=>  Console.WriteLine("{0} \n", texte);   ==   Console.WriteLine(texte + "\n"); 
            Console.WriteLine("Il y a " + nbMots + " mots dans la variable \"texte\".");


        }

        static void Demo1() // entete | toujours une majuscule pour un nom de fonction | toujours () même sans arg
        {
            Console.WriteLine("Hello World!");
        }

    }
}

/* Pour écrire de manière totalement libre : @" zigezpgi    knezùrpinez
    bvknebpine" L'affichage montrera tel quel les sauts de lignes. Pour afficher une " il faut la doubler ""  */