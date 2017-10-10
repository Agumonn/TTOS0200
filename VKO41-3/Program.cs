using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Seura JYP = new Seura("JYP", "Jyväskylä\n");
            JYP.Pelaajat.Add(new Pelaaja("Jarkko ", "Immonen ", "Hyökkääjä ", "Oikea"));
            JYP.Pelaajat.Add(new Pelaaja("Antti ", "Suomela ", "Hyökkääjä ", "Vasen"));
            JYP.Pelaajat.Add(new Pelaaja("Mikko ", "Mäenpää ", "Puolustaja ", "Vasen"));
            Console.WriteLine(JYP.ToString());
        }
    }
}
