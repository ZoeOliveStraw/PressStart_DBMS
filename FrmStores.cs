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
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            //This method will open the form for adding a store
            FrmAddStore addStaffs = new FrmAddStore();
            addStaffs.ShowDialog();
        }

        private void ListStores()
        {
            DataTable storeData = dqb.SelectAllQuery("Store_Table");
            dataGridStore.DataSource = storeData;
        }
    }
}
