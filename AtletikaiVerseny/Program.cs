using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> versenyzok = new List<Atleta>();

        public void Beolvasas()
        {
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                versenyzok.Add(Console.ReadLine(file));
            }
            file.Close();
        }

        static void Main(string[] args)
        {
            Beolvasas();
            Console.ReadKey();
        }
    }
}
