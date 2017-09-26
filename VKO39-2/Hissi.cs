using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO39_2
{
    class Hissi
    {


        private const int maxkerros = 5;
        private const int minkerros = 1;
        private int kerros;
        public int Kerros
        {

            get
            {
                return kerros;
            }

            set
            {
                if (value > maxkerros)
                { 
                    kerros = maxkerros;
                    Console.WriteLine("Ylin kerros on {0}", kerros);
                }
                else if (value < minkerros)
                {
                    kerros = minkerros;
                    Console.WriteLine("Alin kerros on {0}", kerros);
                }
                else
                    kerros = value;
            }

        }
    }
}
