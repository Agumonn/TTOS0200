using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tee ohjelma, joka arpoo satunnaisluvun väliltä 0-100. Käytä C#:n Random -luokkaa. Tämän jälkeen ohjelman käyttäjää kehoitetaan arvaaman arvottu luku. Ohjelman tulee antaa vihje arvauksen jälkeen onko arvottu luku pienemäi vai suurempi. Tämän jälkeen vihjeitä toistetaan kunnes käyttäjä arvaa oikean luvun. Tulosta lopuksi arvausten määrä näytölle. PS Satunnaislukujen arpomisesta tietokoneella löytyy mielenkiintoista luettavaa esimerkiksi tästä artikkelista: Computers are lousy random number generators.

namespace TEHTAVAT1
{
    class Task16
    {
        public static void TASK16()
        {
               
                Random rnd = new Random();

                int numero = rnd.Next(1, 101);
                int arvaus = 0;

                while (true)
                {
                    Console.Write("Arvaa luku > ");
                    int luku = int.Parse(Console.ReadLine());
                    arvaus++;

                    if (luku < numero)
                    {
                        Console.WriteLine("Luku on suurempi");
                    }
                    else if (luku > numero)
                    {
                        Console.WriteLine("Luku on pienempi");
                    }
                    else
                    {
                        Console.WriteLine("Hienoa, arvasit luvun " + arvaus + " kerralla.");
                        break;
                    }
                }
         }
     }
 }
