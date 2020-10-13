using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }

        public Atleta(string sor)
        {
            string[] a = sor.Split(';');
            Rajtszam = a[0];
            VezNev = a[1];
            KerNev = a[1];
            Egyesulet = a[2];
            Ugras = Convert.ToInt32(a[3]);
        }
        public string Nev(string nev)
        {
            string[] b = nev.Split(' ');
            VezNev = b[0];
            KerNev = b[1];
            return nev;
        }
    }
}
