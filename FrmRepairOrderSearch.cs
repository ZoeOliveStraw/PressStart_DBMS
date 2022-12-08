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
    public partial class FrmRepairOrderSearch : Form
    {
        DataQueryBuilder dqb;
        public FrmRepairOrderSearch()
        {
            InitializeComponent();
            PopulateComboBox(cbSearchTerm);
            dqb = new DataQueryBuilder();
            ListRepairOrders();
        }

        private void ListRepairOrders()
        {
            DataTable storeData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                storeData = dqb.SelectAllQuery("Repair_Order_Table");
            }
            else
            {
                storeData = dqb.SelectAllQuery("Repair_Order_Table",
                    whereClause: cbSearchTerm.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchTerm.Text);
            }
            dataGridRepairOrder.DataSource = storeData;
        }

        private void btnAddRepairOrder_Click(object sender, EventArgs e)
        {
            FrmAddRepairOrder repairAddForm = new FrmAddRepairOrder();
            repairAddForm.ShowDialog();
        }

        private void PopulateComboBox(ComboBox box)
        {
            string[] items = 
            { 
                "Repair_Order_ID",
                "Repair_Customer_ID",
                "Repair_Order_Date",
                "Repair_Order_Description",
                "Repair_Order_Store_ID"
            };
            box.Items.AddRange(items);
        }
    }
}
