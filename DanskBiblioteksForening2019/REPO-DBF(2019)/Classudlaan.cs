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
    class Classudlaan
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Classudlaan()
        {

        }
        //Private Field.
        private DateTime _afleveringsDato;
        //Public Property.
        public DateTime afleveringsDato
        {
            get { return _afleveringsDato; }
            set { _afleveringsDato = value; }
        }
        /// <summary>
        /// Calculates the rent time of the books.
        /// </summary>
        /// <param name="lentdate">DateTime</param>
        /// <param name="userStatus">string</param>
        public void BeregnAfleveringsDato(DateTime lentdate, string userStatus)
        {

        }
    }
}
