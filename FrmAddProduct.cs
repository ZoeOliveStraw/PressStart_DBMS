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
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddRepairOrder_Click(object sender, EventArgs e)
        {
            string[] columns =
            {
                "Product_Name",
                "Supplier_Phone",
                "Supplier_Notes",
                "Supplier_Contact"
            };

            string[] values =
            {
                txtProductName.Text,
                txtSupplierPhone.Text,
                txtSupplierNotes.Text,
                txtSupplierContact.Text
            };

            DataQueryBuilder dqb = new DataQueryBuilder();
            dqb.InsertQuery("Product_Table", columns, values);
        }
    }
}
