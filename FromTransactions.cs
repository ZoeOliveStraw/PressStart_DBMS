using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PressStart_DBMS.DB_Scripts;

namespace PressStart_DBMS
{
    public partial class FromTransactions : Form
    {
        DataQueryBuilder dqb;

        public FromTransactions()
        {
            InitializeComponent();
            PopulateComboBox(cbSearchTerm);
            dqb = new DataQueryBuilder();
            ListTransactions();
        }

        private void ListTransactions()
        {
            DataTable transactionData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                transactionData = dqb.SelectAllQuery("Transaction_Table");
            }
            else
            {
                transactionData = dqb.SelectAllQuery("Transaction_Table",
                    whereClause: cbSearchTerm.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchTerm.Text);
            }
            dataView.DataSource = transactionData;
        }


        private void PopulateComboBox(ComboBox box)
        {
            string[] items =
                {
                    "Transaction_ID",
                    "Transaction_Store_ID",
                    "Transaction_Date"
                };
            box.Items.AddRange(items);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListTransactions();
        }
    }

}
