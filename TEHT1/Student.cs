using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamk.It.Miniasio
{
    public class Student
    {
        //PROPERTIES
        #region PROPERTIES 
        public string Etunimi { get; set; }

        public string Sukunimi { get; set; }

        public string AsioID { get; set; }

        public string Ryhmä { get; set; }

        #endregion
        #region CONSTRUCTORS
        public Student()
        { }
        public Student (string etunimi, string sukunimi)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;

        }
        public Student(string etunimi, string sukunimi,string asioid): this(etunimi,sukunimi)
        {
            AsioID = asioid;

        }
        public Student(string etunimi, string sukunimi, string asioid ,string ryhmä) : this(etunimi, sukunimi,asioid)
        {
            Ryhmä = ryhmä;

        }
        #endregion
        #region METHODS
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}" ,Etunimi,Sukunimi,AsioID,Ryhmä);
        }

        #endregion

    }
}
