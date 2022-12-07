using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PressStart_DBMS.DB_Scripts
{
    class db_conn
    {
        public string connectionString;
        public SqlConnection conn;

        public void Initialize()
        {
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public void Close()
        {
            conn.Close();
        }
        
    }
}
