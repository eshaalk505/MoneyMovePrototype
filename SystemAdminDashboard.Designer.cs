namespace MoneyMovePrototype
{
    partial class SystemAdminDashboard
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
            this.lblWelcomeDashboard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCurrentAccounts = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutMoneyMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAccounts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeDashboard
            // 
            this.lblWelcomeDashboard.AutoSize = true;
            this.lblWelcomeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcomeDashboard.Location = new System.Drawing.Point(26, 27);
            this.lblWelcomeDashboard.Name = "lblWelcomeDashboard";
            this.lblWelcomeDashboard.Size = new System.Drawing.Size(485, 59);
            this.lblWelcomeDashboard.TabIndex = 1;
            this.lblWelcomeDashboard.Text = "Welcome back *name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(40, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage suspicious transaction cases:";
            // 
            // dgvCurrentAccounts
            // 
            this.dgvCurrentAccounts.AllowUserToAddRows = false;
            this.dgvCurrentAccounts.AllowUserToDeleteRows = false;
            this.dgvCurrentAccounts.AllowUserToOrderColumns = true;
            this.dgvCurrentAccounts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCurrentAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentAccounts.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvCurrentAccounts.Location = new System.Drawing.Point(47, 180);
            this.dgvCurrentAccounts.Name = "dgvCurrentAccounts";
            this.dgvCurrentAccounts.RowHeadersWidth = 102;
            this.dgvCurrentAccounts.Size = new System.Drawing.Size(718, 467);
            this.dgvCurrentAccounts.TabIndex = 19;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMoneyMoveToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutMoneyMoveToolStripMenuItem
            // 
            this.aboutMoneyMoveToolStripMenuItem.Name = "aboutMoneyMoveToolStripMenuItem";
            this.aboutMoneyMoveToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.aboutMoneyMoveToolStripMenuItem.Text = "About MoneyMove";
            this.aboutMoneyMoveToolStripMenuItem.Click += new System.EventHandler(this.aboutMoneyMoveToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // SystemAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.dgvCurrentAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcomeDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAccounts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCurrentAccounts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutMoneyMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}