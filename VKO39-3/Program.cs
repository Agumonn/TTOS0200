using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO39_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();

            do
            {

                Console.WriteLine("Give a new volume value (0-100) > ");
                string sisaantulo = Console.ReadLine();
                int luku;
                bool valinta = int.TryParse(sisaantulo, out luku);

                if (valinta)
                {
                    
                    vahvistin.Volume = luku;
                }
                else
                {
                    break;
                }


                Console.WriteLine(" -> Amplifier volume is set to : {0}", vahvistin.Volume);

            }
            while (true);
        }
    }
}
