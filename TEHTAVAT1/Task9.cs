using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
namespace TEHTAVAT1
{
    class Task9
    {
        public static void TASK9()
        {
            int luku;
            int summa = 0;
            for (int i = 0;  ; )
            {


                Console.Write("Anna luku > ");
                luku = int.Parse(Console.ReadLine());
                if (luku == 0)
                {
                    Console.Write("Lukujen summa on" + summa);
                    break;
                }
                else
                {
                    summa += luku;
                }


            }
        }
    }
}
