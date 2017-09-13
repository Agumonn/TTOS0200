using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Kirjoita ohjelma, joka pyytää käyttäjältä opiskelijoiden arvosanat 0-5 ohjelmointi-opintojaksosta (voit itse päättää lopetusehdon). Tulosta arvosanajakauma käyttäen tähtimerkkejä seuraavasti:


namespace TEHTAVAT1
{
    class Task14
    {

            public static void TASK14()
            {
                List<int> luvut = new List<int>();

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Anna arvosana > ");
                    int luku = int.Parse(Console.ReadLine());
                    luvut.Add(luku);
                }

                Console.WriteLine("Arvosanat:");

                for (int i = 0; i <= 5; i++)
                {
                    Console.Write(i + ":");
                    for (int j = 0; j < luvut.Count; j++)
                    {
                        if (luvut[j] == i)
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }

    }
}
