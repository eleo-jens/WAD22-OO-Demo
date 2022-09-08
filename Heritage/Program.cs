using System;

namespace Heritage
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dinosaure = new Animal();
            dinosaure.Nom = "Rexy";

            Oiseau canari = new Oiseau();
            canari.Nom = "Titi";
            canari.Couleur = "Jaune";
            canari.EstDomestique = true;
            canari.DateNaissance = new DateTime(1942, 1, 1);
            canari.Alimentation = "Graines et vers de terre";
            canari.LongueurBec = 13.5;
            canari.TaillePlumage = 45;
            canari.SePresenter();
            canari.Voler();

            Poisson clown = new Poisson();
            clown.Nom = "Némo";
            clown.Couleur = "Orange";
            clown.EstDomestique = false;
            clown.DateNaissance = new DateTime(2001, 1, 1);
            clown.Alimentation = "Placton";
            clown.EstDEauDouce = false;
            clown.Longueur = 32;
            clown.SePresenter();
            clown.Nager();

        }
    }
}
