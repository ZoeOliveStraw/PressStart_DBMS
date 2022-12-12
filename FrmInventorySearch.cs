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
            string[] columns = { "Product_Instance_Table.Product_Instance_ID",
                                 "Product_Table.Product_Name",
                                 "Product_Instance_Table.Product_Instance_Price",
                                 "Product_Instance_Table.Product_Instance_Used"
                                };

            DataTable storeData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                storeData = dqb.SelectInnerJoin
                    (
                        "Product_Instance_Table",
                        columns,
                        "Product_Table",
                        "Product_Instance_Table.Product_Instance_Product_ID",
                        "Product_Table.Product_ID"
                    );
            }
            else
            {
                storeData = dqb.SelectInnerJoin
                    (
                        "Product_Instance_Table",
                        columns,
                        "Product_Table",
                        "Product_Instance_Table.Product_Instance_Product_ID",
                        "Product_Table.Product_ID",
                        whereClause: cbSearchTerm.Text,
                        whereSearchTerm: txtSearchTerm.Text
                    );
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
            string[] items = { "Product_Instance_ID", "Product_Instance_Product_ID", "Product_Instance_Used" };
            box.Items.AddRange(items);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListInventorys();
        }

    }
}
