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
        private string _strUdlaansDate;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Classudlaan()
        {

        }

        #region Properties

        public string strUdlaansDate
        {
            get { return _strUdlaansDate; }
            set
            {
                if (value != _strUdlaansDate)
                {
                    _strUdlaansDate = value;
                    Notify("strUdlaansDate");

                }
            }
        }

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
       
        public DateTime udlaansdate
        {
            get { return _udlaansdate; }
            set
            {
                if (value != _udlaansdate)
                {
                    _udlaansdate = value;
                    strUdlaansDate = _udlaansdate.Year.ToString() + _udlaansdate.Month.ToString() + _udlaansdate.Date.ToString();
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
