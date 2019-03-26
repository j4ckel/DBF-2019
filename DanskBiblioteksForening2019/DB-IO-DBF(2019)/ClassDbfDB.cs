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
        
        public List<ClassBog> GetAllBooks()
        {
            List<ClassBog> CB = new List<ClassBog>();

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

            DataTable dt = DbReturnDataTable($"SELECT dbo.Books.id, dbo.Books.pris, dbo.Titel.titel, dbo.Forfatter.forfatter, dbo.Forlag.forlagsNavn, dbo.ISBNnr.isbnNr, dbo.Genre.genreType, dbo.Type.TypeNavn" +
                $"FROM dbo.Books INNER JOIN" +
                $" dbo.Type ON dbo.Books.typeID = dbo.Type.id" +
                $" dbo.Forfatter ON dbo.Books.forfatterID = dbo.Forfatter.id INNER JOIN" +
                $" dbo.Forlag ON dbo.Books.forlagID = dbo.Forlag.id INNER JOIN" +
                $" dbo.Genre ON dbo.Books.genreID = dbo.Genre.id INNER JOIN" +
                $" dbo.ISBNnr ON dbo.Books.isbnID = dbo.ISBNnr.id INNER JOIN" +
                $" dbo.Titel ON dbo.Books.titelID = dbo.Titel.id INNER JOIN" +
                $" dbo.Type ON dbo.Books.typeID = dbo.Type.id" +
                $"WHERE        (dbo.Titel.titel = '*{search}*')");
            foreach (DataRow row in dt.Rows)
            {
                ClassBog bog = new ClassBog();
                bog.id = Convert.ToInt32(row["id"].ToString());
                bog.titel = row["titel"].ToString();
                bog.forfatter = row["forfatter"].ToString();
                bog.forlag = row["forlagsNavn"].ToString();
                bog.isbnNr = row["isbnNr"].ToString();
                bog.genre = row["genreType"].ToString();
                bog.type = row["TypeNavn"].ToString();
                bog.pris = Convert.ToDecimal(row["pris"].ToString());
                CB.Add(bog);
            }

            return CB;
        }
        public List<ClassBog> GetAllLentToUser(string personid)
        {
            DataTable dt = DbReturnDataTable("SELECT dbo.Books.id, dbo.Type.TypeNavn, dbo.Titel.titel," +
                " dbo.Genre.genreType, dbo.Forfatter.forfatter, dbo.Forlag.forlagsNavn, dbo.ISBNnr.isbnNr, dbo.Udlaan.udlaansStatus" +
                "FROM dbo.Udlaan RIGHT OUTER JOIN dbo.Books INNER JOIN" +
                " dbo.Forfatter ON dbo.Books.forfatterID = dbo.Forfatter.id INNER JOIN" +
                " dbo.Forlag ON dbo.Books.forlagID = dbo.Forlag.id INNER JOIN" +
                " dbo.Genre ON dbo.Books.genreID = dbo.Genre.id INNER JOIN" +
                " dbo.ISBNnr ON dbo.Books.isbnID = dbo.ISBNnr.id INNER JOIN" +
                " dbo.Titel ON dbo.Books.titelID = dbo.Titel.id INNER JOIN" +
                " dbo.Type ON dbo.Books.typeID = dbo.Type.id ON dbo.Udlaan.bookID = dbo.Books.id" +
                $"WHERE(dbo.Udlaan.personID = '{personid}') AND(dbo.Udlaan.udlaansStatus = 2)");
            foreach (DataRow row in dt.Rows)
            {
                ClassBog bog = new ClassBog();
                bog.id = Convert.ToInt32(row["id"].ToString());
                bog.titel = row["titel"].ToString();
                bog.genre = row["genreType"].ToString();
                bog.forfatter = row["forfatter"].ToString();
                bog.forlag = row["forlagsNavn"].ToString();
                bog.isbnNr = row["isbnNr"].ToString(); 

                Classudlaan CUD = new Classudlaan();
                CUD.udlaanstatus = row["udlaansStatus"].ToString();

                

            }
            GetAllBooks();
            return GetAllLentToUser(personid);
        }

        public List<ClassBog> GetAvailbleBooks()
        {
            List<ClassBog> listCB = new List<ClassBog>();
            DataTable dt = DbReturnDataTable($"SELECT        dbo.Titel.titel, dbo.Forfatter.forfatter, dbo.Forlag.forlagsNavn, dbo.ISBNnr.isbnNr, dbo.Genre.genreType, dbo.Type.TypeNavn, dbo.Books.pris, dbo.UdlaansStatus.status" +
                $" FROM dbo.Books INNER JOIN" +
                $" dbo.Forfatter ON dbo.Books.forfatterID = dbo.Forfatter.id INNER JOIN" +
                $" dbo.Forlag ON dbo.Books.forlagID = dbo.Forlag.id INNER JOIN" +
                $" dbo.Genre ON dbo.Books.genreID = dbo.Genre.id INNER JOIN" +
                $" dbo.ISBNnr ON dbo.Books.isbnID = dbo.ISBNnr.id INNER JOIN" +
                $" dbo.Type ON dbo.Books.typeID = dbo.Type.id INNER JOIN" +
                $" dbo.Titel ON dbo.Books.titelID = dbo.Titel.id INNER JOIN" +
                $" dbo.UdlaansStatus INNER JOIN" +
                $" dbo.Udlaan ON dbo.UdlaansStatus.id = dbo.Udlaan.udlaansStatus ON " +
                $"dbo.Books.id = dbo.Udlaan.bookID " +
                $"WHERE(dbo.Udlaan.udlaansStatus = 2)");

            foreach(DataRow row in dt.Rows)
            {
                ClassBog bog = new ClassBog();
                bog.id = Convert.ToInt32(row["id"].ToString());
                bog.isbnNr = row["isbnNr"].ToString();
                bog.genre = row["genreType"].ToString();
                bog.titel = row["titel"].ToString();
                bog.forfatter = row["forfatter"].ToString();
                bog.forlag = row["forlagsNavn"].ToString();
                bog.type = row["TypeNavn"].ToString();
                bog.pris = Convert.ToDecimal(row["pris"].ToString());
                listCB.Add(bog);
            }

            return listCB;
        }

        public void UpdateTheLendingStatus(string id, bool status)
        {

        }
        public ClassUser GetUser(string cprNr, string Password)
        {
            string strsql = "SELECT dbo.Person.navn, dbo.Person.adresse, dbo.PersonTelefon.telefonnummer, dbo.PersonMail.mailAdr, " +
                "dbo.Person.rolle FROM dbo.Access LEFT OUTER JOIN" +
                " dbo.Person ON dbo.Access.userId = dbo.Person.id LEFT OUTER JOIN" +
                " dbo.PersonTelefon ON dbo.Person.id = dbo.PersonTelefon.personID LEFT OUTER JOIN" +
                " dbo.PersonMail ON dbo.Person.id = dbo.PersonMail.personID" +
                $"WHERE(dbo.Access.cprNr = '{cprNr}') AND(dbo.Access.password = '{Password}')";
            ClassUser CU = new ClassUser();
            DataTable dt = DbReturnDataTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                CU = new ClassUser();
                CU.userName = row["cprNr"].ToString();
                CU.password = row["password"].ToString();       
                CU.navn = row["navn"].ToString();
                CU.adresse = row["adresse"].ToString();
                CU.telefon = row["navn"].ToString();
                CU.mail = row["navn"].ToString();
                CU.rolle = row["navn"].ToString();
            }

            return CU;
        }
        public void UpdateBook(ClassBog CB)
        {

        }

        public ObservableCollection<string> GetTitles()
        {
            ObservableCollection<string> cTitles = new ObservableCollection<string>();
            string sqlQuery = "SELECT * FROM Titel";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cTitles.Add(row["titel"].ToString());
            }

            return cTitles;
        }
        public ObservableCollection<string> GetAuthors()
        {
            ObservableCollection<string> cAuthors = new ObservableCollection<string>();
            string sqlQuery = "SELECT * FROM Forfatter";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cAuthors.Add(row["forfatter"].ToString());
            }

            return cAuthors;
        }
        public ObservableCollection<string> GetISBNs()
        {
            ObservableCollection<string> cISBN = new ObservableCollection<string>();
            string sqlQuery = "SELECT * FROM ISBNnr";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cISBN.Add(row["isbnNr"].ToString());
            }

            return cISBN;
        }
        public ObservableCollection<string> GetPublishers()
        {
            ObservableCollection<string> cPublisher = new ObservableCollection<string>();
            string sqlQuery = "SELECT * FROM Forlag";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cPublisher.Add(row["forlagsNavn"].ToString());
            }

            return cPublisher;
        }
        public ObservableCollection<string> GetTypes()
        {
            ObservableCollection<string> cTypes = new ObservableCollection<string>();
            string sqlQuery = "SELECT * FROM Type";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cTypes.Add(row["TypeNavn"].ToString());
            }

            return cTypes;
        }
        public ObservableCollection<string> GetGenre()
        {
            ObservableCollection<string> cGenre = new ObservableCollection<string>();
            string sqlQuery = "SELECT * FROM Genre";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cGenre.Add(row["genreType"].ToString());
            }

            return cGenre;
        }
        public ObservableCollection<decimal> GetPrices()
        {
            ObservableCollection<decimal> cPrice = new ObservableCollection<decimal>();
            string sqlQuery = "SELECT * FROM Books";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                cPrice.Add(Convert.ToDecimal(row["pris"].ToString()));
            }

            return cPrice;
        }

    }
}
