
namespace PressStart_DBMS
{
    partial class FrmAddProduct
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
            this.txtSupplierContact = new System.Windows.Forms.TextBox();
            this.txtSupplierNotes = new System.Windows.Forms.TextBox();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRepairOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSupplierContact
            // 
            this.txtSupplierContact.Location = new System.Drawing.Point(137, 125);
            this.txtSupplierContact.Name = "txtSupplierContact";
            this.txtSupplierContact.Size = new System.Drawing.Size(209, 23);
            this.txtSupplierContact.TabIndex = 30;
            // 
            // txtSupplierNotes
            // 
            this.txtSupplierNotes.Location = new System.Drawing.Point(137, 91);
            this.txtSupplierNotes.Name = "txtSupplierNotes";
            this.txtSupplierNotes.Size = new System.Drawing.Size(209, 23);
            this.txtSupplierNotes.TabIndex = 29;
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.Location = new System.Drawing.Point(137, 53);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.Size = new System.Drawing.Size(209, 23);
            this.txtSupplierPhone.TabIndex = 28;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(137, 19);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(209, 23);
            this.txtProductName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Supplier Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Supplier Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Supplier Phone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product Name";
            // 
            // btnAddRepairOrder
            // 
            this.btnAddRepairOrder.Location = new System.Drawing.Point(10, 237);
            this.btnAddRepairOrder.Name = "btnAddRepairOrder";
            this.btnAddRepairOrder.Size = new System.Drawing.Size(336, 57);
            this.btnAddRepairOrder.TabIndex = 22;
            this.btnAddRepairOrder.Text = "Add Product";
            this.btnAddRepairOrder.UseVisualStyleBackColor = true;
            this.btnAddRepairOrder.Click += new System.EventHandler(this.btnAddRepairOrder_Click);
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(359, 306);
            this.Controls.Add(this.txtSupplierContact);
            this.Controls.Add(this.txtSupplierNotes);
            this.Controls.Add(this.txtSupplierPhone);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddRepairOrder);
            this.Name = "FrmAddProduct";
            this.Text = "FrmAddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSupplierContact;
        private System.Windows.Forms.TextBox txtSupplierNotes;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRepairOrder;
    }
}