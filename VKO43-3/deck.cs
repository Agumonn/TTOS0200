using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO43_3
{
    class Deck
    {
        public List<Kortti> cards;
        public Deck()
        {
            cards = new List<Kortti>();
        }

        public void CreateDeck(int cardhouses=13)
        {
            //hertta 1-13
            for (int x = 0; x < cardhouses; x++)
            {
                cards.Add(new Hertta { CardValue = (x + 1) });
            }
            //risti 1-13
            for (int x = 0; x < cardhouses; x++)
            {
                cards.Add(new Risti { CardValue = (x + 1) });
            }
            //ruutu 1-13
            for (int x = 0; x < cardhouses; x++)
            {
                cards.Add(new Ruutu { CardValue = (x + 1) });
            }
            //pata 1-13
            for (int x = 0; x < cardhouses; x++)
            {
                cards.Add(new Pata { CardValue = (x + 1) });
            }
        }
        public void ShowDeck()
        {
            int x = 1;
            foreach (Kortti card in cards)
            {
                Console.WriteLine(String.Format("{0} kortti on {1} #{2}", x, card.House, card.CardValue));
                x++;
            }
        }

        public List<Kortti> Shuffle()
        {
            int t = cards.Count;
            Random random = new Random();
            while (t > 1)
            {
                int s = random.Next(0, t);
                t--;
                Kortti value = cards[s];
                cards[s] = cards[t];
                cards[t] = value;
            }
            return cards;
        }




    }
    abstract class Kortti
    {
        public abstract string House { get; }
        private int cardvalue;
        public int CardValue
        {
            get { return cardvalue; }
            set
            {
                if (value <= 13)
                {
                    cardvalue = value;
                }
                else if (value % 13 == 0)
                {
                    cardvalue = 13;
                }
                else
                {
                    cardvalue = (value % 13);
                }
            }

        }


    }

    class Hertta : Kortti
    {
        public override string House
        {
            get { return "Heart"; }
        }
    }
    class Pata : Kortti
    {
        public override string House
        {
            get { return "Spade"; }
        }
    }
    class Risti : Kortti
    {
        public override string House
        {
            get { return "Club"; }
        }
    }
    class Ruutu : Kortti
    {
        public override string House
        {
            get { return "Diamond"; }
        }
    }

}
