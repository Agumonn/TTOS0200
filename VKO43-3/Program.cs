using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO43_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Pakka = new Deck();
            Pakka.CreateDeck(13);
            Pakka.ShowDeck();
            Console.WriteLine("\nShuffled deck\n");
            Pakka.Shuffle();
            Pakka.ShowDeck();
        }
    }
}
