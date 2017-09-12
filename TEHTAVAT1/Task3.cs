using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
namespace TEHTAVAT1
{
    class Task3
    {
        public static void TASK3()
        {
            int luku1;
            int luku2;
            int luku3;
            int summa;
            int average;
            Console.Write("Anna ensimmäinen luku > ");
            luku1 = int.Parse(Console.ReadLine());
            Console.Write("Anna ensimmäinen luku > ");
            luku2 = int.Parse(Console.ReadLine());
            Console.Write("Anna ensimmäinen luku > ");
            luku3 = int.Parse(Console.ReadLine());
            summa = luku1 + luku2 + luku3;
            Console.Write("Lukujen summa on > {0}",summa);
            average= summa/3;
            Console.Write("Lukujen keskiarvo on > {0}", average);


        }
    }
}
