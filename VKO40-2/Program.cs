using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vene Yamaha = new Vene();
            Polkupyörä Shimano = new Polkupyörä();

            Yamaha.Nimi = "Yamaha";
            Yamaha.Malli = "SUperBoat";
            Yamaha.Vuosimalli = 2010;
            Yamaha.Väri = "Pinkki";
            Yamaha.SeatCount = 10;
            Yamaha.BoatType = "moottorivene";

            Shimano.Nimi = "SHIMANO";
            Shimano.Malli = " XX";
            Shimano.Vuosimalli = 2010;
            Shimano.Väri = "Sininen ";
            Shimano.Vaihde = false;
            Shimano.Vaihdemalli = "";

            Console.WriteLine(Yamaha.ToString());
            Console.WriteLine(Shimano.ToString());
        }
    }
}
