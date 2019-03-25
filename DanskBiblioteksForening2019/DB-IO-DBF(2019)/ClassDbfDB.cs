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
        public List<ClassBog> GetAllLentToUser(string id)
        {

            return GetAllLentToUser(id);
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

            DataTable dt = DbReturnDataTable(strsql);
            foreach (DataRow row in dt.Rows)
            {
                //userName = Cprnr
                ClassUser CU = new ClassUser();
                CU.userName = row[""]
                ClassPerson CP = new ClassPerson();

                    

            }


            return GetUser(cprNr, Password);
        }
        public void UpdateBook(ClassBog CB)
        {
            
        }
    }
}
