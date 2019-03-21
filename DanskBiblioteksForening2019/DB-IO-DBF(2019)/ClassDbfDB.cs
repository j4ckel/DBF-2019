using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REPO_DBF_2019_;

namespace DB_IO_DBF_2019_
{
    public class ClassDbfDB
    {
        //ObservableCollection<ClassBog> CB = new ObservableCollection<ClassBog>();

        public ClassDbfDB()
        {
            

        }
        public void GetAllBooksLike(string search)
        {
            //CB
        }

        public void GetAllLentToUser(string id)
        {
            //cb
        }
        public void UpdateTheLendingStatus(string id)
        {

        }
        public ClassUser GetUser(string UserID, string Password)
        {
            ClassUser user = new ClassUser();

            return user;
        }
    }
}
