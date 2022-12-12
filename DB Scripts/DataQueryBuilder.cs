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
        public DataTable SelectAllQuery
            (
                string tableName, 
                string[] columns = null, 
                string whereClause = null, 
                string whereSearchTerm = null
            ) // ARGUMENTS FOR SELECT ALL QUERY
        {
            try
            {
                db_conn cn = new db_conn();
                cn.Initialize();

                ///IF COLUMNS ARE SPECIFIED WE CAN BUILD A STRING WITH THE ADEQUATE COLUMN HEADERS
                string c = "";
                if(columns != null)
                {
                    c = BuildColumns(columns,false);
                }
                ///OTHERWISE WE JUST SELECT ALL COLUMNS
                else
                {
                    c = "*";
                }

                ///CREATE THE SQL QUERY THAT WILL SELECT ALL FROM THE PROVIDED TABLE
                string selectAllFromTable = $"SELECT {c} FROM {tableName}";

                ///ADD OPTIONAL WHERE CLAUSE WHEN APPLICABLE
                if(whereClause != null && whereSearchTerm != null)
                {
                    selectAllFromTable += $" WHERE {whereClause} = '{whereSearchTerm}'";
                }

                selectAllFromTable += ";";

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

        // This method will allow you to quickly build SELECT statements with an inner join to another table and optional
        // WHERE clause
        public DataTable SelectInnerJoin
            (
                string tableName, 
                string[] columns, 
                string innerJoinTable, 
                string localJoinColumn,
                string innerJoinColumn,
                string whereClause = null,
                string whereSearchTerm = null

            ) //ARGUMENTS FOR SELECT INNER JOIN
        {
            try
            {
                db_conn cn = new db_conn();
                cn.Initialize();

                //STRINGS TO START BUILDING THE QUERIES
                string c = BuildColumns(columns, false);

                string selectInnerJoin = $"SELECT {c} FROM {tableName} INNER JOIN {innerJoinTable}" +
                                         $" ON {localJoinColumn} = {innerJoinColumn}";

                ///ADD OPTIONAL WHERE CLAUSE WHEN APPLICABLE
                if (whereClause != null && whereSearchTerm != null)
                {
                    selectInnerJoin += $" WHERE {whereClause} = '{whereSearchTerm}'";
                }

                selectInnerJoin += ";";

                ///RUN THE QUERY BAYBEE
                SqlCommand letsGo = new SqlCommand(selectInnerJoin, cn.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(letsGo);
                DataTable myTable = new DataTable();
                adapter.Fill(myTable);

                cn.Close();

                return myTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        //INSERT A SINGLE VALUE INTO THE REQUESTED TABLE
        //COLUMNS AND VALUES ARE ARRAYS OF RELEVANT VALUES
        public void InsertQuery(string tableName, string[] columns, string[] values)
        {
            if(columns.Length != values.Length)
            {
                MessageBox.Show("Different number of columns and values, please check again");
            }

            try
            {
                db_conn cn = new db_conn();
                cn.Initialize();
                string insertQueryString = $"INSERT INTO {tableName} ({BuildColumns(columns,false)}) VALUES ({BuildColumns(values,true)});";
                SqlCommand insertQuery = new SqlCommand(insertQueryString, cn.conn);
                insertQuery.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show($"Record added into {tableName}");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private string BuildColumns(string[] columns, bool quotes)
        {
            ///CONSTRUCT THE LIST OF COLUMNS FROM THE ARRAY PASSED AS AN ARGUMENT
            string c = ""; //this will store the columns that we're querying from the table
            foreach (string column in columns)
            {
                if (quotes) c += $"'{column}',"; //If we ask for quotes it will wrap each value in single quotes
                else c += $"{column},";
            }
            ///REMOVE THE LAST COMMA FROM THE LIST TO AVOID A SYNTAX ERROR
            c = c.Remove(c.Length - 1, 1);

            return c;
        }

        //Literally just copypasted this from the above function and changed the WHERE = to WHERE LIKE
        //Use this for a search that's a little more generous
        public DataTable SelectInnerJoinWhereLike
        (
            string tableName,
            string[] columns,
            string innerJoinTable,
            string localJoinColumn,
            string innerJoinColumn,
            string whereClause = null,
            string whereSearchTerm = null
        ) //ARGUMENTS FOR SELECT INNER JOIN
        {
            try
            {
                db_conn cn = new db_conn();
                cn.Initialize();

                //STRINGS TO START BUILDING THE QUERIES
                string c = BuildColumns(columns, false);

                string selectInnerJoin = $"SELECT {c} FROM {tableName} INNER JOIN {innerJoinTable}" +
                                         $" ON {localJoinColumn} = {innerJoinColumn}";

                ///ADD OPTIONAL WHERE CLAUSE WHEN APPLICABLE
                if (whereClause != null && whereSearchTerm != null)
                {
                    selectInnerJoin += $" WHERE {whereClause} LIKE '%{whereSearchTerm}%'";
                }

                selectInnerJoin += ";";

                ///RUN THE QUERY BAYBEE
                SqlCommand letsGo = new SqlCommand(selectInnerJoin, cn.conn);
                SqlDataAdapter adapter = new SqlDataAdapter(letsGo);
                DataTable myTable = new DataTable();
                adapter.Fill(myTable);

                cn.Close();

                return myTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
