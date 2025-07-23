namespace MoneyMovePrototype.System_Admin_Functionality
{
    partial class ViewTransactionHistory
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
            this.dgvTransactionHistory = new System.Windows.Forms.DataGridView();
            this.lblTranHistorymeDashboard = new System.Windows.Forms.Label();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTransactionHistory
            // 
            this.dgvTransactionHistory.AllowUserToAddRows = false;
            this.dgvTransactionHistory.AllowUserToDeleteRows = false;
            this.dgvTransactionHistory.AllowUserToOrderColumns = true;
            this.dgvTransactionHistory.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionHistory.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvTransactionHistory.Location = new System.Drawing.Point(25, 247);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.RowHeadersWidth = 102;
            this.dgvTransactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionHistory.Size = new System.Drawing.Size(1035, 388);
            this.dgvTransactionHistory.TabIndex = 19;
            // 
            // lblTranHistorymeDashboard
            // 
            this.lblTranHistorymeDashboard.AutoSize = true;
            this.lblTranHistorymeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranHistorymeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTranHistorymeDashboard.Location = new System.Drawing.Point(15, 30);
            this.lblTranHistorymeDashboard.Name = "lblTranHistorymeDashboard";
            this.lblTranHistorymeDashboard.Size = new System.Drawing.Size(885, 59);
            this.lblTranHistorymeDashboard.TabIndex = 20;
            this.lblTranHistorymeDashboard.Text = "View and filter historic transaction records:";
            // 
            // cmbFilters
            // 
            this.cmbFilters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilters.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilters.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbFilters.FormattingEnabled = true;
            this.cmbFilters.Location = new System.Drawing.Point(25, 168);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(141, 27);
            this.cmbFilters.TabIndex = 21;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilter.Location = new System.Drawing.Point(20, 127);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(141, 29);
            this.lblFilter.TabIndex = 22;
            this.lblFilter.Text = "Filter below:";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFilter.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter.Location = new System.Drawing.Point(198, 168);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(68, 35);
            this.btnFilter.TabIndex = 28;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // ViewTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbFilters);
            this.Controls.Add(this.lblTranHistorymeDashboard);
            this.Controls.Add(this.dgvTransactionHistory);
            this.Name = "ViewTransactionHistory";
            this.Text = "System Transaction History";
            this.Load += new System.EventHandler(this.ViewTransactionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionHistory;
        private System.Windows.Forms.Label lblTranHistorymeDashboard;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnFilter;
    }
}