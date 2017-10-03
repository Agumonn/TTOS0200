using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO40_4
{
    public class Bookshelf
        {
        public string Name;
        
        public override string ToString()
            {
                return "Nimi: " + Name;
            }
   
        }
    public class Book :Bookshelf
        {
            public string Author {get;set;}
            public string Publisher {get;set;}
            public int Pagecount {get;set;}
        public override string ToString()
            {
                return " kirjailija: " + Author + " Julkaisija: " + Publisher + " Sivujen lkm:" + Pagecount ;
            }

        }
    public class Magazine :Bookshelf
        {
        public string Publisher {get;set;}
        public int Pagecount {get;set;}
        public string Issuenumber {get; set;}

        public override string ToString()
            {
                return " Julkaisija: " + Publisher + " Sivujen lkm:" + Pagecount + "numero"+ Issuenumber;
            }

        }
    public class Video :Bookshelf
        {
        public string Director {get;set;}
        public string Writer {get;set;}
        public string Leadactor {get;set;}
        public string Leadactress {get;set;}
        public int Year {get;set;}
        public string Format { get; set; }

        public override string ToString()
            {
                return " Ohjaaja: " + Director + " käsikirjoittaja: " + Writer + " näyttelijät:" + Leadactor + " " + Leadactress+ " vuosi:" + Year+ "Format: " + Format;
            }

        }
    
    public class Music :Bookshelf
        { 
        public string Artist{get;set;}
        public int Trackcount{get;set;}
        public string Format;
        public override string ToString()
            {
                return "Artisti: " + Artist + " Biisien lkm "+ Trackcount + "Format: " + Format;
            }

        }




}
