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
            NbPremier();
            Console.ReadKey();
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
            if (n > 1)
            {
                Console.WriteLine("3");
                compt++;
            }
            nbr = 3;
            while(compt < n)
            {
                divis = 3;
                estPremier = true;
                do
                {
                    if (nbr % divis == 0)
                    {
                        estPremier = false;
                    }
                    else
                    {
                        divis += 2;
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

        static void correction()
        {
            int divis, nbr, n, compt = 0;
            bool estPremier;
            Console.WriteLine("Combien de nombre premier: ");
            n = Int32.Parse(System.Console.ReadLine());
            Console.WriteLine(2);
            nbr = 3;
            while(compt < n-1)
            {
                divis = 2;
                estPremier = true;
                do
                {
                    if (nbr % divis == 0) estPremier = false;
                    else divis++;
                } while ((divis <= nbr / 2));
            }
            if (estPremier)
            {
                compt++;
                Console.WriteLine(nbr);
            }
            nbr++;
        }
    }
}
