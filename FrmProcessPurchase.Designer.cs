
namespace PressStart_DBMS
{
    partial class FrmProcessPurchase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGameSearch = new System.Windows.Forms.DataGridView();
            this.txtSearchGameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchGames = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiptText = new System.Windows.Forms.TextBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.btnGenerateReceipt = new System.Windows.Forms.Button();
            this.btnFinalizeTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGameSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGameSearch
            // 
            this.dataGameSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGameSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGameSearch.Location = new System.Drawing.Point(12, 351);
            this.dataGameSearch.Name = "dataGameSearch";
            this.dataGameSearch.RowTemplate.Height = 25;
            this.dataGameSearch.Size = new System.Drawing.Size(624, 87);
            this.dataGameSearch.TabIndex = 0;
            // 
            // txtSearchGameName
            // 
            this.txtSearchGameName.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchGameName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchGameName.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSearchGameName.Location = new System.Drawing.Point(83, 312);
            this.txtSearchGameName.Name = "txtSearchGameName";
            this.txtSearchGameName.Size = new System.Drawing.Size(150, 23);
            this.txtSearchGameName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find Game";
            // 
            // btnSearchGames
            // 
            this.btnSearchGames.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnSearchGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchGames.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchGames.Location = new System.Drawing.Point(239, 308);
            this.btnSearchGames.Name = "btnSearchGames";
            this.btnSearchGames.Size = new System.Drawing.Size(99, 29);
            this.btnSearchGames.TabIndex = 3;
            this.btnSearchGames.Text = "Search";
            this.btnSearchGames.UseVisualStyleBackColor = false;
            this.btnSearchGames.Click += new System.EventHandler(this.btnSearchGames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(343, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Use this to find SKUs for games to add";
            // 
            // txtReceiptText
            // 
            this.txtReceiptText.AcceptsReturn = true;
            this.txtReceiptText.AcceptsTab = true;
            this.txtReceiptText.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtReceiptText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReceiptText.ForeColor = System.Drawing.SystemColors.Control;
            this.txtReceiptText.Location = new System.Drawing.Point(343, 12);
            this.txtReceiptText.Multiline = true;
            this.txtReceiptText.Name = "txtReceiptText";
            this.txtReceiptText.ReadOnly = true;
            this.txtReceiptText.Size = new System.Drawing.Size(293, 281);
            this.txtReceiptText.TabIndex = 5;
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnAddGame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddGame.Location = new System.Drawing.Point(214, 12);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(111, 33);
            this.btnAddGame.TabIndex = 6;
            this.btnAddGame.Text = "Add SKU";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // txtSku
            // 
            this.txtSku.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtSku.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSku.ForeColor = System.Drawing.SystemColors.Control;
            this.txtSku.Location = new System.Drawing.Point(95, 18);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(113, 23);
            this.txtSku.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Product SKU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Customer ID";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCustomerID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtCustomerID.Location = new System.Drawing.Point(95, 61);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(230, 23);
            this.txtCustomerID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(41, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Store ID";
            // 
            // txtStoreID
            // 
            this.txtStoreID.BackColor = System.Drawing.SystemColors.ControlText;
            this.txtStoreID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStoreID.ForeColor = System.Drawing.SystemColors.Control;
            this.txtStoreID.Location = new System.Drawing.Point(95, 99);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(230, 23);
            this.txtStoreID.TabIndex = 12;
            // 
            // btnGenerateReceipt
            // 
            this.btnGenerateReceipt.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnGenerateReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReceipt.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerateReceipt.Location = new System.Drawing.Point(226, 153);
            this.btnGenerateReceipt.Name = "btnGenerateReceipt";
            this.btnGenerateReceipt.Size = new System.Drawing.Size(99, 57);
            this.btnGenerateReceipt.TabIndex = 14;
            this.btnGenerateReceipt.Text = "Generate Receipt";
            this.btnGenerateReceipt.UseVisualStyleBackColor = false;
            this.btnGenerateReceipt.Click += new System.EventHandler(this.btnGenerateReceipt_Click);
            // 
            // btnFinalizeTransaction
            // 
            this.btnFinalizeTransaction.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnFinalizeTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizeTransaction.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFinalizeTransaction.Location = new System.Drawing.Point(226, 217);
            this.btnFinalizeTransaction.Name = "btnFinalizeTransaction";
            this.btnFinalizeTransaction.Size = new System.Drawing.Size(99, 61);
            this.btnFinalizeTransaction.TabIndex = 15;
            this.btnFinalizeTransaction.Text = "Finalize Transaction";
            this.btnFinalizeTransaction.UseVisualStyleBackColor = false;
            this.btnFinalizeTransaction.Click += new System.EventHandler(this.btnFinalizeTransaction_Click);
            // 
            // FrmProcessPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PressStart_DBMS.Properties.Resources.istockphoto_1171564349_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.btnFinalizeTransaction);
            this.Controls.Add(this.btnGenerateReceipt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.txtReceiptText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearchGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchGameName);
            this.Controls.Add(this.dataGameSearch);
            this.Name = "FrmProcessPurchase";
            this.Text = "FrmProcessPurchase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGameSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGameSearch;
        private System.Windows.Forms.TextBox txtSearchGameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiptText;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Button btnGenerateReceipt;
        private System.Windows.Forms.Button btnFinalizeTransaction;
    }
}