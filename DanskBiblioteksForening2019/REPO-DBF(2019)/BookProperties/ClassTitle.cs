using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    public class ClassTitle : ClassNotify
    {
        private string _id;
        private string _title;

        public ClassTitle()
        {
            id = "0";
        }

        public string title
        {
            get { return _title; }
            set
            {
                if (value != _title)
                {
                    _title = value;
                    Notify("title");
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
