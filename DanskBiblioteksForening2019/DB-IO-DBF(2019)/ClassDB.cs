using System;
using System.Collections.Generic;
// The class uses the System.Data and System.Data.SqlClient .NET libraries to be able to connect and
// communicate with a database. System.Data primarily is used handle datatypes we get
// from the database, and System.Data.SqlClient is for general communications with the database. 
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_IO_DBF_2019_
{
    /// <summary>
    /// The ClassDbCons purpose is to handle the connection to the DB.
    /// </summary>
    class ClassDB
    {
        /// <summary>
        /// The ClassDbCons purpose is to handle the connection to the DB.
        /// </summary>

        public class ClassDbCon
        {

            private string connectionString;
            private SqlConnection con;
            private SqlCommand command;

            /// <summary>
            /// Default constructor with no arguments.
            /// </summary>
            public ClassDbCon()
            {
                //    connectionString = "Server=10.205.44.39,49172;Database=MovieDB_Patrick;User Id=AspIT;Password=Server2012;";
                //    con = new SqlConnection(connectionString);
            }

            /// <summary>
            /// An overload constructor
            /// set the SqlConnection based on the recived string 
            /// Save the connectionstring in the field connectionString and SqlConnection in the field con
            /// </summary>
            /// <param name="yourConString">A string with the connection settings</param>
            public ClassDbCon(string yourConString)
            {
                connectionString = yourConString;
                con = new SqlConnection(connectionString);
            }

            /// <summary>
            /// set the SqlConnection based on the recived string 
            /// Save the connectionstring in the field connectionString and SqlConnection in the field con
            /// </summary>
            /// <param name="yourConString">A string with the connection settings</param>
            protected void SetCon(string yourConString)
            {
                connectionString = yourConString;
                con = new SqlConnection(connectionString);
            }

            /// <summary>
            /// OpenDB is a method that trys to open the connection to the DB
            /// In the "if" statement it checks if con is not null,
            /// and if con.State is == ConnectionState.Closed then it use con.Open.
            /// if ConnectionState is open, or con is null
            /// it will Close the cennection and do recursive call of OpenDB
            /// </summary>
            protected void OpenDB()
            {
                try
                {
                    if (this.con != null && con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    else
                    {
                        CloseDB();
                        OpenDB();
                    }
                }
                catch (SqlException sqlEx)
                {

                    throw sqlEx;
                }
            }

            /// <summary>
            /// This method closes the connection to the DB
            /// It will throw a exception if anything goes wrong
            /// </summary>
            protected void CloseDB()
            {
                try
                {
                    con.Close();
                }
                catch (SqlException sqlEx)
                {

                    throw sqlEx;
                }
            }


            /// <summary> 
            /// This method takes an SQL-query as a parameter.
            /// The res variable holds an integer value that represents the outcome of ExecuteNonQuery.
            /// Field command is set to a new SqlCommand where the SQL-query and connection is defined.
            /// A connection to the database is opened and the SQL-command is executed by calling the
            /// command.ExecuteNonQuery() method. The outcome of the operation is stored in res (1 for succesful,
            /// and 0 for unsuccesful).         
            /// If anything goes wrong, an exception is thrown. 
            /// In Finally the CloseDB() will be called to close the
            /// connection, independed of an exception is thrown or not.
            /// Lastly, res is returned to the method caller.
            /// </summary>
            /// <param name="sqlQuery">String with the SQL-query</param>
            /// <returns>An integer representing the outcome of the execution</returns> 


            protected int ExecuteNonQuery(string sqlQuery)
            {
                int res = 0;
                command = new SqlCommand(sqlQuery, con);
                try
                {
                    OpenDB();
                    res = command.ExecuteNonQuery();
                }
                catch (SqlException sqlEx)
                {

                    throw sqlEx;
                }
                finally
                {
                    CloseDB();

                }
                return res;
            }

            /// <summary>
            /// Method creates a datatable, for values to be put in,
            /// It trys to OpenDB() followed by,
            /// SqlCommand(sql-Query) and SqlDataAdapter(command).
            /// The adapter.Fill(dtRes), will fill the datatable with the data.
            /// finally will CloseDB() even if it goes good or bad.
            /// </summary>
            /// <param name="sqlQuery">String sql-Query</param>
            /// <returns></returns>
            protected DataTable DbReturnDataTable(string sqlQuery)
            {
                DataTable dtRes = new DataTable();
                try
                {
                    OpenDB();

                    using (command = new SqlCommand(sqlQuery, con))
                    using (var adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtRes);
                    }
                }
                catch (SqlException sqlEx)
                {

                    throw sqlEx;
                }
                finally
                {
                    CloseDB();
                }
                return dtRes;
            }
            protected string DbReturnString(string strSql)
            {
                
            }
            protected List<string> DbReturnList(string strSql)
            {

            }
            protected bool DbReturnBool(string strSql)
            {

            }
        }
    }
}
