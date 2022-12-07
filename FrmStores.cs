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
        public FrmStores()
        {
            InitializeComponent();
            ListStores();
        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            
        }

        private void ListStores()
        {
            db_conn myConnection = new db_conn();
            myConnection.Initialize();
            


            myConnection.Close();
        }
    }
}
