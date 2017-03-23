using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_PGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculDuPGCD();
            Console.ReadKey();
        }

        static void CalculDuPGCD()
        {
            string c;
            int i, j;
            Console.WriteLine("Saisissez le 1er entier :");
            c = Console.ReadLine();
            i = int.Parse(c);
            Console.WriteLine("Saisissez le 2nd entier :");
            c = Console.ReadLine();
            j = int.Parse(c);

            while (i != j)
            {
                if (i > j)
                {
                    i = i - j;
                }
                else
                {
                    j = j - i;
                }
            }
            Console.WriteLine("PGCD =" + i);

        }
    }
}
