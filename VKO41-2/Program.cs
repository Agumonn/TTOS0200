using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fridge UPO = new Fridge();
            UPO.OpenDoor();
            Items tavara1 = new Items("Maito", "Ovessa");
            Items tavara2 = new Items("Makkara", "ylähylly");
            Items tavara3 = new Items("Olut" , "Alahylly");
            Items tavara4 = new Items("Olut", "Alahylly");
            Items tavara5 = new Items("Olut", "Alahylly");
            Items tavara6 = new Items("Olut", "Alahylly");

            UPO.AddItems(tavara1);
            UPO.AddItems(tavara2);
            //UPO.AddItems(tavara3);
            UPO.AddItems(tavara4);
            UPO.AddItems(tavara5);
            UPO.AddItems(tavara6);

            Console.WriteLine(UPO.ToString());
        }
    }
}
