using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Parametres
{
    class Program
    {
        static void Main(string[] args)
        {
            int vo, co;
            string mot = SaisiMot();
            CalculVoyCon(ref mot, out vo, out co);
            Console.WriteLine("Dans le mot : {0} contient {1} voyelles et {2} consonnes", mot, vo, co);
            Console.ReadKey();
        }

        static string SaisiMot ()
        {
            Console.WriteLine("Saisissez un mot :");
            return Console.ReadLine();

        }

        static void CalculVoyCon (ref string mot, out int vo, out int co)
        {
            mot = mot.ToUpper();
            vo = 0;
            string pattern = @"[AEIOUY]";
            for (int i=0; i < mot.Length; i++)
            {
                if (Regex.IsMatch(Convert.ToString(mot[i]), pattern))
                    vo++;
            }
            co = mot.Length - vo;
        }
    }
}
