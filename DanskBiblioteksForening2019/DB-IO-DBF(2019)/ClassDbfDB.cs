using REPO_DBF_2019_;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    public class ClassDbfDB : ClassDB
    {

        public ClassDbfDB()
        {
            

        }
        public ObservableCollection<ClassBog> GetAllBooks()
        {
            ObservableCollection<ClassBog> CB = new ObservableCollection<ClassBog>();

            DataTable dt = DbReturnDataTable("SELECT * FROM Books");
            foreach(DataRow row in dt.Rows)
            {
                ClassBog CLB = new ClassBog();
                CLB.id = Convert.ToInt32(row["id"]);
                CLB.isbnNr = row["isbnr"].ToString();
                CLB.titel = row["titel"].ToString();
                CLB.forfatter = row["forfatter"].ToString();
                CLB.forlag = row["forlag"].ToString();
                CLB.genre = row["genre"].ToString();
                CLB.type = row["type"].ToString();
                CLB.pris = Convert.ToDecimal(row["pris"]);
                
            }

            return CB;
        }

        public List<ClassBog> GetAllBooksLike(string search)
        {
            List<ClassBog> CB = new List<ClassBog>();

            DataTable dt = DbReturnDataTable("SELECT * FROM Books WHERE titel = "+ search );
            foreach (DataRow row in dt.Rows)
            {
               
            }

            return CB;
        }
        public List<ClassBog> GetAllLentToUser(string id)
        {


            return GetAllLentToUser(id);
        }
        public void UpdateTheLendingStatus(string id, bool status)
        {

        }
        public ClassUser GetUser(string UserID, string Password)
        {


            return GetUser(UserID, Password);
        }
        public void UpdateBook(ClassBog CB)
        {
            
        }
    }
}
