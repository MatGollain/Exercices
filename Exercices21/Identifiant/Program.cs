using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifiant
{
    class Program
    {
        static void Main(string[] args)
        {
            Identifiant();
            Console.ReadLine();

        }

        static void Identifiant()
        {
            string login, password;
            bool passCorrect = false;
            bool logCorrect = false;
            while (!logCorrect)
            {
                logCorrect = true;
                try
                {
                    Console.WriteLine("Veuillez saisir un login (5 charactères minimum) :");
                    CtrlLogin(out login);
                    while (!passCorrect)
                    {
                        passCorrect = true;
                        try
                        {
                            Console.WriteLine("Veuillez saisir un mot de passe (6 à 12 charactères et ne pas commencer ou finir par un espace) :");
                            CtrlPassword(out password);
                        }
                        catch (FormatException e)
                        {
                            passCorrect = false;
                            Console.WriteLine(e.Message);
                        }
                    }
                }
                catch (FormatException e)
                {
                    logCorrect = false;
                    Console.WriteLine(e.Message);
                }
            }
            if (logCorrect && passCorrect)
               Console.WriteLine("Votre compte a été créé avec succès.");
        }

        static void CtrlLogin(out string log)
        {
            log = Console.ReadLine();
            if (log.Length<5)
                throw new FormatException("Login trop court, le login doit faire au moins 5 charactères.");
        }

        static void CtrlPassword(out string pass)
        {
            pass = Console.ReadLine();
            if (pass.Length < 6)
            {
                throw new FormatException("Mot de passe trop court, le mot de passe doit faire au moins 6 charactères.");
            }
            else if (pass.Length > 15)
            {
                throw new FormatException("Mot de passe trop long, le mot de passe doit faire au plus 12 charactères.");
            }
            else if (pass[0] == ' ')
            {
                throw new FormatException("Mot de passe incorrect, le mot de passe ne doit pas commencer par un espace.");
            }
            else if (pass[pass.Length-1] == ' ')
            {
                throw new FormatException("Mot de passe incorrect, le mot de passe ne doit pas finir par un espace.");
            }
        }
    }
}
