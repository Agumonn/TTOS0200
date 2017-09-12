using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
namespace TEHTAVAT1
{
    class Task8
    {
        public static void TASK8()
        {
            int luku1;
            int luku2;
            int luku3;
            Console.Write("Anna ensimmäinen luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna toinen luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna kolmas luku > ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2)
            {
                if (luku1 > luku3)
                {
                    Console.Write("Suurin luku oli ensimmäinen antamasi luku > " + luku1);

                }
                else
                {
                    Console.Write("Suurin luku oli kolmas antamasi luku > " + luku3);
                }

            }
            else if (luku2 > luku3)
            {
                Console.Write("Suurin luku oli toinen antamasi luku > " + luku2);

            }

        }
    }
}
