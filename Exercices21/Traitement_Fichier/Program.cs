using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traitement_Fichier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chemin du fichier à analyser
            string chemin = @"..\..\DonnéesMétéoPartis.txt";

            string[] lignes = null;
            //Chargement du contenu du fichier dans un tableau de string
            //Le fichier étant indispensable pour la suite du traitement on met tout le code dans le try/catch
            try
            {
                lignes = File.ReadAllLines(chemin);

                //Initialisation des variables
                double tempMin = double.MaxValue;
                double tempMax = double.MinValue;

                DateTime moisTMin = DateTime.Today;
                DateTime moisTMax = DateTime.MinValue;

                DateTime moisTryCatch = DateTime.Today;
                double tMinTryCatch = double.MaxValue;
                double tMaxTryCatch = double.MinValue;

                //Parcours du tableau de lignes
                for (int l = 1; l < lignes.Length; l++)
                {
                    //Séparation des valeurs au niveau des tabulations ('\t')
                    string[] valeurs = lignes[l].Split('\t');

                    //Récupération de la date
                    DateTime mois = DateTime.Parse(valeurs[0]);

                    //Récupération des températures min et max
                    double tMin = double.Parse(valeurs[1]);
                    double tMax = double.Parse(valeurs[2]);

                    //Récupération de la date avec contrôle du type
                    DateTime moisTry;
                    if (!DateTime.TryParse(valeurs[0], out moisTry))
                        Console.WriteLine("Erreur date à la ligne {0}", l + 1);

                    //Récupération des températures min et max avec contrôle du type
                    double tMinTry;
                    if (!double.TryParse(valeurs[1], out tMinTry))
                        Console.WriteLine("Erreur température minimale à la ligne {0}", l + 1);

                    double tMaxTry;
                    if (!double.TryParse(valeurs[2], out tMaxTry))
                        Console.WriteLine("Erreur température maximal à la ligne {0}", l + 1);

                    //Syntaxe de gestion d'erreur, try/catch
                    try
                    {
                        moisTryCatch = DateTime.Parse(valeurs[0]);
                        tMinTryCatch = double.Parse(valeurs[1]);
                        tMaxTryCatch = double.Parse(valeurs[2]);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erreur de format à la ligne {0}", l + 1);
                    }
                    //Possibilité d'enchaîner les blocs catch avec de nouveaux type d'erreur
                    catch (Exception) // 'Exception' contrôle tous les types d'erreur
                    {
                        Console.WriteLine("Erreur à la ligne {0}", l + 1);
                    }

                    //Condition pour récupérer la valeur de la température la plus BASSE dans le fichier
                    if (tMin < tempMin)
                    {
                        tempMin = tMin;
                        moisTMin = mois;
                    }
                    //Condition pour récupérer la valeur de la température la plus HAUTE dans le fichier
                    if (tMax > tempMax)
                    {
                        tempMax = tMax;
                        moisTMax = mois;
                    }
                    Console.WriteLine("Le mois le plus froid : {0} avec {1}°C", moisTMin, tempMin);
                    Console.WriteLine("Le mois le plus chaud : {0} avec {1}°C", moisTMax, tempMax);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Erreur d'ouverture du fichier: {0}", chemin);
            }
            // Une erreur d'un try catch plus profond dans le programme peut remonter les blocs pour trouver son interception.
            try
            {

            }
            catch (Exception e)// e = information sur erreur/exception
            {

                throw; //Permet d'envoyer une alerte d'exception capturable par un catch
            }
            /*
             switch
                case 1:
                case 2:
                    code
                default:
                    throw new FileNotFoundException("Message d'erreur");
             */
            //Bloc Finally s'effectue peut importe ce qui se passe dans le bloc try
            try
            {
                //code à tester
            }
            finally
            {
                // s'effectue dans tous les cas 
            }
        }
    }
}

throw new Exception("erreur taille");
