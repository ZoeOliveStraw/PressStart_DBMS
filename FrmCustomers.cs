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
            dqb = new DataQueryBuilder();
            ListCustomers();
        }

        private void ListCustomers()
        {
            DataTable storeData = dqb.SelectAllQuery("Customer_Table");
            dataGridCustomer.DataSource = storeData;
        }
    }
}
