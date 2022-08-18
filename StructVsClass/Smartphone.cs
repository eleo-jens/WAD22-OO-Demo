using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVsClass
{
    class SmartphoneClass
    {
        public string marque;
        public string modele;
        public string serialNumber;
        public int pixelWidth;
        public int pixelHeight;
    }

    struct SmartphoneStruct
    {
        public string marque;
        public string modele;
        public string serialNumber;
        public int pixelWidth;
        public int pixelHeight;
    }
}
