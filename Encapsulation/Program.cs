using Encapsulation.Security;
using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User(); // necessite using Encapsulation.Security;
            // new va donner les valeurs par défaut aux variables

            user.login = "SamBstorm";
            user.SetPassword("Test12345=");
            string login;
            string password = null; // revient au meme que ligne 15
            int tries = 3;
            do
            {
                Console.WriteLine("Veuillez indiquer votre login: ");
                login = Console.ReadLine();

                Console.WriteLine("Veuillez indiquer votre mot de passe: ");
                password = Console.ReadLine();
                tries--;
                
            } while (!user.CheckUser(login, password) && tries != 0);

            if (user.CheckUser(login, password))
                Console.WriteLine($"Bienvenu {user.login}");
            else
                Console.WriteLine("Trop d'essais");
        }
    }
}
