namespace FinalProject
{
    partial class BasicOperations
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbxBOX = new System.Windows.Forms.ListBox();
            this.btnDataGrid = new System.Windows.Forms.Button();
            this.btnAccess = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxBOX
            // 
            this.lbxBOX.FormattingEnabled = true;
            this.lbxBOX.ItemHeight = 12;
            this.lbxBOX.Location = new System.Drawing.Point(12, 69);
            this.lbxBOX.Name = "lbxBOX";
            this.lbxBOX.Size = new System.Drawing.Size(477, 316);
            this.lbxBOX.TabIndex = 11;
            // 
            // btnDataGrid
            // 
            this.btnDataGrid.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDataGrid.Location = new System.Drawing.Point(276, 12);
            this.btnDataGrid.Name = "btnDataGrid";
            this.btnDataGrid.Size = new System.Drawing.Size(75, 23);
            this.btnDataGrid.TabIndex = 10;
            this.btnDataGrid.Text = "DataGrid";
            this.btnDataGrid.UseVisualStyleBackColor = true;
            this.btnDataGrid.Click += new System.EventHandler(this.btnDataGrid_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAccess.Location = new System.Drawing.Point(141, 12);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(75, 23);
            this.btnAccess.TabIndex = 9;
            this.btnAccess.Text = "Access Data ";
            this.btnAccess.UseVisualStyleBackColor = true;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConnect.Location = new System.Drawing.Point(12, 12);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // BasicOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbxBOX);
            this.Controls.Add(this.btnDataGrid);
            this.Controls.Add(this.btnAccess);
            this.Controls.Add(this.btnConnect);
            this.Name = "BasicOperations";
            this.Text = "BasicOperations";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxBOX;
        private System.Windows.Forms.Button btnDataGrid;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.Button btnConnect;
    }
}

