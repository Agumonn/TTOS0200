using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Volvo", "Amazon");

            Console.WriteLine("Auto {0} {1}", auto.Valmistaja, auto.ToString());
            auto.AddTyre(new Tyres("Nokia", "Hakkapeliita","12345"));
            auto.AddTyre(new Tyres("Nokia", "Hakkapeliita", "12345"));
            auto.AddTyre(new Tyres("Nokia", "Hakkapeliita", "12345"));
            auto.AddTyre(new Tyres("Nokia", "Hakkapeliita", "12345"));

            Console.WriteLine(auto.ToString());
        }
    }
}
