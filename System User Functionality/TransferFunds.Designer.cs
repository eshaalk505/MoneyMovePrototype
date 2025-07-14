namespace MoneyMovePrototype
{
    partial class TransferFunds
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
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblAmountToTransfer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSourceAccounts = new System.Windows.Forms.ComboBox();
            this.cmbTargetAccounts = new System.Windows.Forms.ComboBox();
            this.btnTransferFunds = new System.Windows.Forms.Button();
            this.lblAccountWarning = new System.Windows.Forms.Label();
            this.txtAmountToTransfer = new System.Windows.Forms.TextBox();
            this.lblAmountReceived = new System.Windows.Forms.Label();
            this.txtAmountInTarget = new System.Windows.Forms.TextBox();
            this.lblTransferFormatWarning = new System.Windows.Forms.Label();
            this.lblErrorsAndWarnings = new System.Windows.Forms.Label();
            this.btnPreviewAmount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeDashboard
            // 
            this.lblWelcomeDashboard.AutoSize = true;
            this.lblWelcomeDashboard.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblWelcomeDashboard.Location = new System.Drawing.Point(12, 27);
            this.lblWelcomeDashboard.Name = "lblWelcomeDashboard";
            this.lblWelcomeDashboard.Size = new System.Drawing.Size(1106, 59);
            this.lblWelcomeDashboard.TabIndex = 1;
            this.lblWelcomeDashboard.Text = "Transfer between your MoneyMove currency accounts";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCurrency.Location = new System.Drawing.Point(29, 127);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(247, 29);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Select source account: ";
            // 
            // lblAmountToTransfer
            // 
            this.lblAmountToTransfer.AutoSize = true;
            this.lblAmountToTransfer.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToTransfer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAmountToTransfer.Location = new System.Drawing.Point(29, 273);
            this.lblAmountToTransfer.Name = "lblAmountToTransfer";
            this.lblAmountToTransfer.Size = new System.Drawing.Size(295, 29);
            this.lblAmountToTransfer.TabIndex = 7;
            this.lblAmountToTransfer.Text = "Specify amount to transfer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(716, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Select target account:";
            // 
            // cmbSourceAccounts
            // 
            this.cmbSourceAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSourceAccounts.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSourceAccounts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbSourceAccounts.FormattingEnabled = true;
            this.cmbSourceAccounts.Items.AddRange(new object[] {
            "HSBC",
            "Lloyds Bank",
            "Barclays",
            "NatWest",
            "Metro Bank",
            "Santander UK",
            "Nationwide",
            "Halifax",
            "The Co-operative Bank",
            "Virgin Money UK",
            "Other"});
            this.cmbSourceAccounts.Location = new System.Drawing.Point(271, 129);
            this.cmbSourceAccounts.Name = "cmbSourceAccounts";
            this.cmbSourceAccounts.Size = new System.Drawing.Size(141, 27);
            this.cmbSourceAccounts.TabIndex = 9;
            // 
            // cmbTargetAccounts
            // 
            this.cmbTargetAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTargetAccounts.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTargetAccounts.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbTargetAccounts.FormattingEnabled = true;
            this.cmbTargetAccounts.Items.AddRange(new object[] {
            "HSBC",
            "Lloyds Bank",
            "Barclays",
            "NatWest",
            "Metro Bank",
            "Santander UK",
            "Nationwide",
            "Halifax",
            "The Co-operative Bank",
            "Virgin Money UK",
            "Other"});
            this.cmbTargetAccounts.Location = new System.Drawing.Point(960, 129);
            this.cmbTargetAccounts.Name = "cmbTargetAccounts";
            this.cmbTargetAccounts.Size = new System.Drawing.Size(141, 27);
            this.cmbTargetAccounts.TabIndex = 10;
            this.cmbTargetAccounts.SelectedIndexChanged += new System.EventHandler(this.cmbTargetAccounts_SelectedIndexChanged);
            // 
            // btnTransferFunds
            // 
            this.btnTransferFunds.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransferFunds.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferFunds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransferFunds.Location = new System.Drawing.Point(1242, 541);
            this.btnTransferFunds.Margin = new System.Windows.Forms.Padding(1);
            this.btnTransferFunds.Name = "btnTransferFunds";
            this.btnTransferFunds.Size = new System.Drawing.Size(198, 89);
            this.btnTransferFunds.TabIndex = 17;
            this.btnTransferFunds.Text = "Transfer funds";
            this.btnTransferFunds.UseVisualStyleBackColor = false;
            this.btnTransferFunds.Click += new System.EventHandler(this.btnTransferFunds_Click);
            // 
            // lblAccountWarning
            // 
            this.lblAccountWarning.AutoSize = true;
            this.lblAccountWarning.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountWarning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountWarning.Location = new System.Drawing.Point(717, 193);
            this.lblAccountWarning.Name = "lblAccountWarning";
            this.lblAccountWarning.Size = new System.Drawing.Size(399, 19);
            this.lblAccountWarning.TabIndex = 21;
            this.lblAccountWarning.Text = "WARNING: source and target accounts cannot be the same";
            // 
            // txtAmountToTransfer
            // 
            this.txtAmountToTransfer.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountToTransfer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAmountToTransfer.Location = new System.Drawing.Point(38, 380);
            this.txtAmountToTransfer.Name = "txtAmountToTransfer";
            this.txtAmountToTransfer.Size = new System.Drawing.Size(238, 27);
            this.txtAmountToTransfer.TabIndex = 22;
            this.txtAmountToTransfer.TextChanged += new System.EventHandler(this.txtAmountToTranfer_TextChanged);
            // 
            // lblAmountReceived
            // 
            this.lblAmountReceived.AutoSize = true;
            this.lblAmountReceived.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountReceived.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAmountReceived.Location = new System.Drawing.Point(716, 273);
            this.lblAmountReceived.Name = "lblAmountReceived";
            this.lblAmountReceived.Size = new System.Drawing.Size(374, 29);
            this.lblAmountReceived.TabIndex = 23;
            this.lblAmountReceived.Text = "Amount received in target account:";
            // 
            // txtAmountInTarget
            // 
            this.txtAmountInTarget.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountInTarget.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAmountInTarget.Location = new System.Drawing.Point(721, 380);
            this.txtAmountInTarget.Name = "txtAmountInTarget";
            this.txtAmountInTarget.ReadOnly = true;
            this.txtAmountInTarget.Size = new System.Drawing.Size(238, 27);
            this.txtAmountInTarget.TabIndex = 24;
            // 
            // lblTransferFormatWarning
            // 
            this.lblTransferFormatWarning.AutoSize = true;
            this.lblTransferFormatWarning.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferFormatWarning.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTransferFormatWarning.Location = new System.Drawing.Point(34, 437);
            this.lblTransferFormatWarning.Name = "lblTransferFormatWarning";
            this.lblTransferFormatWarning.Size = new System.Drawing.Size(279, 19);
            this.lblTransferFormatWarning.TabIndex = 25;
            this.lblTransferFormatWarning.Text = "Error: please only use numbers (0-9) and";
            // 
            // lblErrorsAndWarnings
            // 
            this.lblErrorsAndWarnings.AutoSize = true;
            this.lblErrorsAndWarnings.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorsAndWarnings.ForeColor = System.Drawing.Color.Red;
            this.lblErrorsAndWarnings.Location = new System.Drawing.Point(29, 574);
            this.lblErrorsAndWarnings.Name = "lblErrorsAndWarnings";
            this.lblErrorsAndWarnings.Size = new System.Drawing.Size(175, 26);
            this.lblErrorsAndWarnings.TabIndex = 26;
            this.lblErrorsAndWarnings.Text = "WARNING/ERROR";
            // 
            // btnPreviewAmount
            // 
            this.btnPreviewAmount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPreviewAmount.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewAmount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPreviewAmount.Location = new System.Drawing.Point(850, 437);
            this.btnPreviewAmount.Margin = new System.Windows.Forms.Padding(1);
            this.btnPreviewAmount.Name = "btnPreviewAmount";
            this.btnPreviewAmount.Size = new System.Drawing.Size(109, 62);
            this.btnPreviewAmount.TabIndex = 27;
            this.btnPreviewAmount.Text = "Preview amount";
            this.btnPreviewAmount.UseVisualStyleBackColor = false;
            this.btnPreviewAmount.Click += new System.EventHandler(this.btnPreviewAmount_Click);
            // 
            // TransferFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnPreviewAmount);
            this.Controls.Add(this.lblErrorsAndWarnings);
            this.Controls.Add(this.lblTransferFormatWarning);
            this.Controls.Add(this.txtAmountInTarget);
            this.Controls.Add(this.lblAmountReceived);
            this.Controls.Add(this.txtAmountToTransfer);
            this.Controls.Add(this.lblAccountWarning);
            this.Controls.Add(this.btnTransferFunds);
            this.Controls.Add(this.cmbTargetAccounts);
            this.Controls.Add(this.cmbSourceAccounts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAmountToTransfer);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblWelcomeDashboard);
            this.Name = "TransferFunds";
            this.Text = "Transfer between Accounts";
            this.Load += new System.EventHandler(this.TransferFunds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeDashboard;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblAmountToTransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSourceAccounts;
        private System.Windows.Forms.ComboBox cmbTargetAccounts;
        private System.Windows.Forms.Button btnTransferFunds;
        private System.Windows.Forms.Label lblAccountWarning;
        private System.Windows.Forms.TextBox txtAmountToTransfer;
        private System.Windows.Forms.Label lblAmountReceived;
        private System.Windows.Forms.TextBox txtAmountInTarget;
        private System.Windows.Forms.Label lblTransferFormatWarning;
        private System.Windows.Forms.Label lblErrorsAndWarnings;
        private System.Windows.Forms.Button btnPreviewAmount;
    }
}