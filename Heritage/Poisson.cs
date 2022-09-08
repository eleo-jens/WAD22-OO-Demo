using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Poisson : Animal
    {
        public bool EstDEauDouce { get; set; }
        public double Longueur { get; set; }
        public void Nager()
        {
            Console.WriteLine("Je nage !");
        }

        // rédéfinition des méthodes
        public override void SePresenter()
        {
            Console.WriteLine($"Je suis un poisson qui s'appelle {Nom}.");
        }
    }
}
