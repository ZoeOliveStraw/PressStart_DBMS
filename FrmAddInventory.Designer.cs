
namespace PressStart_DBMS
{
    partial class FrmAddInventory
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.emaillbl = new System.Windows.Forms.Label();
            this.fnamelbl = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.chkUsed = new System.Windows.Forms.CheckBox();
            this.txtStoreID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSellerID = new System.Windows.Forms.TextBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(128, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(209, 23);
            this.txtPrice.TabIndex = 28;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(128, 8);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(209, 23);
            this.txtProductID.TabIndex = 26;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Location = new System.Drawing.Point(71, 49);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(36, 15);
            this.emaillbl.TabIndex = 24;
            this.emaillbl.Text = "Price:";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.Location = new System.Drawing.Point(41, 11);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(66, 15);
            this.fnamelbl.TabIndex = 22;
            this.fnamelbl.Text = "Product ID:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 238);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(326, 57);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // chkUsed
            // 
            this.chkUsed.AutoSize = true;
            this.chkUsed.Location = new System.Drawing.Point(128, 124);
            this.chkUsed.Name = "chkUsed";
            this.chkUsed.Size = new System.Drawing.Size(52, 19);
            this.chkUsed.TabIndex = 37;
            this.chkUsed.Text = "Used";
            this.chkUsed.UseVisualStyleBackColor = true;
            this.chkUsed.CheckedChanged += new System.EventHandler(this.chkUsed_CheckedChanged);
            // 
            // txtStoreID
            // 
            this.txtStoreID.Location = new System.Drawing.Point(128, 85);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(209, 23);
            this.txtStoreID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 38;
            this.label1.Text = "Store ID:";
            // 
            // txtSellerID
            // 
            this.txtSellerID.Enabled = false;
            this.txtSellerID.Location = new System.Drawing.Point(128, 159);
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.Size = new System.Drawing.Size(52, 23);
            this.txtSellerID.TabIndex = 40;
            // 
            // txtCondition
            // 
            this.txtCondition.Enabled = false;
            this.txtCondition.Location = new System.Drawing.Point(128, 199);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(52, 23);
            this.txtCondition.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Seller Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Condition (1-5)";
            // 
            // FrmAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(344, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtSellerID);
            this.Controls.Add(this.txtStoreID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkUsed);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.fnamelbl);
            this.Name = "FrmAddInventory";
            this.Text = "FrmAddInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.Label fnamelbl;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.CheckBox chkUsed;
        private System.Windows.Forms.TextBox txtStoreID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSellerID;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}