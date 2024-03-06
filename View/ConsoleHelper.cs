using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    public class ConsoleHelper
    {
        public static string GetNomClient()
        {
            string nom = ConsoleHelper.GetInputUser("Entrer Nom :");
            return nom;
        }

        public static string GetPrenomClient()
        {
            string prenom = ConsoleHelper.GetInputUser("Entrer Prénom :");
            return prenom;
        }

        public static DateOnly GetDDNClient()
        {
            string ddn = ConsoleHelper.GetInputUser("Entrer Date de naissance :");
            return DateOnly.Parse(ddn);
        }
        public static string GetAdresseClient()
        {
            string adresse = ConsoleHelper.GetInputUser("Entrer Adresse :");
            return adresse;
        }
        public static string GetCPClient()
        {
            string cp = ConsoleHelper.GetInputUser("Entrer Code postal :");
            return cp;
        }
        public static string GetVilleClient()
        {
            string ville = ConsoleHelper.GetInputUser("Entrer Ville :");
            return ville;
        }

        //méthode permettant de récupérer un entier saisi par l'utilisateur
        public static int GetInputIntUser(string question)
        {
            string input = GetInputUser(question);
            int result;
            while (!int.TryParse(input, out result))
            {
                Console.WriteLine("error retry");
                input = GetInputUser(question);
            }
            return result;
        }



        //méthode permettant de récupérer un string saisi par l'utilisateur
        public static string GetInputUser(string question)
        {
            Console.WriteLine(question);
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Error retry ! ");
                input = Console.ReadLine();
            }
            return input;

        }

        public static void LancerMenu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1 - Ajouter un client");
            Console.WriteLine("2 - Afficher la liste des clients");
            Console.WriteLine("3 - Afficher un client en rentrant son ID");
            Console.WriteLine("4 - Supprimer un client en rentrant son ID");
            Console.WriteLine("5 - Mettre à jour un client en rentrant son ID et la donnée à modifier");
            Console.WriteLine("------------------------------------");
        }
    }

}

