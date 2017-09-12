using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".


namespace TEHTAVAT1
{
    class Task4
    {
        public static void TASK4()
        {
            int ika;
            Console.Write("Anna ikä > ");
            ika = int.Parse(Console.ReadLine());
            if (ika >= 0 && ika<=17)
            {
                Console.WriteLine("olet alaikäinen");
            }
            if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("olet aikuinen");
            }
            if (ika >=66)
            {
                Console.WriteLine("olet seniori");
            }
        }
    }
}
