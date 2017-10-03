using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Radio matkaradio = new Radio();


            {
                Console.WriteLine("Tervetuloa radioon.");
                Console.WriteLine("Paina 1 kytkeäksesi radion päälle");

                int luku = int.Parse(Console.ReadLine());
                if (luku == 1)
                {
                    matkaradio.Power = true;
                    Console.WriteLine("Radio päällä");

                }
                else
                {
                    Console.WriteLine("Kytke radio päälle painamalla 1");
                }

                if (matkaradio.Power == true)
                {

                    Console.WriteLine("Syötä taajuus (2KHz-26KHz) ");
                    matkaradio.Frequency = int.Parse(Console.ReadLine());

                }
                if (matkaradio.Power == true)
                {
                    Console.WriteLine("Syötä Äänenvoimakkuus (0-9) ");

                    matkaradio.Volume = int.Parse(Console.ReadLine());

                }
                Console.WriteLine(matkaradio.ToString());


            }
        }
    }
}
