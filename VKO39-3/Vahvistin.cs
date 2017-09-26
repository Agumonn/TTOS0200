using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävänäsi on ohjelmoida yksinkertaisen vahvistimen toiminta, jolla voidaan kontrolloida äänenvoimakkuutta välillä 0-100. 
//Toteuta Vahvistin-luokka ja tee pääohjelma, jolla luot olion Vahvistin-luokasta. Säädä ja kokeile vahvistinta eri äänenvoimakkuuksilla. 
//Käytä Vahvistin-luokassa get- ja set-aksessoreita. get-aksessori palauttaa äänenvoimakkuuden ja set-aksessori rajaa äänenvoimakkuuden arvoa.
namespace VKO39_3
{
    class Vahvistin
    {
        private const int maxvolume = 100;
        private const int minvolume = 0;
        private int volume;
        public int Volume
        {

            get
            {
                return volume;
            }

            set
            {
                if (value > maxvolume)
                {
                    volume = maxvolume;
                    Console.WriteLine("-> Too much volume -  Amplifier volume is set to maximum : {0}", volume);
                }
                else if (value < minvolume)
                {
                    volume = minvolume;
                    Console.WriteLine("-> Too low volume - Amplifier volume is set to minimum : {0}", volume);
                }
                else
                    volume = value;
            }

        }
    }
}
