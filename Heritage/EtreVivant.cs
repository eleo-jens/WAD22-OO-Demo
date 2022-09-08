using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class EtreVivant
    {
        public string Nom { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Couleur { get; set; }
        public virtual void SePresenter()
        {
            Console.WriteLine($"Bonjour, je suis {Nom} !");
        }
    }
}
