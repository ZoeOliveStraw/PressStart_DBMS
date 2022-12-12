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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("About to add record!");
            string[] columns =
            {
                "Product_Instance_Product_ID",
                "Product_Instance_Price",
                "Product_Instance_Store_ID",
                "Product_Instance_Used",
                "Product_Instance_Customer_ID_Seller",
                "Product_Instance_Condition"
            };

            string[] values = 
            {
                txtProductID.Text,
                txtPrice.Text,
                txtStoreID.Text,
                chkUsed.Checked ? "true":"false",
                txtSellerID.Text,
                txtCondition.Text
            };

            DataQueryBuilder dqb = new DataQueryBuilder();
            dqb.InsertQuery("Product_Instance_Table", columns, values);
        }

        private void chkUsed_CheckedChanged(object sender, EventArgs e)
        {
            txtCondition.Enabled = chkUsed.Checked;
            txtSellerID.Enabled = chkUsed.Checked;
        }
    }
}
