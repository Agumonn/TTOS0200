using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
namespace TEHTAVAT1
{
    class Task5
    {
        public static void TASK5()

        {
            int luku;
            int tunti;
            int minute;
            int second;
            int jaannos;



            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            tunti = luku / 3600;
            jaannos = luku % 3600;
            minute = jaannos / 60;
            second = minute % 60;

            Console.Write("Tunteja  " + tunti + " minuutteja " + minute + " sekunteja " + second);







        }
        }
}
