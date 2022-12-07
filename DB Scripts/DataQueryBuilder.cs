using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PressStart_DBMS.DB_Scripts
{
    //This script will return the contents for a DataGridView from queries that you can build with its arguments
    class DataQueryBuilder
    {
        public DataTable SelectAllQuery(string tableName, string[] columns = null)
        {
            try
            {
                db_conn cn = new db_conn();
                cn.Initialize();

                ///IF COLUMNS ARE SPECIFIED WE CAN BUILD A STRING WITH THE ADEQUATE COLUMN HEADERS
                string c = "";
                if(columns != null)
                {
                    c = BuildColumns(columns);
                }
                ///OTHERWISE WE JUST SELECT ALL COLUMNS
                else
                {
                    c = "*";
                }

                ///CREATE THE SQL QUERY THAT WILL SELECT ALL FROM THE PROVIDED TABLE
                string selectAllFromTable = $"SELECT {c} FROM {tableName};";

                ///RUN THE QUERY BAYBEE
                SqlCommand letsGo = new SqlCommand(selectAllFromTable, cn.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(letsGo);
                DataTable myTable = new DataTable();
                adapter.Fill(myTable);

                cn.Close();

                return myTable;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        private string BuildColumns(string[] columns)
        {
            ///CONSTRUCT THE LIST OF COLUMNS FROM THE ARRAY PASSED AS AN ARGUMENT
            string c = ""; //this will store the columns that we're querying from the table
            foreach (string column in columns)
            {
                c += $"{column},";
            }
            ///REMOVE THE LAST COMMA FROM THE 
            c = c.Remove(c.Length - 1, 1);

            return c;
        }
    }
}
