using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    public class ClassGenre : ClassNotify
    {
        private string _id;
        private string _genre;

        public ClassGenre()
        {
            id = "0";
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
