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
    class ClassBog
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ClassBog()
        {

        }
        //Private Fields holding values
        private int _id;
        private string _isbnNr;
        private string _titel;
        private string _forfatter;
        private string _forlag;
        private string _genre;
        private string _type;
        private decimal _pris;
        //Public Properties.
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string isbnNr
        {
            get { return _isbnNr; }
            set { _isbnNr = value; }
        }
        public string titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        public string forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }
        public string forlag
        {
            get { return _forlag; }
            set { _forlag = value; }
        }
        public string genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }
        public decimal pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

    }
}
