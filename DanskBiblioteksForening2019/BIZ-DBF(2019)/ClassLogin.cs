using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIZ_DBF_2019_
{
    class ClassLogin
    {
        private string _id;
        private string _user;
       
        public ClassLogin()
        {

        }

        public ClassPerson GetUserData(string id, string user)
        {

        }

        public string user
        {
            get { return _user; }
            set
            {
                if (value != _user)
                {
                    _user = value;
                    //Notify("user");
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
                    //Notify("id");
                }
            }
        }

    }
}
