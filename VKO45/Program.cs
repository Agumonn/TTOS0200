using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO45
{
    class Program
    {
        static void KalastajanTiedot()
        {
            try
            {
                Kalastaja paikka1 = new Kalastaja("Kirsi Kernel", "020-12345678");
                Console.WriteLine("Uusi kalastaja lisätty: \n - Kalastaja: {0} Puhelin {1} \n", paikka1.Nimi, paikka1.PuhelinNumero);
                Console.WriteLine("------------------------------------------\n");
                Kala Ahven = new Kala("Ahven", 100, 40, "Järvi", "Keski-suomi");
                Console.WriteLine("Kalastaja: {0} Sai uuden kalan: \n - Laji: {1} {2} cm {3} g \n - Paikka: {4} \n - Paikan nimi: {5} \n",
                    paikka1.Nimi, Ahven.Laji, Ahven.Pituus, Ahven.Paino, Ahven.Paikka, Ahven.PaikanNimi);
                Console.WriteLine("------------------------------------------\n");
                paikka1.Saalis.Add(Ahven);

                Kala Kuha = new Kala("Kuha", 500, 54, "Rovaniemi", "Lappi");
                Console.WriteLine("Kalastaja: {0} Sai uuden kalan: \n - Laji: {1} {2} cm {3} g \n - Paikka: {4} \n - Paikan nimi: {5} \n",
                    paikka1.Nimi, Kuha.Laji, Kuha.Pituus, Kuha.Paino, Kuha.Paikka, Kuha.PaikanNimi);
                Console.WriteLine("------------------------------------------\n");
                paikka1.Saalis.Add(Kuha);

                Kala Hauki = new Kala("Hauki", 3000, 80, "Järvi", "Keski-suomi");
                Console.WriteLine("Kalastaja: {0} Sai uuden kalan: \n - Laji: {1} {2} cm {3} g \n - Paikka: {4} \n - Paikan nimi: {5} \n",
                    paikka1.Nimi, Hauki.Laji, Hauki.Pituus, Hauki.Paino, Hauki.Paikka, Hauki.PaikanNimi);
                Console.WriteLine("------------------------------------------\n");
                paikka1.Saalis.Add(Hauki);

                Console.WriteLine(paikka1.ToString());
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("Suurimmasta pienimpään: \n");
                Console.WriteLine(paikka1.Kaanteinen());


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        static void Main(string[] args)
        {
            /*
             //tehtävä 1 NOPPA
            try
            {
                Noppa noppa = new Noppa();
                Console.WriteLine("How many times you want to throw a dice?: ");
                int throwamount = int.Parse(Console.ReadLine());
                noppa.Throw(throwamount);
                //noppa.Print();
                Console.WriteLine("Average: " + noppa.Throws.Average());
                for (int x = 1; x < 7; x++)
                {
                    int count = 0;
                    foreach (int i in noppa.Throws)
                    {
                        if (i == x)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("{0} count is: {1}", x, count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            */
            /*
            // Tehtävä 2 ostokset
            List<Product> Ostoskarryt = new List<Product>();
            Ostoskarryt.Add(new Product("Milk", 1.4));
            Ostoskarryt.Add(new Product("Yoghurt", 0.8));
            Ostoskarryt.Add(new Product("Juice", 2.5));
            Console.WriteLine("All products in collection: ");
            foreach (Product asia in Ostoskarryt)
            {
                Console.WriteLine("-product: {0} {1}e", asia.Name, asia.Price);
            }
            */
            //tehtävä 3 kalat
            KalastajanTiedot();
        }

    }
}
