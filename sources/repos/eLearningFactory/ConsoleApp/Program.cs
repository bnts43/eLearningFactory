using Core.Facade;
using Core.Model;
using Stub;
using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Création de la facade");
            FacadeApplication facade = new FacadeApplication();

            //Inscription d'un utilisateur
            if (facade.SInscrire("Marley", "Bob", "bobmarley@gmail.com", "bob"))
            {
                WriteLine("Inscription de Bob Marley réussie");
            }
            else
            {
                WriteLine("Impossible de s'inscrire. Cette adresse email est déjà utilisée");
            }


            // chargement des données depuis le stub

            IDataManager stubDataLoad = new StubDataManager();

            facade.ChargerListeUtilisateurs(stubDataLoad.ChargerUtilisateur());
            WriteLine("Chargement de la liste utilisateurs OK");
            facade.ChargerListeCours(stubDataLoad.ChargerCours());
            WriteLine("Chargement de la liste cours OK");
            //Connexion d'un utilisateur

            if (facade.SeConnecter(new Etudiant("neuts", "benoit", "b_neuts@orange.fr", "1234"))!= null)
            {
                WriteLine("Connexion réussie");
            }
            else
            {
                WriteLine("Utilisateur non reconnu");
            }

            // TODO Bob Marley a suivi un cours

            Console.ReadLine();

        }
    }
}
