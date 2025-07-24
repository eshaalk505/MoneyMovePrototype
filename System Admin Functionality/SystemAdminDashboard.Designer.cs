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
            this.components = new System.ComponentModel.Container();
            this.lblWelcomeDashboard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutMoneyMoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsSusCases = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewCaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSusCases = new System.Windows.Forms.DataGridView();
            this.pbxBackToWelcomePage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewTransactionHistory = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.cmsSusCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSusCases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToWelcomePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeDashboard
            // 
            this.lblWelcomeDashboard.AutoSize = true;
            this.lblWelcomeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcomeDashboard.Location = new System.Drawing.Point(30, 104);
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
            this.label2.Location = new System.Drawing.Point(44, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage suspicious transaction cases:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMoneyMoveToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1484, 31);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutMoneyMoveToolStripMenuItem
            // 
            this.aboutMoneyMoveToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.aboutMoneyMoveToolStripMenuItem.Name = "aboutMoneyMoveToolStripMenuItem";
            this.aboutMoneyMoveToolStripMenuItem.Size = new System.Drawing.Size(179, 27);
            this.aboutMoneyMoveToolStripMenuItem.Text = "About MoneyMove";
            this.aboutMoneyMoveToolStripMenuItem.Click += new System.EventHandler(this.aboutMoneyMoveToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // cmsSusCases
            // 
            this.cmsSusCases.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsSusCases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCaseDetailsToolStripMenuItem});
            this.cmsSusCases.Name = "cmsSusCases";
            this.cmsSusCases.Size = new System.Drawing.Size(181, 26);
            // 
            // viewCaseDetailsToolStripMenuItem
            // 
            this.viewCaseDetailsToolStripMenuItem.Name = "viewCaseDetailsToolStripMenuItem";
            this.viewCaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewCaseDetailsToolStripMenuItem.Text = "Manage case details";
            this.viewCaseDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewCaseDetailsToolStripMenuItem_Click);
            // 
            // dgvSusCases
            // 
            this.dgvSusCases.AllowUserToAddRows = false;
            this.dgvSusCases.AllowUserToDeleteRows = false;
            this.dgvSusCases.AllowUserToOrderColumns = true;
            this.dgvSusCases.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvSusCases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSusCases.ContextMenuStrip = this.cmsSusCases;
            this.dgvSusCases.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvSusCases.Location = new System.Drawing.Point(51, 251);
            this.dgvSusCases.Name = "dgvSusCases";
            this.dgvSusCases.ReadOnly = true;
            this.dgvSusCases.RowHeadersWidth = 102;
            this.dgvSusCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSusCases.Size = new System.Drawing.Size(861, 398);
            this.dgvSusCases.TabIndex = 22;
            // 
            // pbxBackToWelcomePage
            // 
            this.pbxBackToWelcomePage.Location = new System.Drawing.Point(14, 28);
            this.pbxBackToWelcomePage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxBackToWelcomePage.Name = "pbxBackToWelcomePage";
            this.pbxBackToWelcomePage.Size = new System.Drawing.Size(81, 72);
            this.pbxBackToWelcomePage.TabIndex = 25;
            this.pbxBackToWelcomePage.TabStop = false;
            this.pbxBackToWelcomePage.Click += new System.EventHandler(this.pbxBackToWelcomePage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1033, 500);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 150);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewTransactionHistory
            // 
            this.btnViewTransactionHistory.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnViewTransactionHistory.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTransactionHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnViewTransactionHistory.Location = new System.Drawing.Point(1091, 529);
            this.btnViewTransactionHistory.Margin = new System.Windows.Forms.Padding(1);
            this.btnViewTransactionHistory.Name = "btnViewTransactionHistory";
            this.btnViewTransactionHistory.Size = new System.Drawing.Size(309, 89);
            this.btnViewTransactionHistory.TabIndex = 27;
            this.btnViewTransactionHistory.Text = "View Transaction History Trail";
            this.btnViewTransactionHistory.UseVisualStyleBackColor = false;
            this.btnViewTransactionHistory.Click += new System.EventHandler(this.btnViewTransactionHistory_Click);
            // 
            // SystemAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnViewTransactionHistory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbxBackToWelcomePage);
            this.Controls.Add(this.dgvSusCases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcomeDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dashboard";
            this.Load += new System.EventHandler(this.SystemAdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsSusCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSusCases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToWelcomePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutMoneyMoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsSusCases;
        private System.Windows.Forms.ToolStripMenuItem viewCaseDetailsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvSusCases;
        private System.Windows.Forms.PictureBox pbxBackToWelcomePage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewTransactionHistory;
    }
}