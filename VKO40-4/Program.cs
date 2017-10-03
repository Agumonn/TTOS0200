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
            Cd levy = new Cd();
            Vinyl lätty = new Vinyl();
            Dvd leffa = new Dvd();
            Bluray lefu = new Bluray();
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

            leffa.Name ="Blade runner";
            leffa.Director="Ridley scott";
            leffa.Writer="unknown";
            leffa.Year= 1982;
            leffa.Leadactor="harrison ford";
            leffa.Leadactress="unknown";
            leffa.Format="dvd";
            

            lefu.Name ="gladiator";
            lefu.Director="Ridley scott";
            lefu.Writer="unknown";
            lefu.Year=2001;
            lefu.Leadactor="unknown";
            lefu.Leadactress="unknown";
            lefu.Format="blu-ray";

            lehti.Name="iltalehti";
            lehti.Pagecount= 55;
            lehti.Publisher="sanoma";

            kirja.Name="Harry potter";
            kirja.Author="J.K. Rowling";
            kirja.Publisher="otava";
            kirja.Pagecount=455;


            Console.WriteLine(kirja.ToString());
            Console.WriteLine(lehti.ToString());
            Console.WriteLine(leffa.ToString());
            Console.WriteLine(lefu.ToString());
            Console.WriteLine(lätty.ToString());
            Console.WriteLine(levy.ToString());







        }
    }
}
