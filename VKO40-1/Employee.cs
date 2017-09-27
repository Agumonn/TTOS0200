using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ohjelmassa tulee pystyä käsittelemään työntekijöiden tietoja (Employee). Työntekijöiden osalta seuraavia tietoa pitää pystyä käsittelemään: 
//työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). Samassa ohjelmassa pitää pystyä käsittelemään myös johtajien tietoja (Boss), 
//heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus).
//Tutki tehtävän tavoitetta/kerrontaa ja toteuta tarvittavat UML-luokkakaaviot.Toteuta tämän jälkeen vaaditut luokat, 
//luo ja käytä olioita pääohjelmasta.Tulosta vaadittujen luokkien olioiden tietoja output-ikkunaan.
//Tietoja ei tarvitse kysyä sovelluksen käyttäjältä, vaan voit alustaa ne suoraan pääohjelmassa.
//Esimerkkitoiminta: (huomaa, että Kirsi Kernelin tietoja on muutettu ohjelman suorituksessa)
namespace VKO40_1
{
    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }

        public int Salary { get; set; }
        public override string ToString()
        {
            return Name + " " + Profession + " " + Salary + "e ";
        }


    }
    public class Boss: Employee
    {
        public string Car { get; set; }

        public int Bonus { get; set; }

        public override string ToString()
        {
            return base.ToString() + " " + Car +" "+ Bonus;
        }

    }

}
