using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron):
namespace TEHTAVAT1
{
    class Task2
    {
        public static void TASK2()
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            if (luku == 0 | luku==1)
            {
                Console.WriteLine("Arvosanasi on 0");
            }
            if (luku == 2 | luku == 3)
            {
                Console.WriteLine("Arvosanasi on 1");
            }
            if (luku == 4 | luku == 5)
            {
                Console.WriteLine("Arvosanasi on 2");
            }
            if (luku == 6 | luku == 7)
            {
                Console.WriteLine("Arvosanasi on 3");
            }
            if (luku == 8 | luku == 9)
            {
                Console.WriteLine("Arvosanasi on 4");
            }
            if (luku >= 10 && luku < 13)
            {
                Console.WriteLine("Arvosanasi on 5");
            }
        }
    }
}
