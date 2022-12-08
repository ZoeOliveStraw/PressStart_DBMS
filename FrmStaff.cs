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
    public partial class FrmStaff : Form
    {
        DataQueryBuilder dqb;
        public FrmStaff()
        {
            InitializeComponent();
            PopulateComboBox(cbSearchTerm);
            dqb = new DataQueryBuilder();
            ListStaff();
        }

        private void ListStaff()
        {
            DataTable storeData; //datatable we can use to 
            if (cbSearchTerm.SelectedItem == null || txtSearchTerm.Text == "")
            {
                storeData = dqb.SelectAllQuery("Staff_Table");
            }
            else
            {
                storeData = dqb.SelectAllQuery("Staff_Table",
                    whereClause: cbSearchTerm.SelectedItem.ToString(),
                    whereSearchTerm: txtSearchTerm.Text);
            }
            dataGridStaff.DataSource = storeData;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            //This method will open the form for adding a Staff
            FrmAddStaff addStaffs = new FrmAddStaff();
            addStaffs.ShowDialog();
        }

        private void PopulateComboBox(ComboBox box)
        {
            string[] items = { "Staff_First_Name", "Staff_Last_Name", "Staff_Email", "Staff_Phone" };
            box.Items.AddRange(items);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ListStaff();
        }


    }
}
