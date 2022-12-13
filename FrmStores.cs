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
    public partial class FrmStores : Form
    {
        DataQueryBuilder dqb;
        public FrmStores()
        {
            InitializeComponent();
            dqb = new DataQueryBuilder();
            ListStores();
            PopulateComboBox(cbSearchStores);
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            //This method will open the form for adding a store
            FrmAddStore addStaffs = new FrmAddStore();
            addStaffs.ShowDialog();
        }

        private void ListStores()
        {
            DataTable storeData; //datatable we can use to 
            if (cbSearchStores.SelectedItem == null || txtSearchStores.Text == "")
            {
                storeData = dqb.SelectAllQuery("Store_Table");
            }
            else
            {
                storeData = dqb.SelectAllQuery("Store_Table",
                    whereClause: cbSearchStores.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchStores.Text);
            }
            dataGridStore.DataSource = storeData;
        }

        private void btnSearchStores_Click(object sender, EventArgs e)
        {
            ListStores();
        }

        private void PopulateComboBox(ComboBox box)
        {
            string[] items = { "Store_Table_ID", "Store_Address", "Store_Address" };
            box.Items.AddRange(items);
        }
    }
}
