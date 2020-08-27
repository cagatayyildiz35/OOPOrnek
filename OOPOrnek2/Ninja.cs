using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOrnek2
{
    class Ninja : Karakter
    {
        public string KilicTur { get; set; }

        public string Memleket { get; set; }


        public void KilicSalla()
        {
            //
        }


        public override string Hoscakal()
        {
            return "Behlül kaçar...";
        }
    }
}
