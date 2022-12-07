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
    public partial class FrmCustomers : Form
    {
        DataQueryBuilder dqb;
        public FrmCustomers()
        {
            InitializeComponent();
            PopulateComboBox(cbSearchTerm);
            dqb = new DataQueryBuilder();
            ListCustomers();
        }

        private void ListCustomers()
        {
            DataTable storeData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                storeData = dqb.SelectAllQuery("Customer_Table");
            }
            else
            {
                storeData = dqb.SelectAllQuery("Customer_Table",
                    whereClause: cbSearchTerm.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchTerm.Text);
            }
            dataGridCustomer.DataSource = storeData;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            //This method will open the form for adding a customer
            FrmAddCustomer addCustomers = new FrmAddCustomer();
            addCustomers.ShowDialog();
        }

        private void PopulateComboBox(ComboBox box)
        {
            string[] items = { "Customer_First_Name", "Customer_Last_Name", "Customer_Email", "Customer_Phone" };
            box.Items.AddRange(items);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListCustomers();
        }
    }
}
