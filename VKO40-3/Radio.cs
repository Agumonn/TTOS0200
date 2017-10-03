using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_3
{
    public class Radio
    {
        public bool Power { get; set; }
        private const int Maxfrequency = 26000;
        private const int Minfrequency = 2000;
        private const int MaxVolume = 9;
        private const int MinVolume = 0;
        private int frequency;
        private int volume;


        public int Frequency
        {
            get { return frequency; }
            set
            {
                if (value > Maxfrequency)
                    frequency = Maxfrequency;
                else if (value < Minfrequency)
                    frequency = Minfrequency;
                else
                    frequency = value;
            }
        }

        public int Volume {
            get { return volume; }
            set
            {
                if (value > MaxVolume )
                    volume = MaxVolume;
                else if (value < MinVolume)
                    volume = MinVolume;
                else
                    volume = value;
            }
        }
        public override string ToString()
        {
            return String.Format(" Radio päällä: {0}\n Taajuus: {1}\n Äänenvoimakkuus: {2}\n", Power, frequency, volume);
        }




    }
}
