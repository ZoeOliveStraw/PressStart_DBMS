
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.cbSearchTerm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbSearchTerm.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSearchTerm.ForeColor = System.Drawing.SystemColors.Window;
            this.cbSearchTerm.FormattingEnabled = true;
            this.cbSearchTerm.Location = new System.Drawing.Point(80, 23);
            this.cbSearchTerm.Name = "cbSearchTerm";
            this.cbSearchTerm.Size = new System.Drawing.Size(159, 20);
            this.cbSearchTerm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearchTerm.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTerm.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchTerm.Location = new System.Drawing.Point(282, 24);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(151, 19);
            this.txtSearchTerm.TabIndex = 3;
            // 
            // For
            // 
            this.For.AutoSize = true;
            this.For.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.For.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.For.ForeColor = System.Drawing.SystemColors.Window;
            this.For.Location = new System.Drawing.Point(252, 27);
            this.For.Name = "For";
            this.For.Size = new System.Drawing.Size(29, 12);
            this.For.TabIndex = 4;
            this.For.Text = "For";
            // 
            // btnAddRepairOrder
            // 
            this.btnAddRepairOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddRepairOrder.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRepairOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddRepairOrder.Location = new System.Drawing.Point(600, 14);
            this.btnAddRepairOrder.Name = "btnAddRepairOrder";
            this.btnAddRepairOrder.Size = new System.Drawing.Size(190, 52);
            this.btnAddRepairOrder.TabIndex = 5;
            this.btnAddRepairOrder.Text = "Add Repair Order";
            this.btnAddRepairOrder.UseVisualStyleBackColor = false;
            this.btnAddRepairOrder.Click += new System.EventHandler(this.btnAddRepairOrder_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(451, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmRepairOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PressStart_DBMS.Properties.Resources.istockphoto_1171564349_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}