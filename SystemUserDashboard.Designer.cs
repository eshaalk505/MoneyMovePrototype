namespace MoneyMovePrototype
{
    partial class SystemUserDashboard
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvCurrentAccounts = new System.Windows.Forms.DataGridView();
            this.cmsForDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewAccountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msDashboard = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesignatedAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAccounts)).BeginInit();
            this.cmsForDGV.SuspendLayout();
            this.msDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeDashboard
            // 
            this.lblWelcomeDashboard.AutoSize = true;
            this.lblWelcomeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcomeDashboard.Location = new System.Drawing.Point(21, 36);
            this.lblWelcomeDashboard.Name = "lblWelcomeDashboard";
            this.lblWelcomeDashboard.Size = new System.Drawing.Size(485, 59);
            this.lblWelcomeDashboard.TabIndex = 0;
            this.lblWelcomeDashboard.Text = "Welcome back *name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(33, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "View your current accounts:";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(1102, 130);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(309, 89);
            this.btnLogin.TabIndex = 15;
            this.btnLogin.Text = "View Currency Exchange Rates";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Location = new System.Drawing.Point(1042, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 564);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1102, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(309, 89);
            this.button1.TabIndex = 15;
            this.button1.Text = "Create a New Currency Account";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1102, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(309, 89);
            this.button2.TabIndex = 17;
            this.button2.Text = "Transfer Funds between Currency Accounts";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dgvCurrentAccounts
            // 
            this.dgvCurrentAccounts.AllowUserToAddRows = false;
            this.dgvCurrentAccounts.AllowUserToDeleteRows = false;
            this.dgvCurrentAccounts.AllowUserToOrderColumns = true;
            this.dgvCurrentAccounts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCurrentAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentAccounts.ContextMenuStrip = this.cmsForDGV;
            this.dgvCurrentAccounts.GridColor = System.Drawing.Color.MidnightBlue;
            this.dgvCurrentAccounts.Location = new System.Drawing.Point(40, 180);
            this.dgvCurrentAccounts.Name = "dgvCurrentAccounts";
            this.dgvCurrentAccounts.RowHeadersWidth = 102;
            this.dgvCurrentAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentAccounts.Size = new System.Drawing.Size(531, 467);
            this.dgvCurrentAccounts.TabIndex = 18;
            // 
            // cmsForDGV
            // 
            this.cmsForDGV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmsForDGV.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.cmsForDGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAccountDetailsToolStripMenuItem});
            this.cmsForDGV.Name = "cmsForDGV";
            this.cmsForDGV.Size = new System.Drawing.Size(186, 26);
            // 
            // viewAccountDetailsToolStripMenuItem
            // 
            this.viewAccountDetailsToolStripMenuItem.Name = "viewAccountDetailsToolStripMenuItem";
            this.viewAccountDetailsToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewAccountDetailsToolStripMenuItem.Text = "View Account Details";
            this.viewAccountDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewAccountDetailsToolStripMenuItem_Click);
            // 
            // msDashboard
            // 
            this.msDashboard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.msDashboard.Location = new System.Drawing.Point(0, 0);
            this.msDashboard.Name = "msDashboard";
            this.msDashboard.Size = new System.Drawing.Size(1484, 24);
            this.msDashboard.TabIndex = 19;
            this.msDashboard.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.logoutToolStripMenuItem.Text = "About MoneyMove";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // btnDesignatedAccount
            // 
            this.btnDesignatedAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDesignatedAccount.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesignatedAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDesignatedAccount.Location = new System.Drawing.Point(1102, 261);
            this.btnDesignatedAccount.Margin = new System.Windows.Forms.Padding(1);
            this.btnDesignatedAccount.Name = "btnDesignatedAccount";
            this.btnDesignatedAccount.Size = new System.Drawing.Size(309, 89);
            this.btnDesignatedAccount.TabIndex = 20;
            this.btnDesignatedAccount.Text = "Manage Designated UK Bank Account";
            this.btnDesignatedAccount.UseVisualStyleBackColor = false;
            this.btnDesignatedAccount.Click += new System.EventHandler(this.btnDesignatedAccount_Click);
            // 
            // SystemUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnDesignatedAccount);
            this.Controls.Add(this.msDashboard);
            this.Controls.Add(this.dgvCurrentAccounts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWelcomeDashboard);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.msDashboard;
            this.Name = "SystemUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentAccounts)).EndInit();
            this.cmsForDGV.ResumeLayout(false);
            this.msDashboard.ResumeLayout(false);
            this.msDashboard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeDashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvCurrentAccounts;
        private System.Windows.Forms.ContextMenuStrip cmsForDGV;
        private System.Windows.Forms.ToolStripMenuItem viewAccountDetailsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip msDashboard;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.Button btnDesignatedAccount;
    }
}