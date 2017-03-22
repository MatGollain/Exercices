using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            JeuPendu();
            Console.ReadKey();
        }

        static void JeuPendu()
        {
            string mot, tente;
            char[] trouve;
            int choix, essai = 7;
            char lettre;

            Console.WriteLine("Joueur 1, veuillez saisir un mot :");
            mot = SaisiMot();
            while (mot == string.Empty)
            {
                Console.WriteLine("Mauvais saisie, merci de ne pas mettre de chiffre ou caractère spéciaux");
                mot = SaisiMot();
            }
            trouve = new char[mot.Length];
            InitialiseTabChar(trouve);
            while (essai > 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Il vous reste " + essai + "essais");
                AffichMenu();
                choix = SaisiChoix();
                switch (choix)
                {
                    case 1:
                        Console.WriteLine(" ");
                        Console.WriteLine("Veuillez saisir une lettre:");
                        lettre = SaisiLettre();
                        TesterLettre(mot, lettre, trouve);
                        AffichRep(trouve);
                        break;
                    case 2:
                        Console.WriteLine(" ");
                        Console.WriteLine("Veuillez saisir une réponse:");
                        tente = SaisiMot();
                        while (tente == string.Empty)
                        {
                            tente = SaisiMot();
                        }
                        if (TesterMot(mot, tente))
                        {
                            Console.Write("Félicitation ! Vous avez trouvé le bon mot : ");
                            AffichMot(mot);
                            Console.Write(" en " + essai + "essais!");
                        }
                        break;
                    case 3:
                        Console.WriteLine(" ");
                        Console.Write("Dommage ! Le mot à trouvé était : ");
                        AffichMot(mot);
                        break;
                    default:
                        Console.WriteLine("Erreur programmation!");
                        break;
                }
                essai--;
            }
        }

        static void InitialiseTabChar (char[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                tab[i] = '.' ;
        }

        static void AffichRep (char[] trouve)
        {
            for (int i = 0; i < trouve.Length; i++)
            {
                if (trouve[i] == '.')
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(trouve[i] + " ");
                }
            }
        }

        static void AffichMot (string mot)
        {
            Console.WriteLine(mot);
        }

        static bool TesterMot (string mot, string tente)
        {
            if (mot.CompareTo(tente) == 0)
                return true;
            return false;
        }

        static void TesterLettre(string mot, char lettre, char[] trouve)
        {
            for (int i = 0; i < mot.Length; i++)
            {
                if (mot[i] == lettre)
                {
                    trouve[i] = lettre;
                }
            }
        }

        static void AffichMenu()
        {
            Console.WriteLine("Joueur 2, vous voulez :");
            Console.WriteLine("1 - Saisir une lettre ?");
            Console.WriteLine("2 - Essayer de deviner le mot ?");
            Console.WriteLine("3 - Abandonner.");
        }

        static int SaisiChoix()
        {
            int choix;
            choix = int.Parse(Console.ReadLine());
            while (choix != 1 && choix !=2 && choix != 3)
            {
                Console.WriteLine("Veuillez saisir un choix valide (1 ou 2 ou 3) :");
                choix = int.Parse(Console.ReadLine());
            }
            return choix;
        }

        static string SaisiMot()
        {
            string mot;
            mot = (Console.ReadLine()).Trim();
            string pattern = "^[a-zA-Z]$";
            if (Regex.IsMatch(mot,pattern) /*&& mot[mot.Length-1] == '$'*/)
                    return ("");
            return mot;
        }

        static char SaisiLettre()
        {
            string c;
            c = (Console.ReadLine()).Trim();
            while (c.Length>1)
            {
                Console.WriteLine("Veuillez ne saisir qu'une lettre :");
                c = Console.ReadLine();
            }
            return (char.Parse(c));
        }
    }
}
