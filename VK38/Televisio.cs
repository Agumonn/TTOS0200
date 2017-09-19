using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK38
{
    class televisio
    {
        public bool power;
        public int channel;
        public int volume;
    }
    class katsele
    {
        public static void telkku()

        {

            televisio telkku = new televisio();
            int luku = 1;
            int valinta = new int();

            while (luku == 1)
            {
                Console.WriteLine("TElkkari");
                Console.WriteLine("Paina 1 Laittaaksesi virrat päälle ");
                Console.WriteLine("Paina 2 valitaksesi kanavan");
                Console.WriteLine("Paina 3 vaihtaaksesi volumea");
                Console.WriteLine("Paina 0 sammuttaaksesi");
                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {

                    case 0:
                        luku = 0;
                        break;

                    case 1:
                        if (telkku.power == false)
                        {
                            telkku.power = true;
                            Console.WriteLine("Virta päällä: {0}", telkku.power);
                        }
                        else if (telkku.power == true)
                        {
                            telkku.power = false;
                            Console.WriteLine("Virta päällä: {0}", telkku.power);
                        }
                        break;
                    case 2:
                        if (telkku.power == true)
                        {

                            Console.WriteLine("Anna haluttu kanava: ");

                            telkku.channel = int.Parse(Console.ReadLine());

                            Console.WriteLine("virta päällä: {0}", telkku.power);
                            Console.WriteLine("kanava on nyt: {0}", telkku.channel);
                            Console.WriteLine("äänen voimakkuus on nyt: {0} ", telkku.volume);


                            break;
                        }
                        else
                        {
                            Console.WriteLine("Television pitää olla ensin päällä!");
                        }
                        break;

                    case 3:
                        if (telkku.power == true)
                        {

                            Console.WriteLine("Anna haluttu äänenvoimakkuus: ");

                            telkku.volume = int.Parse(Console.ReadLine());

                            Console.WriteLine("virta päällä: {0}", telkku.power);
                            Console.WriteLine("kanava on nyt: {0}", telkku.channel);
                            Console.WriteLine("äänen voimakkuus on nyt: {0} ", telkku.volume);


                            break;
                        }
                        else
                        {
                            Console.WriteLine("Television pitää olla ensin päällä!");
                        }
                        break;
                }
            }
        }
    }
}
