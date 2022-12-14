using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressStart_DBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FrmInventorySearch inventorySearchInstance = new FrmInventorySearch();
            inventorySearchInstance.ShowDialog();
        }

        private void btnRepairOrders_Click(object sender, EventArgs e)
        {
            FrmRepairOrderSearch repairOrderSearchInstance = new FrmRepairOrderSearch();
            repairOrderSearchInstance.ShowDialog();
        }

        private void btnStores_Click_1(object sender, EventArgs e)
        {
            FrmStores storesInstance = new FrmStores();
            storesInstance.ShowDialog();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FrmStaff staffInstance = new FrmStaff();
            staffInstance.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers customersInstance = new FrmCustomers();
            customersInstance.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProducts productsInstance = new FrmProducts();
            productsInstance.ShowDialog();
        }

        private void btnProcessPurchase_Click(object sender, EventArgs e)
        {
            FrmProcessPurchase processPurchaseInstance = new FrmProcessPurchase();
            processPurchaseInstance.ShowDialog();
        }

        private void btnTransactionHistory_Click(object sender, EventArgs e)
        {
            FromTransactions transForm = new FromTransactions();
            transForm.ShowDialog();
        }
    }
}
