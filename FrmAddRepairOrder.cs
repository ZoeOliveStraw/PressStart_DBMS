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
    public partial class FrmAddRepairOrder : Form
    {
        public FrmAddRepairOrder()
        {
            InitializeComponent();
        }

        private void btnAddRepairOrder_Click(object sender, EventArgs e)
        {
            string[] columns =
            {
                "Repair_Staff_ID",
                "Repair_Customer_ID",
                "Repair_Order_Date",
                "Repair_Order_Description",
                "Repair_Order_Store_ID"
            };

            string[] values =
            {
                txtStaffID.Text,
                txtCustomerID.Text,
                txtDate.Text,
                txtDescription.Text,
                txtStoreID.Text
            };

            DataQueryBuilder dqb = new DataQueryBuilder();
            dqb.InsertQuery("Repair_Order_Table", columns, values);
        }
    }
}
