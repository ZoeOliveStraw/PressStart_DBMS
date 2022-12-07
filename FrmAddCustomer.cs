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
    public partial class FrmAddCustomer : Form
    {
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string[] columns = 
            { 
                "Customer_First_Name",
                "Customer_Last_Name",
                "Customer_Email",
                "Customer_Phone",
                "Customer_Mailing_List"
            };

            string[] values =
            {
                txtFirstName.Text,
                txtLastName.Text,
                txtEmail.Text,
                txtPhone.Text,
                (chkMailingList.Checked ? "true" : "false")
            };

            DataQueryBuilder dqb = new DataQueryBuilder();
            dqb.InsertQuery("Customer_Table", columns, values);
        }
    }
}
