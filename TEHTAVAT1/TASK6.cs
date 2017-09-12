using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.



namespace TEHTAVAT1
{
    class Task6
    {
        public static void TASK6()
        {

            double tulos;
            double kulutus;
            double kerroin;
            double matka;



            Console.Write("Anna luku > ");
            matka = double.Parse(Console.ReadLine());
            kerroin = matka / 100;
            kulutus = kerroin * 7.02;
            tulos = kulutus * 1.595;
            Console.Write("Bensaa kuluu "+ kulutus + " ja hintaa tulee :" + tulos);



        }

    }
}
