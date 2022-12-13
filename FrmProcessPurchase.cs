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

        bool storeIDValid = false;

        string gamesOutput = "";

        private List<string> gameSKUs = new List<string>();
        private List<double> gamePrices = new List<double>();


        public FrmProcessPurchase()
        {
            InitializeComponent();
            dqb = new DataQueryBuilder();
        }

        private void GenerateReceiptText()
        {
            string receiptText = "";
            
            receiptText += $"{GetCustomerName()}" + Environment.NewLine + Environment.NewLine;
            receiptText += gamesOutput;
            receiptText += Environment.NewLine + Environment.NewLine + GetTotal().ToString();
            receiptText += Environment.NewLine + Environment.NewLine + Environment.NewLine +
                GetStore();


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
                gamesOutput += $"{newGame}" + Environment.NewLine;
            }
            else
            {
                MessageBox.Show("INVALID GAME ID");
            }
        }

        private double GetTotal()
        {
            double total = 0;
            foreach(double p in gamePrices)
            {
                total += p;
            }
            return total;
        }

        private void btnFinalizeTransaction_Click(object sender, EventArgs e)
        {
            if(gameSKUs.Count > 0 && txtStoreID.Text != "")
            {
                InsertTransactionRecord();
            }
        }

        private void btnSearchGames_Click(object sender, EventArgs e)
        {
            if (txtSearchGameName.Text != string.Empty)
            {
                string[] columns =
            {
                "Product_Instance_Table.Product_Instance_ID",
                "Product_Table.Product_Name",
                "Product_Instance_Table.Product_Instance_Price",
                "Product_Instance_Table.Product_Instance_Used"
            };

                DataTable storeData = null;
                storeData = dqb.SelectInnerJoinWhereLike
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

            DataTable prod = null;
            prod = dqb.SelectInnerJoin
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
                double thisPrice;
                double.TryParse(prod.Rows[0]["Product_Instance_Price"].ToString(), out thisPrice);
                gamePrices.Add(thisPrice);
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

            DataTable cust = null;
            cust = dqb.SelectAllQuery
                (
                "Customer_Table",
                columns,
                whereClause: "Customer_ID",
                whereSearchTerm: txtCustomerID.Text
                );

            if (cust.Rows.Count == 1)
            {
                return $"Customer: {cust.Rows[0]["Customer_First_Name"]} {cust.Rows[0]["Customer_Last_Name"]}";
            }
            else
            {
                return "\nNO CUSTOMER\n";
            }
        }

        private string GetStore()
        {
            string[] columns =
            {
                "Store_Address",
                "Store_Phone"
            };

            DataTable store = null;

            store = dqb.SelectAllQuery
                (
                "Store_Table",
                columns,
                whereClause: "Store_Table_ID",
                whereSearchTerm: txtStoreID.Text
                );

            if (store.Rows.Count == 1)
            {
                storeIDValid = true;
                return $"Press Start at {store.Rows[0]["Store_Address"]}" + 
                    Environment.NewLine + $"Phone: {store.Rows[0]["Store_Phone"]}";
            }
            else
            {
                storeIDValid = false;
                return "\nERROR: Invalid store ID\n";
            }
        }

        private void InsertTransactionRecord()
        {
            DateTime today = DateTime.Now;

            if(storeIDValid)
            {
                string[] columns =
                {
                    "Transaction_Customer_ID",
                    "Transaction_Store_ID",
                    "Transaction_Date",
                    "Transaction_Amount"
                };

                string[] values =
                {
                    txtCustomerID.Text,
                    txtStoreID.Text,
                    today.Date.ToString("yyyy-MM-dd"),
                    GetTotal().ToString()
                };

                dqb.InsertQuery("Transaction_Table", columns, values);
            }
            else
            {
                MessageBox.Show("Invalid store ID");
            }
        }
    }
}
