using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Ohjastaja
    {
        public string Nimi;
        public int Startti;
        public int Voitot;
        public float Voittopros;

    }
    class Program
    {
        static void LueOhjastajatVer2()
        {
            try
            {

                //luetaan CSV-tiedostosta tiedot ja tallennetaan structeihin
                string erotin = ";";
                //luetaan kaikki rivit muuttujaan
                string[] rivit = System.IO.File.ReadAllLines(@"D:\K8522\tilasto2017.csv");
                Ohjastaja kuski;
                int lkm = rivit.Length;
                Console.WriteLine("Ohjastajia yhteensä {0}", lkm - 1);

                for (int i = 0; i < lkm; i++)
                {
                    string[] sanat = rivit[i].Split(erotin.ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                    kuski.Nimi = sanat[0] + " " + sanat[i];
                    kuski.Startti = int.Parse(sanat[2]);
                    kuski.Voitot = int.Parse(sanat[3]);
                    kuski.Voittopros = (100F * kuski.Voitot / kuski.Startti);
                    Console.WriteLine("{0}: {1} startit {2} voitot {3} voittoprosentti {4}", i, kuski.Nimi, kuski.Startti, kuski.Voitot, kuski.Voittopros);
                }
                Console.WriteLine("end");

            }
            catch (Exception)
            {
                throw;
            }

        }
        static void LueOhjastajatVer1()
        {
            try
            {


            }
            catch (Exception)
            {
                throw;
            }

        }
        static void Main(string[] args)
        {
            try
            {
                LueOhjastajatVer2();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
