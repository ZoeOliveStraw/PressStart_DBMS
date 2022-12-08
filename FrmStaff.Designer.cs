
namespace PressStart_DBMS
{
    partial class FrmStaff
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
            this.dataGridStaff = new System.Windows.Forms.DataGridView();
            this.cbSearchTerm = new System.Windows.Forms.ComboBox();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStaff
            // 
            this.dataGridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStaff.Location = new System.Drawing.Point(12, 89);
            this.dataGridStaff.Name = "dataGridStaff";
            this.dataGridStaff.RowTemplate.Height = 25;
            this.dataGridStaff.Size = new System.Drawing.Size(776, 349);
            this.dataGridStaff.TabIndex = 0;
            // 
            // cbSearchTerm
            // 
            this.cbSearchTerm.FormattingEnabled = true;
            this.cbSearchTerm.Location = new System.Drawing.Point(58, 35);
            this.cbSearchTerm.Name = "cbSearchTerm";
            this.cbSearchTerm.Size = new System.Drawing.Size(158, 23);
            this.cbSearchTerm.TabIndex = 1;
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(258, 35);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(177, 23);
            this.txtSearchTerm.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(7, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "For:";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Location = new System.Drawing.Point(668, 23);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(120, 45);
            this.btnAddStaff.TabIndex = 5;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(441, 35);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmStaffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.cbSearchTerm);
            this.Controls.Add(this.dataGridStaff);
            this.Name = "FrmStaffs";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridStaff;
        private System.Windows.Forms.ComboBox cbSearchTerm;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnSearch;
    }
}