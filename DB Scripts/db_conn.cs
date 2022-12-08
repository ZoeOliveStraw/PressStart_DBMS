using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace PressStart_DBMS.DB_Scripts
{
    class db_conn
    {
        public SqlConnection conn;

        public void Initialize()
        {
            conn = new SqlConnection(GenerateConnectionString());
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }
        
        //You need to initialize a unique connection string for your local instance of the database
        //This will return a connection string to the relative location of the database db.mdf file
        private string GenerateConnectionString()
        {
            //string dbFilePath = Path.Combine(Environment.CurrentDirectory, "db.mdf");
            //string connectionString = dbFilePath ;
            //return $"Data Source=(LocalDB)\\MSSQLLocalDB; AttachDbFilename = '{dbFilePath}'; Integrated Security = True";
            //return "Server=DESKTOP-0GT2CJE\\SQLEXPRESS;Initial Catalog=db;Integrated Security=SSPI";
            return Properties.Settings.Default.LoganConnString;
        }
    }
}
