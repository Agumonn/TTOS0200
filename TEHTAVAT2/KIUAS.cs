using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEHTAVAT2
{
    class KIUAS
    {

        public bool on;
        public int temp;
        public int kosteus;


    }

    class kiuas
    {
        public static void KIUAS()

        {

            KIUAS kiuas = new KIUAS();
            int luku = 1;
            int valinta = new int();

            while (luku==1)
            {

                Console.WriteLine("KIUAS");
                Console.WriteLine("Paina 1 käynnistääksesi/sammuttaaksesi kiukaan ");
                Console.WriteLine("Paina 2 muuttaaksesi kosteutta");
                Console.WriteLine("Paina 3 muuttaaksesi lämpötilaa");
                Console.WriteLine("Paina 0 lopettaaksesi");
                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {

                    case 0:
                        luku = 0;
                        break;

                    case 1:
                        if (kiuas.on == false)
                        {
                            kiuas.on = true;
                            Console.WriteLine("Kiuas päällä: {0}", kiuas.on);
                        }
                        else if (kiuas.on == true)
                        {
                            kiuas.on = false;
                            Console.WriteLine("Kiuas päällä: {0}", kiuas.on);
                        }
                        break;
                    case 2:
                        if (kiuas.on == true)
                        {

                            Console.WriteLine("Anna haluttu kosteustaso: ");

                            kiuas.kosteus = int.Parse(Console.ReadLine());

                            Console.WriteLine("Kiuas päällä: {0}", kiuas.on);
                            Console.WriteLine("Saunan kosteustaso on nyt: {0}%", kiuas.kosteus);
                            Console.WriteLine("Saunan lämpötila on nyt: {0} astetta", kiuas.temp);


                            break;
                        }
                        else
                        {
                            Console.WriteLine("Kiukaan pitää olla ensin päällä!");
                        }
                        break;

                    case 3:
                        if (kiuas.on == true)
                        {
                            Console.WriteLine("Syötä haluttu lämpötila: ");
                            kiuas.temp = int.Parse(Console.ReadLine());
                            Console.WriteLine("Kiuas päällä: {0}", kiuas.on);
                            Console.WriteLine("Saunan kosteustaso on nyt: {0}%", kiuas.kosteus);
                            Console.WriteLine("Saunan lämpötila on nyt: {0} astetta", kiuas.temp);

                        }
                        else
                        {
                            Console.WriteLine("Kiukaan pitää olla ensin päällä!");
                        }
                        break;
                }
            }

        }
    }
}
