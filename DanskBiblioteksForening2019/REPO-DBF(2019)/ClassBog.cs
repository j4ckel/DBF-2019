using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    /// <summary>
    /// This Class Handles the fields and properties for each book.
    /// </summary>
    public class ClassBog : ClassNotify
    {
        //Private Fields holding values
        #region Fields
        private int _id;
        private string _isbnNr;
        private string _titel;
        private string _forfatter;
        private string _forlag;
        private string _genre;
        private string _type;
        private decimal _pris;
        #endregion
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ClassBog(int inid,string inisbnNr,string intitel, string inforfatter,string inforlag,string ingenre,string intype,decimal inpris)
        {
            inid = id;

        }
        public ClassBog()
        {
            id = 0;
        }

        //Public Properties.
        #region Properties

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
        public string isbnNr
        {
            get { return _isbnNr; }
            set
            {
                if (value != _isbnNr)
                {
                    _isbnNr = value;
                    Notify("isbnNr");

                }
            }
        }
        public string titel
        {
            get { return _titel; }
            set
            {
                if (value != _titel)
                {
                    _titel = value;
                    Notify("titel");

                }
            }
        }
        public string forfatter
        {
            get { return _forfatter; }
            set
            {
                if (value != _forfatter)
                {
                    _forfatter = value;
                    Notify("forfatter");

                }
            }
        }
        public string forlag
        {
            get { return _forlag; }
            set
            {
                if (value != _forlag)
                {
                    _forlag = value;
                    Notify("forlag");

                }
            }
        }
        public string genre
        {
            get { return _genre; }
            set
            {
                if (value != _genre)
                {
                    _genre = value;
                    Notify("genre");

                }
            }
        }
        public string type
        {
            get { return _type; }
            set
            {
                if (value != _type)
                {
                    _type = value;
                    Notify("type");

                }
            }
        }
        public decimal pris
        {
            get { return _pris; }
            set
            {
                if (value != _pris)
                {
                    _pris = value;
                    Notify("pris");

                }
            }
        }
        #endregion

    }
}
