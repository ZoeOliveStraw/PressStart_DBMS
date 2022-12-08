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
    public partial class FrmAddStore : Form
    {
        public FrmAddStore()
        {
            InitializeComponent();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            string[] columns =
            {
                "Store_Address",
                "Store_Phone"
            };

            string[] values =
            {
                txtaddress.Text,
                txtphone.Text
            };

            DataQueryBuilder dqb = new DataQueryBuilder();
            dqb.InsertQuery("Store_Table", columns, values);

        }
    }
}
