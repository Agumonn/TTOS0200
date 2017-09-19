using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPILASuusi
{
    class Oppilas
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ika { get; set; }
        public string Opiskelijanro { get; set; }
        public bool Lasna { get; set; }

        public Oppilas(string etunimi, string sukunimi, int ika, string opiskelijanro, bool lasna)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ika = ika;
            Opiskelijanro = opiskelijanro;
            Lasna = lasna;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelijat();
        }
        static void Opiskelijat()
        {
            List<Oppilas> lista = new List<Oppilas>();
            lista.Add(new Oppilas("TIMO", "VANHUS", 44, "A9999", true));
            lista.Add(new Oppilas("ELMERI", "RUUTI", 20, "b8888", true));
            lista.Add(new Oppilas("SEPPO", "KESKINEN", 52, "c7777", true));
            lista.Add(new Oppilas("SIIRI", "VILLAGEPEOPLEMAN", 22, "d8868", true));
            lista.Add(new Oppilas("SUPI", "ANDERSON", 23, "y8600", false));

            for (int x = 0; x < lista.Count; x++)
            {
                Console.WriteLine("Opiskelija " + (x + 1));
                Console.WriteLine("Etunimi: {0}, Sukunimi: {1}, ikä: {2}, opiskelijatunnus: {3}, läsnä: {4}.", lista[x].Etunimi, lista[x].Sukunimi, lista[x].Ika, lista[x].Opiskelijanro, lista[x].Lasna);
            }
        }

    }
}
