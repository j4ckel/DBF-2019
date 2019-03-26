using REPO_DBF_2019_;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        public List<ClassBog> GetAllLentToUser(string id)
        {

            return GetAllLentToUser(id);
        }
        public void UpdateTheLendingStatus(string id, bool status)
        {
            string strsql = $"update Udlaan set udlaansStatus = {id} where {status} = bookID";
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


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
        #region gets book titels, authors, etc
        public ObservableCollection<ClassTitle> GetTitles()
        {
            ObservableCollection<ClassTitle> cTitles = new ObservableCollection<ClassTitle>();
            string sqlQuery = "SELECT * FROM Titel";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                ClassTitle title = new ClassTitle();
                title.title = row["titel"].ToString();
                title.id = row["id"].ToString();
                cTitles.Add(title);
            }

            return cTitles;
        }
        
        public ObservableCollection<string> GetAuthors()
        {
            ObservableCollection<ClassAuthors> cAuthors = new ObservableCollection<ClassAuthors>();
            string sqlQuery = "SELECT * FROM Forfatter";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                ClassAuthors authors = new ClassAuthors();
                authors.authors = row["forfatter"].ToString();
                authors.id = row["id"].ToString();
                cAuthors.Add(authors);
            }

            return cAuthors;
        }
        public ObservableCollection<ClassISBN> GetISBNs()
        {
            ObservableCollection<ClassISBN> cISBN = new ObservableCollection<ClassISBN>();
            string sqlQuery = "SELECT * FROM ISBNnr";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                ClassISBN isbn = new ClassISBN();
                isbn.isbn = row["isbnNr"].ToString();
                isbn.id = row["id"].ToString();
                cISBN.Add(isbn);
            }

            return cISBN;
        }
        public ObservableCollection<ClassPublishers> GetPublishers()
        {
            ObservableCollection<ClassPublishers> cPublisher = new ObservableCollection<ClassPublishers>();
            string sqlQuery = "SELECT * FROM Forlag";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                ClassPublishers publishers = new ClassPublishers();
                publishers.publishers = row["forlagsNavn"].ToString();
                publishers.id = row["id"].ToString();
                cPublisher.Add(publishers);
            }

            return cPublisher;
        }
        public ObservableCollection<ClassTypes> GetTypes()
        {
            ObservableCollection<ClassTypes> cTypes = new ObservableCollection<ClassTypes>();
            string sqlQuery = "SELECT * FROM Type";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                ClassTypes types = new ClassTypes();
                types.types = row["TypeNavn"].ToString();
                types.id = row["id"].ToString();
                cTypes.Add(types);
            }

            return cTypes;
        }
        public ObservableCollection<ClassGenre> GetGenre()
        {
            ObservableCollection<ClassGenre> cGenre = new ObservableCollection<ClassGenre>();
            string sqlQuery = "SELECT * FROM Genre";
            DataTable dataTable = DbReturnDataTable(sqlQuery);

            foreach (DataRow row in dataTable.Rows)
            {
                ClassGenre genre = new ClassGenre();
                genre.genre = row["genreType"].ToString();
                genre.id = row["id"].ToString();
                cGenre.Add(genre);
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

        #endregion

        #region updates adds book titels, authors, etc

        public void updatetitel(ClassBog bog)
        {
            try
            {
                string strsql = "UPDATE "
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region adds book titels, authors, etc

        #region addtitel
        public void addtitel(ClassBog bog)
        {
            int intid = 0;
            string strsql = $"INSERT INTO Titel (titel) VALUES('{bog}')";

            try
            {
                intid = FunctionInsertTitel(strsql, bog);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);                 
            }
        }

        protected int FunctionInsertTitel(string strsql, ClassBog inbog)
        {
            int intRES = 0;
            try
            {

                OpenDB();
                using (SqlCommand cmd = new SqlCommand(strsql, ExecuteNonQuery))
                {

                    cmd.Parameters.Add("titel", SqlDbType.NVarChar).Value = inbog.titel;


                    intRES = (int)cmd.ExecuteScalar();
                }

            CloseDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return intRES;
        }
        #endregion
        #endregion
    }
}
