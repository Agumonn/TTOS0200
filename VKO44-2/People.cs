using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO44_2
{
    class People
    {

        #region PROPERTIES
        public List<string> Nimet { get; set; }
        private string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\names.txt";

        #endregion

        public People()
        {
            Nimet = new List<string>();
            try
            {
                if (!File.Exists(path))//jos tiedostoa ei ole
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Aappo");
                        sw.WriteLine("Benkku");
                        sw.WriteLine("Benkku");
                        sw.WriteLine("Jaakko");
                        sw.WriteLine("Jaakko");
                        sw.WriteLine("Jaakko");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Wille");
                        sw.WriteLine("Sebastian");
                        sw.WriteLine("Cecilia");
                        sw.WriteLine("Cecilia");
                        sw.WriteLine("Netta");
                        sw.WriteLine("Matias");
                        sw.WriteLine("Otto");

                    }
                }
                else//jos tiedosto on jo
                {
                    Console.WriteLine("Tiedosto on jo sijainnissa: {0}", path);
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

        }


        #region METHODS

        public void LaskeNimet()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = " ";
                while ((s = sr.ReadLine()) != null)
                {
                    Nimet.Add(s);
                }

            }
            Nimet.Sort();
            List<string> sortednames = Nimet.Distinct().ToList();
            foreach (string t in sortednames)
            {
                int count = 0;
                for (int x = 0; x < Nimet.Count; x++)
                {
                    if (t.Equals(Nimet[x]))
                    {
                        count++;
                    }
                }
                Console.WriteLine("Nimi {0} esiintyy {1} kertaa.", t, count);
            }
        }

        public void LaskeRivit()
        {
            int lines = File.ReadAllLines(path).Length;
            int names = File.ReadAllLines(path).Distinct().Count();
            Console.WriteLine("Löydetty {0} riviä ja {1} nimeä.", lines, names);
        } 
        #endregion
    }
}
