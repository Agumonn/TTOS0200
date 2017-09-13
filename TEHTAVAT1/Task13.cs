using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Mäkihypyssä käytetään viittä arvostelutuomaria. Kirjoita ohjelma, joka kysyy arvostelupisteet yhdelle hypylle ja tulostaa tyylipisteiden summan siten, että summasta on vähennetty pois pienin ja suurin tyylipiste.


namespace TEHTAVAT1
{
    class Task13
    {

            public static void TASK13()
            {
                int[] luvut = new int[5];

                int summa = 0;

                for (int i = 0; i < luvut.Length; i++)
                {
                    Console.Write("Anna pisteet > ");
                    luvut[i] = int.Parse(Console.ReadLine());
                    summa = summa + luvut[i];
                }

                summa = summa - (luvut.Max() + luvut.Min());
                Console.WriteLine("Pisteet ovat {0}", summa);
            }

    }
}
