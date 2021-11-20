namespace A107222023_University
{
    partial class frmDataGridView
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
            this.lbxTables = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbxTables = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxTables
            // 
            this.lbxTables.FormattingEnabled = true;
            this.lbxTables.ItemHeight = 12;
            this.lbxTables.Location = new System.Drawing.Point(159, 12);
            this.lbxTables.Name = "lbxTables";
            this.lbxTables.Size = new System.Drawing.Size(104, 88);
            this.lbxTables.TabIndex = 7;
            this.lbxTables.SelectedIndexChanged += new System.EventHandler(this.lbxTables_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(22, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbxTables
            // 
            this.cbxTables.FormattingEnabled = true;
            this.cbxTables.Location = new System.Drawing.Point(332, 12);
            this.cbxTables.Name = "cbxTables";
            this.cbxTables.Size = new System.Drawing.Size(121, 20);
            this.cbxTables.TabIndex = 9;
            this.cbxTables.SelectedIndexChanged += new System.EventHandler(this.cbxTables_SelectedIndexChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 106);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(731, 332);
            this.dataGridView.TabIndex = 10;
            this.dataGridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowValidated);
            // 
            // frmDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.cbxTables);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbxTables);
            this.Name = "frmDataGridView";
            this.Text = "DB_DataGridView";
            this.Load += new System.EventHandler(this.frmDataGridView_Load);
            this.Leave += new System.EventHandler(this.frmDataGridView_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTables;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbxTables;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}