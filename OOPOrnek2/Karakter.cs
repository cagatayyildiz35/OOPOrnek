using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    class Karakter
    {
        public string Ad{ get; set; }


        public string Merhaba()
        {
            return "Merhaba! Oyuna hazır mısın? ";
        }

        public virtual string Hoscakal()
        {
            return "Hoşçakal";
        }
    }
}
