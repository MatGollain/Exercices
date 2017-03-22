using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_NbPremier
{
    class Program
    {
        static void Main(string[] args)
        {
            CombienPremier();
            //NbPremier();
            //Correction();
            Console.ReadKey();
        }


        static int SaisiPremier()
        {
            Console.WriteLine("Combien de nombre premier (0 pour sortir) : ");
            return int.Parse(Console.ReadLine());
        }

        static void CombienPremier()
        {
            int n;
            n = SaisiPremier();
            while (n != 0)
            {
                CalculerPremier(n);
                n = SaisiPremier();
            }
        }

        static void NbPremier()
        {
            string c;
            int n, nbr, divis, compt;
            bool estPremier;

            Console.WriteLine("Combien de nombre premier: ");
            c = Console.ReadLine();
            n = int.Parse(c);

            compt = 1;
            Console.WriteLine("2"); // 1 n'est pas premier
            nbr = 3;
            while(compt < n)
            {
                divis = 2;
                estPremier = true;
                do
                {
                    if (nbr % divis == 0)
                    {
                        estPremier = false;
                    }
                    else
                    {
                        divis++;
                    }
                } while (estPremier && divis < nbr / 2);
                if (estPremier)
                {
                    Console.WriteLine(nbr);
                    compt++;
                }
                nbr += 2;
            }
        }

        static void Correction()
        {
            int divis, nbr, n, compt = 0;
            bool Est_premier;
            Console.Write("Combien de nombres premiers : ");
            n = Int32.Parse(System.Console.ReadLine());
            Console.WriteLine(2); // WriteLine = new line | Write = ecriture sur la même ligne
            nbr = 3;
            while (compt < n - 1)
            {
                divis = 2;
                Est_premier = true;
                do
                {
                    if (nbr % divis == 0) Est_premier = false;
                    else divis = divis + 1;
                }
                while ((divis <= nbr / 2) && (Est_premier == true));
                if (Est_premier)
                {
                    compt++;
                    System.Console.WriteLine(nbr);
                }
                nbr++;
            }
        }

        static void CalculerPremier(int nbPrem)
        {
            int nbr, divis, compt=1;
            bool estPremier;
            Console.WriteLine("2"); // 1 n'est pas premier
            nbr = 3;
            while (compt < nbPrem)
            {
                divis = 2;
                estPremier = true;
                do
                {
                    if (nbr % divis == 0)
                    {
                        estPremier = false;
                    }
                    else
                    {
                        divis++;
                    }
                } while (estPremier && divis < nbr / 2);
                if (estPremier)
                {
                    Console.WriteLine(nbr);
                    compt++;
                }
                nbr += 2;
            }
        }
    }
}
