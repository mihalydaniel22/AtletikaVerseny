using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesület { get; private set; }
        public int Ugras { get; private set; }

        public Atleta(string a)
        {           
            Rajtszam = Convert.ToInt32(a[0]);
            VezNev = Convert.ToInt32(a[1]);
            KerNev = Convert.ToInt32(a[2])
            Egyesület = Convert.ToInt32(a[3]);
            Ugras = a[4];
        }
    }
}
