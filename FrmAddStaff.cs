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
    public partial class FrmAddStaff : Form
    {
        public FrmAddStaff()
        {
            InitializeComponent();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string[] columns =
            {
                "Staff_First_Name",
                "Staff_Last_Name",
                "Staff_Email",
                "Staff_Start_Date",
                "Staff_Phone",
                "Staff_Category",
                "Staff_Store_ID"
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
            dqb.InsertQuery("Staff_Table", columns, values);

        }
    }
}
