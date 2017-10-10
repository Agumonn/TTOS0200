using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_1
{
    class Tyres
    {

        public string Valmistaja { get; set; }
        public string Merkki { get; set; }
        public string Koko { get; set; }

        public Tyres(string valmistaja, string merkki, string koko)
        {
            Valmistaja = valmistaja;
            Merkki = merkki;
            Koko = koko;
        }
        public override string ToString()
        {
            return String.Format("Valmistaja: {0} Merkki: {1}, Koko: {2}", Valmistaja, Merkki, Koko);
        }
    }
}
