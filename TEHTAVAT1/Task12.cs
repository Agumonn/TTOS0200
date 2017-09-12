using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka kysyy käyttäjältä 5 kokonaislukua. Luvut tulee sijoittaa taulukkoon. Ohjelman tulee tulostaa annetut luvut käänteisessä järjestyksessä.
namespace TEHTAVAT1
{
    class Task12
    {
        public static void TASK12()
        {
            int[] luvut = new int[5] ;

            int luku;
            
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                luvut[0 + i] = luku;

            }
            Console.WriteLine("Antamasi luvut oli");
            Array.Reverse(luvut);

            for (int i = 0; i < luvut.Length; i++)
            {
                Console.WriteLine(luvut[i]);
            }

        }
    }
}
