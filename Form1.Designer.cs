
namespace PressStart_DBMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnRepairOrders = new System.Windows.Forms.Button();
            this.btnStores = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnInventory.Location = new System.Drawing.Point(12, 12);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(243, 67);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnRepairOrders
            // 
            this.btnRepairOrders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRepairOrders.Location = new System.Drawing.Point(12, 94);
            this.btnRepairOrders.Name = "btnRepairOrders";
            this.btnRepairOrders.Size = new System.Drawing.Size(243, 67);
            this.btnRepairOrders.TabIndex = 1;
            this.btnRepairOrders.Text = "Repair Orders";
            this.btnRepairOrders.UseVisualStyleBackColor = false;
            this.btnRepairOrders.Click += new System.EventHandler(this.btnRepairOrders_Click);
            // 
            // btnStores
            // 
            this.btnStores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStores.Location = new System.Drawing.Point(12, 177);
            this.btnStores.Name = "btnStores";
            this.btnStores.Size = new System.Drawing.Size(243, 67);
            this.btnStores.TabIndex = 2;
            this.btnStores.Text = "Stores";
            this.btnStores.UseVisualStyleBackColor = false;
            this.btnStores.Click += new System.EventHandler(this.btnStores_Click_1);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStaff.Location = new System.Drawing.Point(12, 265);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(243, 67);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCustomers.Location = new System.Drawing.Point(12, 352);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(243, 67);
            this.btnCustomers.TabIndex = 4;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 450);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnStores);
            this.Controls.Add(this.btnRepairOrders);
            this.Controls.Add(this.btnInventory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnRepairOrders;
        private System.Windows.Forms.Button btnStores;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnCustomers;
    }
}

