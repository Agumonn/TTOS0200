using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Music levy = new Music();
            Music lätty = new Music();
            Video dvd = new Video();
            Video bluray = new Video();
            Magazine lehti = new Magazine();
            Book kirja = new Book();

            levy.Name = "Mellon collie and infinite sadness";
            levy.Artist = "The Smashing pumpkins";
            levy.Trackcount= 11;
            levy.Format="cd";
        

            lätty.Name ="Power corruption and lies";
            lätty.Artist="new order";
            lätty.Trackcount=10;
            lätty.Format="vinyl";

            dvd.Name ="Blade runner";
            dvd.Director="Ridley scott";
            dvd.Writer="unknown";
            dvd.Year= 1982;
            dvd.Leadactor="harrison ford";
            dvd.Leadactress="unknown";
            dvd.Format="dvd";


            bluray.Name ="gladiator";
            bluray.Director="Ridley scott";
            bluray.Writer="unknown";
            bluray.Year=2001;
            bluray.Leadactor="unknown";
            bluray.Leadactress="unknown";
            bluray.Format="blu-ray";

            lehti.Name="iltalehti";
            lehti.Pagecount= 55;
            lehti.Publisher="sanoma";

            kirja.Name="Harry potter";
            kirja.Author="J.K. Rowling";
            kirja.Publisher="otava";
            kirja.Pagecount=455;


            Console.WriteLine(kirja.ToString());
            Console.WriteLine(lehti.ToString());
            Console.WriteLine(dvd.ToString());
            Console.WriteLine(bluray.ToString());
            Console.WriteLine(lätty.ToString());
            Console.WriteLine(levy.ToString());







        }
    }
}
