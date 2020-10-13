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

        static void Beolvasas()
        {
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                versenyzok.Add(new Atleta(file.ReadLine()));
            }
            file.Close();
            Console.WriteLine("1.Feladat: Adatok beolvasása");
        }

        static void MasodikFeladat()
        {
            Console.WriteLine();
            Console.WriteLine("2.Feladat: Nevek és ugrások");
            foreach (var v in versenyzok)
            {
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Beolvasas();
            MasodikFeladat();

            Console.ReadKey();
        }
    }
}
