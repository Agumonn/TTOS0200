using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kisu = new Kissa();
            Koira doge = new Koira();
            Elefantti möhkö = new Elefantti();


            kisu.Nimi = "kisu";
            kisu.Ikä = 11;
            kisu.Paino = 20;
            kisu.Rotu = "maatiaiskissa";
            kisu.Hännänpituus = 30;
            kisu.Sukupuoli = "naaras";
            kisu.Tassunkoko = 14;
            kisu.Väri = "musta";
            kisu.Ääni = "Miau";


            doge.Nimi = "BENI";
            doge.Ikä = 11;
            doge.Paino = 50;
            doge.Rotu = "BÉRNARDI";
            doge.Hännänpituus = 30;
            doge.Sukupuoli = "boiii";
            doge.Tassunkoko = 14;
            doge.Väri = "musta";
            doge.Ääni = "vuhvuhv";

            möhkö.Nimi = "Möhköfantti";
            möhkö.Ikä = 20;
            möhkö.Paino = 2000;
            möhkö.Rotu = "AFrikan norsu";
            möhkö.Hännänpituus = 30;
            möhkö.Sukupuoli = "naaras";
            möhkö.Kärsänpituus = 14;
            möhkö.Väri = "harmaa";
            möhkö.Ääni = "tuut";

            Console.WriteLine(kisu.ToString());
            Console.WriteLine(doge.ToString());
            Console.WriteLine(möhkö.ToString());


        }
    }
}
