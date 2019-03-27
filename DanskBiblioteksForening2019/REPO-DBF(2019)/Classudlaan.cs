using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    /// <summary>
    /// This class handles the due time of the lent books.
    /// </summary>
    public class Classudlaan : ClassNotify
    {
        private int _id;
        private DateTime _udlaansdate;
        private string _udlaanstatus;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Classudlaan()
        {

        }

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
        private int _bogid;

        public int bogid
        {
            get { return _bogid; }
            set
            {
                if (value != _bogid)
                {
                    _bogid = value;
                    Notify("bogid");

                }
            }
        }
        private int _personid;

        public int personid
        {
            get { return _personid; }
            set
            {
                if (value != _personid)
                {
                    _personid = value;
                    Notify("personid");

                }
            }
        }



        public DateTime udlaansdate
        {
            get { return _udlaansdate; }
            set
            {
                if (value != _udlaansdate)
                {
                    _udlaansdate = value;
                    Notify("udlaansdate");

                }
            }
        }

        public string udlaanstatus
        {
            get { return _udlaanstatus; }
            set
            {
                if (value != _udlaanstatus)
                {
                    _udlaanstatus = value;
                    Notify("udlaanstatus");

                }
            }
        }
        #endregion
        /// <summary>
        /// Calculates the rent time of the books.
        /// </summary>
        /// <param name="lentdate">DateTime</param>
        /// <param name="userStatus">string</param>
        public void BeregnAfleveringsDato(DateTime lentdate, string userStatus)
        {
            //????????
        }
    }
}
