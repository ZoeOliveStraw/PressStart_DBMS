
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
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.phonelbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtphone.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtphone.ForeColor = System.Drawing.SystemColors.Window;
            this.txtphone.Location = new System.Drawing.Point(90, 55);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(209, 19);
            this.txtphone.TabIndex = 28;
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtaddress.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtaddress.ForeColor = System.Drawing.SystemColors.Window;
            this.txtaddress.Location = new System.Drawing.Point(90, 15);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(209, 19);
            this.txtaddress.TabIndex = 26;
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.BackColor = System.Drawing.SystemColors.WindowText;
            this.phonelbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phonelbl.ForeColor = System.Drawing.SystemColors.Window;
            this.phonelbl.Location = new System.Drawing.Point(29, 58);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(53, 12);
            this.phonelbl.TabIndex = 24;
            this.phonelbl.Text = "Phone:";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.BackColor = System.Drawing.SystemColors.WindowText;
            this.addresslbl.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addresslbl.ForeColor = System.Drawing.SystemColors.Window;
            this.addresslbl.Location = new System.Drawing.Point(13, 18);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(69, 12);
            this.addresslbl.TabIndex = 22;
            this.addresslbl.Text = "Address:";
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAddStore.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStore.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddStore.Location = new System.Drawing.Point(90, 99);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(116, 57);
            this.btnAddStore.TabIndex = 36;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // FrmAddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PressStart_DBMS.Properties.Resources.istockphoto_1171564349_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(308, 171);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.phonelbl);
            this.Controls.Add(this.addresslbl);
            this.Name = "FrmAddStore";
            this.Text = "FrmAddStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Button btnAddStore;
    }
}