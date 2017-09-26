using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO39_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi();

            do
            {

                Console.WriteLine("Syötä kerros.");
                string sisaantulo = Console.ReadLine();
                int luku;
                bool valinta = int.TryParse(sisaantulo, out luku);

                if (valinta)
                {
                    hissi.Kerros = luku;
                }
                else
                {
                    break;
                }


                Console.WriteLine("{0} kerros ", hissi.Kerros);

            }
            while (true);
        }
    }
}
