﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage
{
    class Oiseau : Animal
    {
        public double LongueurBec { get; set; }
        public double TaillePlumage { get; set; }
        public void Voler()
        {
            Console.WriteLine("Je vole !");
        }

        public new void SePresenter()
        {
            Console.WriteLine($"Cuicui! Je suis un oiseau. Appelez-moi {Nom}.");
        }
    }
}
