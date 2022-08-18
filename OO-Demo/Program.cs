using System;
using S = OO_Demo.Structs; 

namespace OO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            OO_Demo.Structs.ConsoleAvancee ca; //evite de mettre using OO-Demo;
            S.ConsoleAvancee ca; // autre façon de l'écrire pour raccourcir quand on aura plusieurs objets qui porteront le meme nom
            KeyMapping km;
        }
    }
}
