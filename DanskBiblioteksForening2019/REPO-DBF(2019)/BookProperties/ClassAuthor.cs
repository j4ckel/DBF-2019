using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    public class ClassAuthor : ClassNotify
    {
        private string _id;
        private string _author;

        public ClassAuthor()
        {
            id = "0";
        }
        
        public string author
        {
            get { return _author; }
            set
            {
                if (value != _author)
                {
                    _author = value;
                    Notify("author");
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
