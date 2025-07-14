namespace MoneyMovePrototype
{
    partial class ManageSuspiciousCaseDetails
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
            this.lblSusCase = new System.Windows.Forms.Label();
            this.lblAccountProvider = new System.Windows.Forms.Label();
            this.txtAccountProvider = new System.Windows.Forms.TextBox();
            this.cmbCaseStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTransferFunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSusCase
            // 
            this.lblSusCase.AutoSize = true;
            this.lblSusCase.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSusCase.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSusCase.Location = new System.Drawing.Point(29, 34);
            this.lblSusCase.Name = "lblSusCase";
            this.lblSusCase.Size = new System.Drawing.Size(595, 59);
            this.lblSusCase.TabIndex = 2;
            this.lblSusCase.Text = "Suspicious case number *ID*";
            // 
            // lblAccountProvider
            // 
            this.lblAccountProvider.AutoSize = true;
            this.lblAccountProvider.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountProvider.Location = new System.Drawing.Point(34, 151);
            this.lblAccountProvider.Name = "lblAccountProvider";
            this.lblAccountProvider.Size = new System.Drawing.Size(180, 29);
            this.lblAccountProvider.TabIndex = 5;
            this.lblAccountProvider.Text = "Customer name:";
            // 
            // txtAccountProvider
            // 
            this.txtAccountProvider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAccountProvider.Location = new System.Drawing.Point(220, 153);
            this.txtAccountProvider.Name = "txtAccountProvider";
            this.txtAccountProvider.ReadOnly = true;
            this.txtAccountProvider.Size = new System.Drawing.Size(198, 27);
            this.txtAccountProvider.TabIndex = 22;
            // 
            // cmbCaseStatus
            // 
            this.cmbCaseStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaseStatus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCaseStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbCaseStatus.FormattingEnabled = true;
            this.cmbCaseStatus.Items.AddRange(new object[] {
            "New",
            "Pending evidence",
            "Under investigation",
            "Awaiting customer response",
            "Dismissed - system error",
            "Resolved - valid transaction",
            "Resolved - transaction cancelled",
            "Resolved - transaction reversal"});
            this.cmbCaseStatus.Location = new System.Drawing.Point(220, 241);
            this.cmbCaseStatus.Name = "cmbCaseStatus";
            this.cmbCaseStatus.Size = new System.Drawing.Size(198, 27);
            this.cmbCaseStatus.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(34, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Case status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(34, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reason:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Large transaction",
            "Multiple similar transactions"});
            this.comboBox1.Location = new System.Drawing.Point(220, 334);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 27);
            this.comboBox1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(34, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 29);
            this.label3.TabIndex = 27;
            this.label3.Text = "Has evidence been provided?";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(358, 423);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 27);
            this.comboBox2.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(714, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Refund status:";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Not requested",
            "Not applicable",
            "Requested by customer",
            "Offer sent from system",
            "Processing",
            "Received by customer"});
            this.comboBox3.Location = new System.Drawing.Point(881, 153);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(198, 27);
            this.comboBox3.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(714, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
            this.label5.TabIndex = 31;
            this.label5.Text = "User account status:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Active",
            "Closed - voluntary",
            "Suspended",
            "Blocked"});
            this.comboBox4.Location = new System.Drawing.Point(941, 239);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(198, 27);
            this.comboBox4.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(714, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Additional notes:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(719, 384);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(420, 167);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // btnTransferFunds
            // 
            this.btnTransferFunds.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTransferFunds.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferFunds.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransferFunds.Location = new System.Drawing.Point(1247, 544);
            this.btnTransferFunds.Margin = new System.Windows.Forms.Padding(1);
            this.btnTransferFunds.Name = "btnTransferFunds";
            this.btnTransferFunds.Size = new System.Drawing.Size(198, 89);
            this.btnTransferFunds.TabIndex = 35;
            this.btnTransferFunds.Text = "Edit and save";
            this.btnTransferFunds.UseVisualStyleBackColor = false;
            // 
            // ManageSuspiciousCaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnTransferFunds);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCaseStatus);
            this.Controls.Add(this.txtAccountProvider);
            this.Controls.Add(this.lblAccountProvider);
            this.Controls.Add(this.lblSusCase);
            this.Name = "ManageSuspiciousCaseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSuspiciousCaseDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSusCase;
        private System.Windows.Forms.Label lblAccountProvider;
        private System.Windows.Forms.TextBox txtAccountProvider;
        private System.Windows.Forms.ComboBox cmbCaseStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTransferFunds;
    }
}