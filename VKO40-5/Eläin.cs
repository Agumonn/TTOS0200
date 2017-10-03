using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_5
{
    public class Eläin
    {
        public string Nimi { get; set; }
        public int Ikä { get; set; }
        public string Sukupuoli { get; set; }
        public string Rotu { get; set; }
        public string Väri { get; set; }
        public int Paino { get; set; }
        public string Ääni { get; set; }

        public override string ToString()
        {
            return " Nimi: " + Nimi + " Ikä: " + Ikä + " Sukupuoli: " + Sukupuoli + " Rotu: " + Rotu + " Väri: " + Väri + " Paino: " + Paino + " Ääni: " + Ääni;
        }


    }
    public class Kissa :Eläin
    {
        public int Hännänpituus { get; set; }
        public int Tassunkoko { get; set; }
        public override string ToString()
        {
            return " Hännänpituus: " + Hännänpituus + " Tassunkoko: " + Tassunkoko;
        }
    }
    public class Koira : Eläin
    {
        public int Hännänpituus { get; set; }
        public int Tassunkoko { get; set; }
        public override string ToString()
        {
            return " Hännänpituus: " + Hännänpituus + " Tassunkoko: " + Tassunkoko;
        }


    }
    public class Elefantti : Eläin
    {
        public int Kärsänpituus { get; set; }
        public int Hännänpituus { get; set; }
        public override string ToString()
        {
            return " Kärsänpituus: " + Kärsänpituus + " Hännänpituus: " + Hännänpituus;
        }


    }

}
