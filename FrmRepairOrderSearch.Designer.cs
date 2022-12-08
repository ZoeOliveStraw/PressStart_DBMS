
namespace PressStart_DBMS
{
    partial class FrmRepairOrderSearch
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
            this.dataGridRepairOrder = new System.Windows.Forms.DataGridView();
            this.cbSearchTerm = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.For = new System.Windows.Forms.Label();
            this.btnAddRepairOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepairOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRepairOrder
            // 
            this.dataGridRepairOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridRepairOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepairOrder.Location = new System.Drawing.Point(13, 71);
            this.dataGridRepairOrder.Name = "dataGridRepairOrder";
            this.dataGridRepairOrder.RowTemplate.Height = 25;
            this.dataGridRepairOrder.Size = new System.Drawing.Size(775, 367);
            this.dataGridRepairOrder.TabIndex = 0;
            // 
            // cbSearchTerm
            // 
            this.cbSearchTerm.FormattingEnabled = true;
            this.cbSearchTerm.Location = new System.Drawing.Point(63, 23);
            this.cbSearchTerm.Name = "cbSearchTerm";
            this.cbSearchTerm.Size = new System.Drawing.Size(121, 23);
            this.cbSearchTerm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Location = new System.Drawing.Point(243, 23);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(151, 23);
            this.txtSearchTerm.TabIndex = 3;
            // 
            // For
            // 
            this.For.AutoSize = true;
            this.For.Location = new System.Drawing.Point(213, 26);
            this.For.Name = "For";
            this.For.Size = new System.Drawing.Size(24, 15);
            this.For.TabIndex = 4;
            this.For.Text = "For";
            // 
            // btnAddRepairOrder
            // 
            this.btnAddRepairOrder.Location = new System.Drawing.Point(598, 13);
            this.btnAddRepairOrder.Name = "btnAddRepairOrder";
            this.btnAddRepairOrder.Size = new System.Drawing.Size(190, 52);
            this.btnAddRepairOrder.TabIndex = 5;
            this.btnAddRepairOrder.Text = "Add Repair Order";
            this.btnAddRepairOrder.UseVisualStyleBackColor = true;
            this.btnAddRepairOrder.Click += new System.EventHandler(this.btnAddRepairOrder_Click);
            // 
            // FrmRepairOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddRepairOrder);
            this.Controls.Add(this.For);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSearchTerm);
            this.Controls.Add(this.dataGridRepairOrder);
            this.Name = "FrmRepairOrderSearch";
            this.Text = "FrmRepairOrderSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepairOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRepairOrder;
        private System.Windows.Forms.ComboBox cbSearchTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label For;
        private System.Windows.Forms.Button btnAddRepairOrder;
    }
}