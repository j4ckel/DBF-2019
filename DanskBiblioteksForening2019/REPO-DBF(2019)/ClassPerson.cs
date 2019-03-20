using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{   ///
    /// <summary>
    /// This Class handles the fields and properties for each person.
    /// </summary>
    public class ClassPerson : ClassNotify
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
            set
            {
                if (value != _id)
                {
                    _id = value;
                    Notify("id");
                }
            }
        }
        public string navn
        {
            get { return _navn; }
            set
            {
                if (value != _navn)
                {
                    _navn = value;
                    Notify("navn");
                }
            }
        }
        public string adresse
        {
            get { return _adresse; }
            set
            {
                if (value != _adresse)
                {
                    _adresse = value;
                    Notify("adresse");
                }
            }
        }
        public string telefon
        {
            get { return _telefon; }
            set
            {
                if (value != _telefon)
                {
                    _telefon = value;
                    Notify("telefon");
                }
            }
        }
        public string mail
        {
            get { return _mail; }
            set
            {
                if (value != _mail)
                {
                    _mail = value;
                    Notify("mail");
                }
            }
        }
        public int rolle
        {
            get { return _rolle; }
            set
            {
                if (value != _rolle)
                {
                    _rolle = value;
                    Notify("rolle");
                }
            }
        }
    }
}
