using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka alustaa sovellukseen käyttöö seuraavan taulukon arvot = [1,2,33,44,55,68,77,96,100]. Käy sovelluksessa taulukko läpi ja tulosta ruutuun "HEP"-sana aina kun taulukossa oleva luku on parillinen.
namespace TEHTAVAT1
{
    class Task10
    {
        public static void TASK10()
        {
            int[] luvut = new int[9] { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for (int i = 0; i < 9; i++)
            {
                if (luvut[i] % 2 == 0)
                {
                    Console.Write(" HEP ");
                }
                else
                {
                    Console.Write(" NJET ");
                }
                

            }
           

        }
    }
}
