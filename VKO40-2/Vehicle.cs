using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_2
{

        public class Vehicle
        {
            public string Nimi { get; set; }
            public string Malli { get; set; }
            public string Väri { get; set; }
            public int Vuosimalli { get; set; }


        public override string ToString()
            {
                return "Nimi: " + Nimi + " Malli: " + Malli + " Väri: " + Väri + " Vuosimalli: " + Vuosimalli + " ";
            }


        }
        public class Polkupyörä : Vehicle
        {
            public bool Vaihde { get; set; }

            public string Vaihdemalli { get; set; }

            public override string ToString()
            {
                return base.ToString() + "Vaihteet: " + Vaihde + " Vaihdemalli: " + Vaihdemalli + "\n";
            }

        }
        public class Vene : Vehicle
        {
            public int SeatCount { get; set; }

            public string BoatType { get; set; }

            public override string ToString()
            {
                return base.ToString() + "Penkkien lkm: " + SeatCount + " Venetyyppi: " + BoatType + "\n";
            }

        }

}
