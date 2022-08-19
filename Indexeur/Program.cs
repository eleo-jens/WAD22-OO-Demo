﻿using System;

namespace Indexeur
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie sw = new Movie();
            sw.Title = "Star Wars";

            Actor mh = new Actor();
            mh.LastName = "Hammil";
            mh.FirstName = "Mark";

            Actor hf = new Actor();
            hf.LastName = "Ford";
            hf.FirstName = "Harrisson";

            sw["Han Solo"] = hf; // l'index est sur le film
            sw["Luke Skywalker"] = mh;

            Console.WriteLine($"Han Solo est joué par: {sw["Han Solo"].FirstName} {sw["Han Solo"].LastName}");
            Console.WriteLine($"Luke Skywalker est joué par: {sw["Luke Skywalker"].FirstName} {sw["Luke Skywalker"].LastName}");
            //Console.WriteLine($"Chewbaka est joué par: {sw["Chewbaka"].FirstName} {sw["Chewbaka"].LastName}");

        }
    }
}
