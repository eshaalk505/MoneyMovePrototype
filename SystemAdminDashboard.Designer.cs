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
            this.menuStrip1.SuspendLayout();
            this.cmsSusCases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSusCases)).BeginInit();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
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
            this.dgvSusCases.Location = new System.Drawing.Point(40, 178);
            this.dgvSusCases.Name = "dgvSusCases";
            this.dgvSusCases.RowHeadersWidth = 102;
            this.dgvSusCases.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSusCases.Size = new System.Drawing.Size(531, 446);
            this.dgvSusCases.TabIndex = 22;
            // 
            // SystemAdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.dgvSusCases);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcomeDashboard);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SystemAdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsSusCases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSusCases)).EndInit();
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
    }
}