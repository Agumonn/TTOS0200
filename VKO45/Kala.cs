using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO45
{
    public class Kalastaja
    {
        #region PROPERTIES
        public string Nimi { get; set; }
        public string PuhelinNumero { get; set; }
        public List<Kala> Saalis = new List<Kala>();
        #endregion
        #region CONSTRUCTOR
        public Kalastaja(string nimi, string puhelinnumero)
        {
            Nimi = nimi;
            PuhelinNumero = puhelinnumero;
        } 
        #endregion
        #region METHODS
        public override string ToString()
        {
            string retval = "";
            retval += string.Format("Kaikki kalastajat rekisterissä: \n\n Kalsataja {0} :\n", Nimi);
            foreach (Kala kala in Saalis)
            {
                retval += string.Format("-Laji: {0} {1} cm {2} g \n-Paikka: {3} \n-Paikan nimi: {4} \n\n",
                    kala.Laji, kala.Pituus, kala.Paino, kala.Paikka, kala.PaikanNimi);
            }
            return retval;
        }
        public string Kaanteinen()
        {
            string retval = "";
            var newList = Saalis.OrderByDescending(x => x.Paino).ToList();
            retval += string.Format("Kaikki kalastajat rekisterissä: \n\n Kalsataja {0} :\n", Nimi);
            foreach (var kala in newList)
            {
                retval += string.Format("-Laji: {0} {1} cm {2} g \n-Paikka: {3} \n-Paikan nimi: {4} \n\n",
                    kala.Laji, kala.Pituus, kala.Paino, kala.Paikka, kala.PaikanNimi);
            }
            return retval;
        } 
        #endregion
    }
    public class Kala
    {
        #region PROPERTIES
        public string Laji { get; set; }
        public int Paino { get; set; }
        public int Pituus { get; set; }
        public string Paikka { get; set; }
        public string PaikanNimi { get; set; }
        #endregion
        #region CONSTRUCTOR
        public Kala()
        {

        }
        public Kala(string laji, int paino, int pituus, string paikka, string paikannimi)
        {
            this.Laji = laji;
            this.Paino = paino;
            this.Pituus = pituus;
            this.Paikka = paikka;
            this.PaikanNimi = paikannimi;
        } 
        #endregion

    }
}
