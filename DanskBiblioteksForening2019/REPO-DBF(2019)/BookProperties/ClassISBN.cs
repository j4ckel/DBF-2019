using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    public class ClassISBN : ClassNotify
    {
        private string _id;
        private string _ISBN;

        public ClassISBN()
        {
            id = "0";
        }

        public string ISBN
        {
            get { return _ISBN; }
            set
            {
                if (value != _ISBN)
                {
                    _ISBN = value;
                    Notify("ISBN");
                }
            }
        }

        public string id
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
    }
}
