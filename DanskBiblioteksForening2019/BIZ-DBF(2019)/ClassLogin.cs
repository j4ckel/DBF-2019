using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO_DBF_2019_;
using DB_IO_DBF_2019_;

namespace BIZ_DBF_2019_
{
    public class ClassLogin : ClassNotify
    {
        private ClassUser _classUser = new ClassUser();
        ClassDbfDB CDbfDB = new ClassDbfDB();
        private string _id;
        private string _user;
       

        public ClassLogin()
        {

        }

        public ClassUser GetUserData(string id, string user)
        {
            ClassUser User = new ClassPe();
            CDbfDB.GetUser(id,user);
            return User;
        }

        public ClassUser classUser
        {
            get { return _classUser; }
            set
            {
                if(value != _classUser)
                {
                    _classUser = value;
                    Notify("classUser");
                }
            }
        }
        public string user
        {
            get { return _user; }
            set
            {
                if (value != _user)
                {
                    _user = value;
                    Notify("user");
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
