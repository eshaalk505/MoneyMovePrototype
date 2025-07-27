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
            this.pbxBackToWelcomePage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToWelcomePage)).BeginInit();
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
            this.dgvTransactionHistory.Location = new System.Drawing.Point(67, 589);
            this.dgvTransactionHistory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dgvTransactionHistory.Name = "dgvTransactionHistory";
            this.dgvTransactionHistory.RowHeadersWidth = 102;
            this.dgvTransactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransactionHistory.Size = new System.Drawing.Size(2760, 925);
            this.dgvTransactionHistory.TabIndex = 19;
            // 
            // lblTranHistorymeDashboard
            // 
            this.lblTranHistorymeDashboard.AutoSize = true;
            this.lblTranHistorymeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranHistorymeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTranHistorymeDashboard.Location = new System.Drawing.Point(42, 297);
            this.lblTranHistorymeDashboard.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTranHistorymeDashboard.Name = "lblTranHistorymeDashboard";
            this.lblTranHistorymeDashboard.Size = new System.Drawing.Size(1734, 146);
            this.lblTranHistorymeDashboard.TabIndex = 20;
            this.lblTranHistorymeDashboard.Text = "View historic transaction records:";
            // 
            // pbxBackToWelcomePage
            // 
            this.pbxBackToWelcomePage.Location = new System.Drawing.Point(37, 31);
            this.pbxBackToWelcomePage.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.pbxBackToWelcomePage.Name = "pbxBackToWelcomePage";
            this.pbxBackToWelcomePage.Size = new System.Drawing.Size(216, 172);
            this.pbxBackToWelcomePage.TabIndex = 25;
            this.pbxBackToWelcomePage.TabStop = false;
            this.pbxBackToWelcomePage.Click += new System.EventHandler(this.pbxBackToWelcomePage_Click);
            // 
            // ViewTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(3957, 1576);
            this.Controls.Add(this.pbxBackToWelcomePage);
            this.Controls.Add(this.lblTranHistorymeDashboard);
            this.Controls.Add(this.dgvTransactionHistory);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ViewTransactionHistory";
            this.Text = "System Transaction History";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToWelcomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTransactionHistory;
        private System.Windows.Forms.Label lblTranHistorymeDashboard;
        private System.Windows.Forms.PictureBox pbxBackToWelcomePage;
    }
}