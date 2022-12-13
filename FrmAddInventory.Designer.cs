
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
            this.txtPrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtPrice.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrice.Location = new System.Drawing.Point(128, 46);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(209, 19);
            this.txtPrice.TabIndex = 28;
            // 
            // txtProductID
            // 
            this.txtProductID.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtProductID.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtProductID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtProductID.Location = new System.Drawing.Point(128, 8);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(209, 19);
            this.txtProductID.TabIndex = 26;
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.BackColor = System.Drawing.SystemColors.WindowText;
            this.emaillbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emaillbl.ForeColor = System.Drawing.SystemColors.Window;
            this.emaillbl.Location = new System.Drawing.Point(71, 49);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(53, 12);
            this.emaillbl.TabIndex = 24;
            this.emaillbl.Text = "Price:";
            // 
            // fnamelbl
            // 
            this.fnamelbl.AutoSize = true;
            this.fnamelbl.BackColor = System.Drawing.SystemColors.WindowText;
            this.fnamelbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fnamelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.fnamelbl.Location = new System.Drawing.Point(31, 11);
            this.fnamelbl.Name = "fnamelbl";
            this.fnamelbl.Size = new System.Drawing.Size(93, 12);
            this.fnamelbl.TabIndex = 22;
            this.fnamelbl.Text = "Product ID:";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAddProduct.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddProduct.Location = new System.Drawing.Point(12, 238);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(326, 57);
            this.btnAddProduct.TabIndex = 36;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // chkUsed
            // 
            this.chkUsed.AutoSize = true;
            this.chkUsed.BackColor = System.Drawing.SystemColors.WindowText;
            this.chkUsed.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkUsed.ForeColor = System.Drawing.SystemColors.Window;
            this.chkUsed.Location = new System.Drawing.Point(128, 124);
            this.chkUsed.Name = "chkUsed";
            this.chkUsed.Size = new System.Drawing.Size(56, 16);
            this.chkUsed.TabIndex = 37;
            this.chkUsed.Text = "Used";
            this.chkUsed.UseVisualStyleBackColor = false;
            this.chkUsed.CheckedChanged += new System.EventHandler(this.chkUsed_CheckedChanged);
            // 
            // txtStoreID
            // 
            this.txtStoreID.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtStoreID.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtStoreID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStoreID.Location = new System.Drawing.Point(128, 85);
            this.txtStoreID.Name = "txtStoreID";
            this.txtStoreID.Size = new System.Drawing.Size(209, 19);
            this.txtStoreID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(47, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 38;
            this.label1.Text = "Store ID:";
            // 
            // txtSellerID
            // 
            this.txtSellerID.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtSellerID.Enabled = false;
            this.txtSellerID.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSellerID.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSellerID.Location = new System.Drawing.Point(285, 159);
            this.txtSellerID.Name = "txtSellerID";
            this.txtSellerID.Size = new System.Drawing.Size(52, 19);
            this.txtSellerID.TabIndex = 40;
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtCondition.Enabled = false;
            this.txtCondition.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCondition.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCondition.Location = new System.Drawing.Point(285, 195);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(52, 19);
            this.txtCondition.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(128, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "Seller Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.WindowText;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(152, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 43;
            this.label3.Text = "Condition (1-5)";
            // 
            // FrmAddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PressStart_DBMS.Properties.Resources.istockphoto_1171564349_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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