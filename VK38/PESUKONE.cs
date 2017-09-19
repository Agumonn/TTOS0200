using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK38
{
    class Pesukone
    {
        public bool virta;
        public bool hana;
        public bool paalle;
        public int ohjelma;
        public int linkous;
    }
    class toiminto
    {
        public static void pese()

        {

            Pesukone pese = new Pesukone();
            int luku = 1;
            int valinta = new int();

            while (luku == 1)
            {
                Console.WriteLine("PESUKONE");
                Console.WriteLine("Paina 1 Laittaaksesi virrat päälle ");
                Console.WriteLine("Paina 2 avataksesi hanan");
                Console.WriteLine("Paina 3 valitaksesi ohjelman");
                Console.WriteLine("Paina 4 valitaksesi linkouksen");
                Console.WriteLine("Paina 5 käynnistääksesi ohjelman");
                Console.WriteLine("Paina 0 lopettaaksesi");
                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {

                    case 0:
                        luku = 0;
                        break;

                    case 1:
                        if (pese.virta == false)
                        {
                            pese.virta = true;
                            Console.WriteLine("Virta päällä: {0}", pese.virta);
                        }
                        else if (pese.virta == true)
                        {
                            pese.virta = false;
                            Console.WriteLine("Virta päällä: {0}", pese.virta);
                        }
                        break;
                    case 2:
                        if (pese.hana == false)
                        {
                            pese.hana = true;
                            Console.WriteLine("Hana auki: {0}", pese.hana);
                        }
                        else if (pese.hana == true)
                        {
                            pese.hana = false;
                            Console.WriteLine("Hana auki: {0}", pese.hana);
                        }
                        break;

                    case 3:
                        if (pese.virta == true)
                        {
                            Console.WriteLine("Syötä haluttu ohjelmanro: ");
                            pese.ohjelma = int.Parse(Console.ReadLine());
                            Console.WriteLine("pesukone päällä: {0}", pese.virta);
                            Console.WriteLine("Hana auki: {0}", pese.hana);
                            Console.WriteLine("ohjelma nro: {0} valittu", pese.ohjelma);
                            Console.WriteLine("linkous {0} valittu", pese.linkous);


                        }
                        else
                        {
                            Console.WriteLine("pesukoneen pitää olla ensin päällä!");
                        }
                        break;
                    case 4:
                        if (pese.virta == true)
                        {
                            Console.WriteLine("Syötä haluttu linkous: ");
                            pese.linkous = int.Parse(Console.ReadLine());
                            Console.WriteLine("pesukone päällä: {0}", pese.virta);
                            Console.WriteLine("Hana auki: {0}", pese.hana);
                            Console.WriteLine("ohjelma nro: {0} valittu", pese.ohjelma);
                            Console.WriteLine("linkous {0} valittu", pese.linkous);

                        }
                        else
                        {
                            Console.WriteLine("pesukoneen pitää olla ensin päällä!");
                        }
                        break;
                    case 5:
                        if (pese.virta == true && pese.hana == true)
                        {
                            pese.paalle = true;
                            Console.WriteLine("pyykit peseytyy: {0} ", pese.paalle);
                            Console.WriteLine(" ");
                            Console.WriteLine(" ");
                            Console.WriteLine("pyykit pesty ");
                            pese.paalle = false;


                        }
                        else
                        {
                            Console.WriteLine("pesukoneen pitää olla ensin päällä ja hanan pitää olla auki");
                        }
                        break;
                }
            }
        }


    }
}
