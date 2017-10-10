using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_2
{
    class Items
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public Items(string name,string location)
        {
            Name = name;
            Location = location;
        }
        public override string ToString()
        {
            return String.Format("Tavara: {0}  Sijainti : {1}", Name,Location);
        }
    }
}
