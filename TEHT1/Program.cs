using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.Miniasio
{
    class TestaaMiniAsio
    {
        static void Testaa()
        {
            //luodaan list tyyppinen lista opiskelijoista
            List<Student> students = new List<Student>();
            //testin vuoksi erilaisia tapoja lisätä olioita listaan
            Student matti = new Student("Matti", "Niemi");
            students.Add(matti);
            students.Add(new Student("Antti", "Aalto", "A1234"));
            //myös näin
            students.Add(new Student { Etunimi = "Hanna", Sukunimi = "Hannikainen", AsioID = "B2344" });
            students.Add(new Student { Etunimi = "Teppo", Sukunimi = "Tanssija", AsioID = "K8272" ,Ryhmä="TTV16S1"});
            Student kalle = new Student();
            kalle.Etunimi = "Kalle";
            kalle.Sukunimi = "Keppana";
            kalle.AsioID = "J5555";
            kalle.Ryhmä = "TTV17S4";
            students.Add(kalle);

            //yhden opiskelijan tietojen näytttäminen
            Console.WriteLine("Anna numero väliltä 1-5");
            int i = int.Parse(Console.ReadLine());
            if (i-1 < students.Count)
            {
                Console.WriteLine("Miniasion {0} opiskelija on {1}", i, students[i-1].ToString());

            }
            else Console.WriteLine("Asiossa on vain {0} opiskelijaa",students.Count);

            // kaikkien tietojen tulostus
            Console.WriteLine("ASION KAIKKI OPISKELIJAT");
            foreach (var o in students)
            {
                Console.WriteLine(o.ToString());
            }
            //kaikkien tiedot aakkosjärjestyksessä sukunimen mukaan
            //sortataan oliot Sukunimi ominaisuuden mukaiseen järjestykseen
            students.Sort((x,y)=> x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("miniASION KAIKKI OPISKELIJAT aakkosjärjestyksessä sukunimen mukaan: ");
            foreach (var o in students)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen, huom tehdään tarkistus ettei AsioID ole jo olemassa
            Console.WriteLine("Anna uuden ASIOID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa jo kyseistä tunnusta
            bool lippu = false;
            foreach (Student o in students)
            {
                if (asioid==o.AsioID)
                {
                    lippu = true;
                    break;

                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna opiskelijan etunimi: ");
                string etunimi=Console.ReadLine();
                Console.WriteLine("Anna opiskelijan sukunimi: ");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhmä:");
                string ryhmä = Console.ReadLine();
                Student uusi = new Student(etunimi, sukunimi, asioid, ryhmä);
                students.Add(uusi);
                //tulostus
                Console.WriteLine("ASION KAIKKI OPISKELIJAT");
                foreach (var o in students)
                {
                    Console.WriteLine(o.ToString());
                }
            }

        }
        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
