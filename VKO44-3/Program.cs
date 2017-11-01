using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace VKO44_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numerot = new Numbers();
            numerot.Inputs();
            numerot.AddToTxt();
            numerot.ReadTxt();
        }
    }
}
