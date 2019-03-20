using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO_DBF_2019_
{
    class ClassUser : ClassNotify
    {
        private string _userName;
        private string _password;
        private string _userType;

        public ClassUser()
        {

        }

        public string userType
        {
            get { return _userType; }
            set
            {
                if (value != _userType)
                {
                    _userType = value;
                    Notify("userType");
                }
            }
        }

        public string password
        {
            get { return _password; }
            set
            {
                if (value != _password)
                {
                    _password = value;
                    Notify("password");
                }
            }
        }

        public string userName
        {
            get { return _userName; }
            set
            {
                if (value != _userName)
                {
                    _userName = value;
                    Notify("userName");
                }
            }
        }

    }
}
