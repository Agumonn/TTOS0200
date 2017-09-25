using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 1
//
//Tee ohjelma, joka tulostaa käyttäjän antamaa lukua(1, 2 tai 3) vastaavan luvun sanana(yksi, kaksi tai kolme). Jos käyttäjä syöttää jonkin muun luvun, tulee näytölle tulostaa teksti: "joku muu luku".
//

namespace TEHTAVAT1
{
    class Task1
    {
        public static void TASK1 ()
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            if(luku ==1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            if (luku == 0 | luku > 3)
            {
                Console.WriteLine("Annoit jonkun muun luvun");
            }
        }
    }
}
