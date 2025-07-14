namespace MoneyMovePrototype
{
    partial class CreateNewCurrencyAccount
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
            this.lblAccountProvider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAccountCurrency = new System.Windows.Forms.ComboBox();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeDashboard
            // 
            this.lblWelcomeDashboard.AutoSize = true;
            this.lblWelcomeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcomeDashboard.Location = new System.Drawing.Point(21, 30);
            this.lblWelcomeDashboard.Name = "lblWelcomeDashboard";
            this.lblWelcomeDashboard.Size = new System.Drawing.Size(860, 59);
            this.lblWelcomeDashboard.TabIndex = 1;
            this.lblWelcomeDashboard.Text = "Please provide the required details below:";
            // 
            // lblAccountProvider
            // 
            this.lblAccountProvider.AutoSize = true;
            this.lblAccountProvider.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountProvider.Location = new System.Drawing.Point(26, 139);
            this.lblAccountProvider.Name = "lblAccountProvider";
            this.lblAccountProvider.Size = new System.Drawing.Size(337, 29);
            this.lblAccountProvider.TabIndex = 5;
            this.lblAccountProvider.Text = "Name of new currency account:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select currency:";
            // 
            // cmbAccountCurrency
            // 
            this.cmbAccountCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountCurrency.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountCurrency.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbAccountCurrency.FormattingEnabled = true;
            this.cmbAccountCurrency.Items.AddRange(new object[] {
            "Great British Pound",
            "Euro",
            "Australian Dollar",
            "US Dollar",
            "Japanese Yen",
            "Canadian Dollar",
            "Pakistani Rupee",
            "Indian Rupee",
            "Swiss Franc",
            "New Zealand Dollar"});
            this.cmbAccountCurrency.Location = new System.Drawing.Point(221, 228);
            this.cmbAccountCurrency.Name = "cmbAccountCurrency";
            this.cmbAccountCurrency.Size = new System.Drawing.Size(169, 27);
            this.cmbAccountCurrency.TabIndex = 9;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAccountName.Location = new System.Drawing.Point(369, 141);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(198, 27);
            this.txtAccountName.TabIndex = 22;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCreateAccount.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCreateAccount.Location = new System.Drawing.Point(1206, 540);
            this.btnCreateAccount.Margin = new System.Windows.Forms.Padding(1);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(232, 89);
            this.btnCreateAccount.TabIndex = 23;
            this.btnCreateAccount.Text = "Create new account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // CreateNewCurrencyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtAccountName);
            this.Controls.Add(this.cmbAccountCurrency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccountProvider);
            this.Controls.Add(this.lblWelcomeDashboard);
            this.Name = "CreateNewCurrencyAccount";
            this.Text = "Create New Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeDashboard;
        private System.Windows.Forms.Label lblAccountProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccountCurrency;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}