using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    /// <summary>
    /// This Class handles the fields and properties for each person.
    /// </summary>
    class ClassPerson
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ClassPerson()
        {

        }
        //Private Fields
        //Thats stores values.
        private int _id;
        private string _navn;
        private string _adresse;
        private string _telefon;
        private string _mail;
        private int _rolle;
        //Public properties.
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string MyProperty
        {
            get { return _navn; }
            set { _navn = value; }
        }
        public string adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }
        public string telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }
        public string mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public int rolle
        {
            get { return _rolle; }
            set { _rolle = value; }
        }
    }
}
