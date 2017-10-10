using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_1
{
    class Auto
    {

        public string Valmistaja { get; set; }
        public string Malli { get; set; }
        public Tyres[] Rengas { get; }
        private const int maxTyres = 4;
        private int countTyres = 0;

        public Auto(string valmistaja, string malli)
        {
            Rengas = new Tyres[maxTyres];
            Valmistaja = valmistaja;
            Malli = malli;
        }
        public void AddTyre(Tyres tyre)
        {
            if (countTyres < maxTyres)
            {
                Rengas[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("Rengas {0} asennettu autoon {1}", tyre.ToString(), this.Valmistaja);
            }
            else
            {
                Console.WriteLine("Ei voida asentaa");
            }
        }
        public override string ToString()
        {
            string retval = "Valmistaja: " + Valmistaja + " Malli: " + Malli + "\nTyres: ";
            foreach (Tyres tyre in Rengas)
            {
                if (tyre != null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            return retval;
        }
    }
}
