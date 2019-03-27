using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    public class ClassPublisher : ClassNotify
    {
        private string _id;
        private string _publisher;

        public ClassPublisher()
        {
            id = "0";
        }

        public string publisher
        {
            get { return _publisher; }
            set
            {
                if (value != _publisher)
                {
                    _publisher = value;
                    Notify("publisher");
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
