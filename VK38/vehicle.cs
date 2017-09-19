using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK38
{
    class Vehicle
    {
        public string name;
        public int speed;
        public int tyres;
        public void PrintData()
        {
            Console.WriteLine(name);
            Console.WriteLine(speed);
            Console.WriteLine(tyres);

        }
        public string ToString()
        {

            return (String.Format("{0} {1} {2}", name, speed, tyres));

        }
    }

    class tiedot
    {
        public static void show()
        {
            Vehicle make = new Vehicle();
            int luku = 1;
            int valinta = new int();

            while (luku == 1)
            {
                Console.WriteLine("VEHICLE");
                Console.WriteLine("Paina 1 lisätäksesi uusi vehicle ");
                Console.WriteLine("Paina 2 näyttääksesi olevat vehiclet");
                Console.WriteLine("Paina 3 näytä merkkijono");
                Console.WriteLine("Paina 0 lopettaaksesi");
                valinta = int.Parse(Console.ReadLine());

                switch (valinta)
                {
                    case 0:
                        luku = 0;
                        break;

                    case 1:
                        Console.WriteLine("anna vehiclelle nimi ");
                        make.name = Console.ReadLine();
                        Console.WriteLine("anna vehiclelle nopeus ");
                        make.speed = int.Parse(Console.ReadLine());
                        Console.WriteLine("anna vehiclelle rengaskoko ");
                        make.tyres = int.Parse(Console.ReadLine());
                        make.ToString();

                        break;
                    case 2:
                        make.PrintData();
                        break;
                    case 3:
                        Console.WriteLine(make.ToString());
                        break;

                }
            }
        }
    }
}
