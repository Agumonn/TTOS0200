using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
namespace TEHTAVAT1
{
    class Task7
    {
        public static void TASK7()
            {
            int luku;

            Console.Write("Anna vuosi > ");
            luku = int.Parse(Console.ReadLine());


            if (luku % 4 > 0)
            {
                Console.Write("Vuosi ei ole karkausvuosi.");

            }
            if (luku % 4 ==0 )
            {
                
                if (luku % 100 == 0)
                {
                    if (luku % 400==0)
                        {
                            Console.Write("Vuosi on karkausvuosi.");

                        }
                    else
                    {
                        Console.Write("Vuosi ei ole karkausvuosi.");

                    }
                    

                }
                else
                {
                    Console.Write("Vuosi on karkausvuosi.");
                }
                

            }
        }
    }
}
