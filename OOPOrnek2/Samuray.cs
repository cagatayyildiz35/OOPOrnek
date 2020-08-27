using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    class Samuray : Karakter
    {
        public string YildizCesit { get; set; }

        public string YildizAt(string x)
        {
            return "Koru kendini!! çünkü " + x + " yıldızı attım.";
        }
    }
}
