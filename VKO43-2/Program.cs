using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO43_2
{
    class Program
    {
        static void ListAlbum()
        {
            CD levy = new CD("Deeper Understanding", "The War On Drugs");
            levy.AddTrack(new Track("Up All Night","6:23"));
            levy.AddTrack(new Track("Pain"  ,"5:30"));
            levy.AddTrack(new Track("Holding On","5:50"));
            levy.AddTrack(new Track("Strangest Thing", "6:41"));
            levy.AddTrack(new Track("Knocked Down", "3:59"));
            levy.AddTrack(new Track("Thinking of a Place", "11:10"));
            levy.AddTrack(new Track("In Chains", "7:20"));
            levy.AddTrack(new Track("Clean Living", "6:28"));
            levy.AddTrack(new Track("You Don't Have to Go", "6:42"));
            Console.WriteLine(levy.ToString());
        }
        static void Main(string[] args)
        {
            ListAlbum();
        }

    }
}
