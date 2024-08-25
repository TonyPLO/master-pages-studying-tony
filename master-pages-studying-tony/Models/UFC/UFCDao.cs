using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace master_pages_studying_tony.Models.UFC
{
    public class UFCDao
    {
        //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LearnSQL;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LearnSQL;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public static void CreateInitialTables()
        {
            //in new versions "using"
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                Debug.WriteLine("Connected Succesfully");
                //@ בשביל הרבה שורות
                string query = @"
                IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='UFC_Fighters_app' AND xtype='U')
                CREATE TABLE UFC_Fighters_app(
                id int,
                Name varchar(255),
                Height int,
                Birthday Date
                );";
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex) //אם יקרה שגיאה 
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            finally // קורה בכל מצב
            {
                connection.Close();
            }
        }
        public static void AddFighter(UFCFighterDB fighter1)
        {
            //in new versions "using"
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(connectionString);
                Debug.WriteLine("Connected Succesfully");
                connection.Open();
                //VALUES (@username, @password, @email ,@commentLingar)
                string query = @"
                insert into ufc_fighters_app 
                values (@Id,@Name,@Height,@Birthday);";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                //כאן מכניסים את הערכים לתוך השאילתא
                sqlCommand.Parameters.AddWithValue("@id", fighter1.Id);
                sqlCommand.Parameters.AddWithValue("@Name", fighter1.Name);
                sqlCommand.Parameters.AddWithValue("@Height", fighter1.Height);
                sqlCommand.Parameters.AddWithValue("@Birthday", fighter1.Birthday);
                int rowsAffected = sqlCommand.ExecuteNonQuery();
                Debug.WriteLine($"Rows inserted: {rowsAffected}");
            }
            catch (Exception ex) //אם יקרה שגיאה 
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
            finally // קורה בכל מצב
            {
                connection.Close();
            }
        }
    }
    //--CREATE TABLE UFC_Fighters(
    //--id int,
    //--Name varchar(255),
    //--Height int,
    //--Birthday Date
    //--);
}