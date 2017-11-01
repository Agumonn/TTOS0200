using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VKO44_3
{
    class Numbers
    {
        #region Properties
        public List<int> Int { get; set; }
        public List<double> Double { get; set; }
        private string pathint = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\intTxt.txt";
        private string pathdouble = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\doubleTxt.txt";

        #endregion

        #region Methods
        //Luodaan numeroille listat
        public Numbers()
        {
            Int = new List<int>();
            Double = new List<double>();

        }

        //syötteen lukeminen
        public void Inputs()
        {
            bool Inputcorrect = true;
            double result;
            while (Inputcorrect)
            {
                Console.WriteLine("Syötä kokonais- tai desimaaliluku. Jos syöttö on jotain muuta, ohjelma suljetaan");
                if (double.TryParse(Console.ReadLine(), out result))
                {
                    if ((result % 1) == 0)//tarkistetaan onko luku kokonaisluku jos on lisätää
                    {
                        Int.Add(Convert.ToInt32(result));
                    }
                    else
                    {
                        Double.Add(result);
                    }
                }
                else
                {
                    Inputcorrect = false;
                }
            }
        }

        //tiedostoon kirjoittaminen
        public void AddToTxt()
        {
            try
            {
                using (StreamWriter sw = File.AppendText(pathint))//kokonaislukujen lisäys tiedostoon
                {
                    foreach (int i in Int)
                    {
                        sw.WriteLine(i);
                    }
                    Console.WriteLine("Lisätty kokonaisluvut {0}", pathint);
                };
                using (StreamWriter sw = File.AppendText(pathdouble))//liukulukujen lisäys
                {
                    foreach (double d in Double)
                    {
                        sw.WriteLine(d);
                    }
                    Console.WriteLine("Lisätty desimaaliluvut {0}", pathdouble);
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //tiedoston lukeminen
        public void ReadTxt()
        {
            try
            {
                using (StreamReader sr = File.OpenText(pathint))//kokonaislukujen lukeminen
                {
                    string s = " ";
                    Console.WriteLine("Contents of int.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                using (StreamReader sr = File.OpenText(pathdouble))//liukulukujen lukeminen
                {
                    string s = " ";
                    Console.WriteLine("Contents of double.txt: ");
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
        #endregion
    }
}
