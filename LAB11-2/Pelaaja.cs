using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB11_2
{
    public class Pelaaja
    {
        public string Nimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }

        public Pelaaja()
        {
        }
        public Pelaaja(string nimi,string sukunimi, string pelipaikka, string kätisyys)
        {
            Nimi = nimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }
    }
    public class Joukkue
    {
        //public List<Pelaaja> pelaajat;
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            Joukkue JYP = new Joukkue();
            pelaajat.Add(new Pelaaja("Jarkko ", "Immonen ", "Hyökkääjä ", "Oikea"));
            pelaajat.Add(new Pelaaja("Antti ", "Suomela ", "Hyökkääjä ", "Vasen"));
            pelaajat.Add(new Pelaaja("Mikko ", "Mäenpää ", "Puolustaja ", "Vasen"));
            return pelaajat;
        }
    }
}
