
namespace PressStart_DBMS
{
    partial class FrmAddStore
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
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmanagerID = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.manageridlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(125, 100);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(209, 23);
            this.txtphone.TabIndex = 28;
            // 
            // txtmanagerID
            // 
            this.txtmanagerID.Location = new System.Drawing.Point(125, 62);
            this.txtmanagerID.Name = "txtmanagerID";
            this.txtmanagerID.Size = new System.Drawing.Size(209, 23);
            this.txtmanagerID.TabIndex = 27;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(125, 28);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(209, 23);
            this.txtaddress.TabIndex = 26;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Location = new System.Drawing.Point(75, 103);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(44, 15);
            this.phonelbl.TabIndex = 24;
            this.phonelbl.Text = "Phone:";
            // 
            // manageridlbl
            // 
            this.manageridlbl.AutoSize = true;
            this.manageridlbl.Location = new System.Drawing.Point(48, 65);
            this.manageridlbl.Name = "manageridlbl";
            this.manageridlbl.Size = new System.Drawing.Size(71, 15);
            this.manageridlbl.TabIndex = 23;
            this.manageridlbl.Text = "Manager ID:";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(67, 31);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(52, 15);
            this.addresslbl.TabIndex = 22;
            this.addresslbl.Text = "Address:";
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(165, 140);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(116, 57);
            this.btnAddStore.TabIndex = 36;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // FrmAddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(423, 256);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtmanagerID);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.manageridlbl);
            this.Controls.Add(this.addresslbl);
            this.Name = "FrmAddStore";
            this.Text = "FrmAddStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmanagerID;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label manageridlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Button btnAddStore;
    }
}