using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO44_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //KÄYTTÄKÄÄ AINA TRY-CATCHIA
            try
            {
                string nimi;
                string filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string file = filepath + @"\testi.txt";
                //kirjoitetaan käyttäjän antamat rivit tiedostoon
                //luodaan StreamWriter tyyppinen olio johon kirjoitetaan
                StreamWriter sw = new StreamWriter(file);
                do
                {
                    Console.Write("Anna nimi (Tyhjä rivi lopettaa kirjoittamisen):");
                    nimi = Console.ReadLine();
                    if (nimi.Length > 0)
                    {
                        sw.WriteLine(nimi);
                    }
                } while (nimi.Length != 0);
                sw.Close();
                //avataan tiedosto uudestaan ja luetaan sisältö
                if (File.Exists(file))
                {
                    string teksti = File.ReadAllText(file);
                    Console.WriteLine(teksti);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
