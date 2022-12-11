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
    public partial class FrmProducts : Form
    {
        DataQueryBuilder dqb;
        public FrmProducts()
        {
            InitializeComponent();
            PopulateComboBox(cbSearchTerm);
            dqb = new DataQueryBuilder();
            ListProducts();
        }

        private void ListProducts()
        {
            DataTable productData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                productData = dqb.SelectAllQuery("Product_Table");
            }
            else
            {
                productData = dqb.SelectAllQuery("Product_Table",
                    whereClause: cbSearchTerm.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchTerm.Text);
            }
            dataGridView.DataSource = productData;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct addProductInstance = new FrmAddProduct();
            addProductInstance.ShowDialog();
        }

        private void PopulateComboBox(ComboBox box)
        {
            string[] items = { "Product_ID", "Product_Name", "Supplier_Phone", "Supplier_Notes", "Supplier_Contact" };
            box.Items.AddRange(items);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListProducts();
        }
    }
}
