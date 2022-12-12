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
    public partial class FrmProcessPurchase : Form
    {
        private string customerName = "ANONYMOUS";
        DataQueryBuilder dqb;

        bool custIDValid = false;
        bool storeIDValid = false;

        string gamesOutput = "";

        private List<string> gameSKUs = new List<string>();


        public FrmProcessPurchase()
        {
            InitializeComponent();
            dqb = new DataQueryBuilder();
        }

        private void GenerateReceiptText()
        {
            string receiptText = "";
            
            receiptText += $"{GetCustomerName()}\n\n";
            receiptText += gamesOutput;

            txtReceiptText.Text = receiptText;
        }

        private string GetStoreInfo()
        {
            return "TODO";
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            GenerateReceiptText();
        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            string newGame = GetGameTitles(txtSku.Text);

            if(!newGame.Equals("ERROR"))
            {
                MessageBox.Show($"Added: {newGame}");
                gameSKUs.Add(txtSku.Text);
                gamesOutput += $"{newGame}\n";
            }
            else
            {
                MessageBox.Show("INVALID GAME ID");
            }
        }

        private void btnFinalizeTransaction_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchGames_Click(object sender, EventArgs e)
        {
            if (txtSearchGameName.Text != string.Empty)
            {
                string[] columns =
            {
                "Product_Instance_Table.Product_Instance_Product_ID",
                "Product_Table.Product_Name",
                "Product_Instance_Table.Product_Instance_Price",
                "Product_Instance_Table.Product_Instance_Used"
            };

                DataTable storeData = dqb.SelectInnerJoinWhereLike
                    (
                        "Product_Instance_Table",
                        columns,
                        "Product_Table",
                        "Product_Instance_Table.Product_Instance_Product_ID",
                        "Product_Table.Product_ID",
                        whereClause: "Product_Table.Product_Name",
                        txtSearchGameName.Text
                    );

                dataGameSearch.DataSource = storeData;
            }
            else MessageBox.Show("Please input game name to search for");
        }

        private string GetGameTitles(string sku)
        {
            string[] columns =
            {
                "Product_Instance_Table.Product_Instance_ID",
                "Product_Table.Product_Name",
                "Product_Instance_Table.Product_Instance_Price"
            };

            DataTable prod = dqb.SelectInnerJoin
                (
                    "Product_Instance_Table",
                    columns,
                    "Product_Table",
                    "Product_Instance_Table.Product_Instance_Product_ID",
                    "Product_Table.Product_ID",
                    whereClause: "Product_Instance_Table.Product_Instance_ID",
                    whereSearchTerm: sku
                );

            if (prod.Rows.Count == 1)
            {
                return $"     {prod.Rows[0]["Product_Name"]}: {prod.Rows[0]["Product_Instance_Price"]}";
            }
            else
            {
                return "ERROR";
            }
        }

        private string GetCustomerName()
        {
            string[] columns =
            {
                "Customer_ID",
                "Customer_First_Name",
                "Customer_Last_Name"
            };

            DataTable cust = dqb.SelectAllQuery
                (
                "Customer_Table",
                columns,
                whereClause: "Customer_ID",
                whereSearchTerm: txtCustomerID.Text
                );

            if (cust.Rows.Count == 1)
            {
                custIDValid = true;
                return $"Customer: {cust.Rows[0]["Customer_First_Name"]} {cust.Rows[0]["Customer_Last_Name"]}";
            }
            else
            {
                custIDValid = false;
                return "\nERROR: Invalid customer ID\n";
            }
        }
    }
}
