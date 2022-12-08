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
    public partial class FrmAddInventory : Form
    {
        public FrmAddInventory()
        {
            InitializeComponent();
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            string[] columns =
            {
                "Inventory_First_Name",
                "Inventory_Last_Name",
                "Inventory_Email",
                "Inventory_Start_Date",
                "Inventory_Phone",
                "Inventory_Category",
                "Inventory_Store_ID"
            };

            string[] values =
            {
                txtfname.Text,
                txtlname.Text,
                txtemail.Text,
                txtstartdate.Text,
                txtphone.Text,
                txtcatagory.Text,
                txtstoreid.Text
            };

            DataQueryBuilder dqb = new DataQueryBuilder();
            dqb.InsertQuery("Inventory_Table", columns, values);

        }
    }
}
