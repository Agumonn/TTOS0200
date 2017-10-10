using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO41_2
{
    class Fridge
    {
        private bool Door { get; set; }
        private string DoorOpen
        {
            get
            {
                if (Door)
                {
                    return "Auki";
                }
                else
                {
                    return "Kiinni";
                }
            }
        }
        private string Light
        {
            get
            {
                if (Door)
                    return "Valo päällä";
                else
                    return "Valo pois";
            }
        }
        public List<Items> FridgeContents;
        public Fridge()
        {
            FridgeContents = new List<Items>();
        }
        public void OpenDoor()
        {
            if (Door)
            {
                Door = false;
            }
            else
            {
                Door = true;
            }
        }
        public void AddItems(Items item)
        {
            FridgeContents.Add(item);
        }
        public override string ToString()
        {
            string retval = String.Format("Jääkaappi on {0} ja {1}.  ", DoorOpen, Light);
            foreach (Items item in FridgeContents)
            {
                retval += "\n" + item.ToString();
            }
            return retval;
        }
    }
}
