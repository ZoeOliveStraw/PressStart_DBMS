
namespace PressStart_DBMS
{
    partial class FrmStores
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
            this.btnAddStore = new System.Windows.Forms.Button();
            this.dataGridStore = new System.Windows.Forms.DataGridView();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStore
            // 
            this.btnAddStore.Location = new System.Drawing.Point(599, 13);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(189, 48);
            this.btnAddStore.TabIndex = 0;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = true;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // dataGridStore
            // 
            this.dataGridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStore.Location = new System.Drawing.Point(12, 67);
            this.dataGridStore.Name = "dataGridStore";
            this.dataGridStore.RowTemplate.Height = 25;
            this.dataGridStore.Size = new System.Drawing.Size(776, 371);
            this.dataGridStore.TabIndex = 1;
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Location = new System.Drawing.Point(12, 27);
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(308, 23);
            this.txtSearchAddress.TabIndex = 2;
            // 
            // FrmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSearchAddress);
            this.Controls.Add(this.dataGridStore);
            this.Controls.Add(this.btnAddStore);
            this.Name = "FrmStores";
            this.Text = "Form Stores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.DataGridView dataGridStore;
        private System.Windows.Forms.TextBox txtSearchAddress;
    }
}