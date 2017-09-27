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
    class Program
    {
        static void Main(string[] args)
        {
            Employee teacher = new Employee();
            Boss johtaja = new Boss();

            teacher.Name = "Topi Tuppisuu";
            teacher.Profession = "Siivousopettaja";
            teacher.Salary = -10000;

            johtaja.Name = "AKUUUU";
            johtaja.Profession = "BAUS";
            johtaja.Salary = 1000000;
            johtaja.Car = "Ford Mustang 1969";
            johtaja.Bonus = 1000000;

            Console.WriteLine(johtaja.ToString());
            Console.WriteLine(teacher.ToString());
        }
    }
}
