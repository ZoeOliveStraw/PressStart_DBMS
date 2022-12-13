
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
            this.txtSearchStores = new System.Windows.Forms.TextBox();
            this.cbSearchStores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchStores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStore)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnAddStore.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStore.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAddStore.Location = new System.Drawing.Point(599, 13);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(189, 48);
            this.btnAddStore.TabIndex = 0;
            this.btnAddStore.Text = "Add Store";
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // dataGridStore
            // 
            this.dataGridStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStore.Location = new System.Drawing.Point(12, 67);
            this.dataGridStore.Name = "dataGridStore";
            this.dataGridStore.RowTemplate.Height = 25;
            this.dataGridStore.Size = new System.Drawing.Size(776, 371);
            this.dataGridStore.TabIndex = 1;
            // 
            // txtSearchStores
            // 
            this.txtSearchStores.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtSearchStores.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchStores.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSearchStores.Location = new System.Drawing.Point(298, 28);
            this.txtSearchStores.Name = "txtSearchStores";
            this.txtSearchStores.Size = new System.Drawing.Size(150, 19);
            this.txtSearchStores.TabIndex = 2;
            // 
            // cbSearchStores
            // 
            this.cbSearchStores.BackColor = System.Drawing.SystemColors.WindowText;
            this.cbSearchStores.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSearchStores.ForeColor = System.Drawing.SystemColors.Window;
            this.cbSearchStores.FormattingEnabled = true;
            this.cbSearchStores.Location = new System.Drawing.Point(75, 28);
            this.cbSearchStores.Name = "cbSearchStores";
            this.cbSearchStores.Size = new System.Drawing.Size(174, 20);
            this.cbSearchStores.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.WindowText;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(255, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "For:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.WindowText;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            // 
            // btnSearchStores
            // 
            this.btnSearchStores.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnSearchStores.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearchStores.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSearchStores.Location = new System.Drawing.Point(465, 21);
            this.btnSearchStores.Name = "btnSearchStores";
            this.btnSearchStores.Size = new System.Drawing.Size(96, 32);
            this.btnSearchStores.TabIndex = 6;
            this.btnSearchStores.Text = "Search";
            this.btnSearchStores.UseVisualStyleBackColor = false;
            this.btnSearchStores.Click += new System.EventHandler(this.btnSearchStores_Click);
            // 
            // FrmStores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::PressStart_DBMS.Properties.Resources.istockphoto_1171564349_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchStores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSearchStores);
            this.Controls.Add(this.txtSearchStores);
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
        private System.Windows.Forms.TextBox txtSearchStores;
        private System.Windows.Forms.ComboBox cbSearchStores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchStores;
    }
}