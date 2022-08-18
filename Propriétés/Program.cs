using System;

namespace Propriétés
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit figues = new Produit();
            // le prix est à défaut: 0
            figues.Price = 9.99M; //suffixe pour le décimal, sinon c'est un double et ca ne sera pas compaptible
            figues.Promo = 25;
            Console.WriteLine($"Le prix des figues est à {figues.Price} euros");
                //avec une promo de: {figues.Promo}");
        }
    }
}
