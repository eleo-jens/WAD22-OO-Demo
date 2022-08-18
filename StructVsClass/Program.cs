using System;

namespace StructVsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartphoneStruct smartS = default; // obtient une instance de la structure
            SmartphoneClass smartC = default; // obtient null par défaut

            smartC = new SmartphoneClass(); // on obtient une instance de classe à l'aide d'un new
            smartS = new SmartphoneStruct(); // on obtient une instance de la structure à l'aide d'un new

            Console.WriteLine($"Struct : {smartS}");
            Console.WriteLine($"Struct : {smartC}");

            smartS.marque = "Motorola";
            smartS.modele = "G9+";
            smartS.serialNumber = "123456";
            smartS.pixelHeight = 1280;
            smartS.pixelWidth = 640;

            smartC.marque = "Samsung";
            smartC.modele = "Galaxy S20";
            smartC.serialNumber = "987654321";
            smartC.pixelHeight = 2960;
            smartC.pixelWidth = 1440;

            SmartphoneStruct smartMaya = smartS;
            SmartphoneStruct smartAless = smartMaya;

            smartAless.serialNumber = "abcdefji";

            Console.WriteLine($"smartMaya: {smartMaya.serialNumber} - smartAless : {smartAless.serialNumber}"); // sont différents
            // si smartMaya et smartAless avaient été de type SmartphoneClass, on aurait eu des informations identiques; il faut donc créer des instances de classes, pour avoir des téléphones différents




        }
    }
}
