using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEHTAVAT1
{
    class Task17
    {
        public static void TASK17()
        {
            int[] luvut1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] luvut2 = new int[5] { 5, 15, 25, 35, 45 };
            int[] kaikki = new int[luvut1.Length + luvut2.Length];
            luvut1.CopyTo(kaikki, 0);
            luvut2.CopyTo(kaikki, luvut1.Length);
            Array.Sort(kaikki);
            for (int i = 0; i < kaikki.Length; i++)
            {
                Console.WriteLine(kaikki[i]);
            }


        }
    }
}
