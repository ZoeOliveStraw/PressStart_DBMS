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
    public partial class FrmInventorySearch : Form
    {
        DataQueryBuilder dqb;
        public FrmInventorySearch()
        {
            InitializeComponent();
            PopulateComboBox(cbSearchTerm);
            dqb = new DataQueryBuilder();
            ListInventorys();
        }

        private void ListInventorys()
        {
            DataTable storeData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                storeData = dqb.SelectAllQuery("Product_Instance_Table");
            }
            else
            {
                storeData = dqb.SelectAllQuery("Product_Instance_Table",
                    whereClause: cbSearchTerm.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchTerm.Text);
            }
            dataGridInventory.DataSource = storeData;
        }

        private void btnAddInventory_Click(object sender, EventArgs e)
        {
            //This method will open the form for adding a Inventory
            FrmAddInventory addInventorys = new FrmAddInventory();
            addInventorys.ShowDialog();
        }

        private void PopulateComboBox(ComboBox box)
        {
            string[] items = { "Inventory_First_Name", "Inventory_Last_Name", "Inventory_Email", "Inventory_Phone" };
            box.Items.AddRange(items);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListInventorys();
        }

    }
}
