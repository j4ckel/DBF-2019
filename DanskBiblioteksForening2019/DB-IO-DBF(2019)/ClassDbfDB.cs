using REPO_DBF_2019_;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassDbfDB
    {
        ObservableCollection<ClassBog> CB = new ObservableCollection<ClassBog>();

        public ClassDbfDB()
        {
            

        }
        public ObservableCollection<ClassBog> GetAllBooksLike(string search)
        {
            
            return GetAllBooksLike(search);
        }

        public ObservableCollection<ClassBog> GetAllLentToUser(string id)
        {

            return GetAllLentToUser(id);
        }
        public void UpdateTheLendingStatus(string id, bool status)
        {

        }
        public ClassUser GetUser(string UserID, string Password)
        {


        }
    }
}
