using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tab = {"un","deux","trois","quatre","cinq","six","sept","huit","neuf","dix"};
            string[] tab2 = new string[tab.Length];
            AffichTab(tab);
            tab2=TriAlpha(tab);
            AffichTab(tab);
            AffichTab(tab2);
            Console.ReadKey();
        }

        static void AffichTab (string[] tab)
        {
            foreach (string elmt in tab)
            {
                Console.Write(elmt + " ");
            }
            Console.WriteLine(" ");
        }

        static string[] TriAlpha(string[] resu)
        {
            string[] tab = new string[resu.Length];
            for (int i = 0; i < tab.Length; i++)
                tab[i] = resu[i];
            string pont;
            bool echange = true;
            while (echange)
            {
                echange = false;
                for (int i = 0; i < tab.Length - 1; i++) // continue = next, va à la prochaine itération de la boucle.
                {
                    if (tab[i].CompareTo(tab[i + 1])>0)
                    {
                        pont = tab[i];
                        tab[i] = tab[i+1];
                        tab[i+1] = pont;
                        echange = true;
                    }
                }
            }
            return tab;
        }
    }
}
