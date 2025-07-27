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
            this.cmbReason = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEvidence = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbRefundStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAccStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbNotes = new System.Windows.Forms.RichTextBox();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.pbxBackToDashboard = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.btnUnblockUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSusCase
            // 
            this.lblSusCase.AutoSize = true;
            this.lblSusCase.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSusCase.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSusCase.Location = new System.Drawing.Point(77, 212);
            this.lblSusCase.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblSusCase.Name = "lblSusCase";
            this.lblSusCase.Size = new System.Drawing.Size(1245, 146);
            this.lblSusCase.TabIndex = 2;
            this.lblSusCase.Text = "Suspicious case number";
            // 
            // lblAccountProvider
            // 
            this.lblAccountProvider.AutoSize = true;
            this.lblAccountProvider.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountProvider.Location = new System.Drawing.Point(91, 439);
            this.lblAccountProvider.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblAccountProvider.Name = "lblAccountProvider";
            this.lblAccountProvider.Size = new System.Drawing.Size(453, 73);
            this.lblAccountProvider.TabIndex = 5;
            this.lblAccountProvider.Text = "Customer name:";
            // 
            // txtAccountProvider
            // 
            this.txtAccountProvider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAccountProvider.Location = new System.Drawing.Point(587, 444);
            this.txtAccountProvider.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtAccountProvider.Name = "txtAccountProvider";
            this.txtAccountProvider.ReadOnly = true;
            this.txtAccountProvider.Size = new System.Drawing.Size(521, 56);
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
            this.cmbCaseStatus.Location = new System.Drawing.Point(587, 706);
            this.cmbCaseStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbCaseStatus.Name = "cmbCaseStatus";
            this.cmbCaseStatus.Size = new System.Drawing.Size(521, 57);
            this.cmbCaseStatus.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(91, 701);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 73);
            this.label1.TabIndex = 24;
            this.label1.Text = "Case status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(91, 916);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 73);
            this.label2.TabIndex = 25;
            this.label2.Text = "Reason:";
            // 
            // cmbReason
            // 
            this.cmbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReason.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReason.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbReason.FormattingEnabled = true;
            this.cmbReason.Items.AddRange(new object[] {
            "Large transaction",
            "Multiple similar transactions"});
            this.cmbReason.Location = new System.Drawing.Point(587, 928);
            this.cmbReason.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(521, 57);
            this.cmbReason.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(91, 1135);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(775, 73);
            this.label3.TabIndex = 27;
            this.label3.Text = "Has evidence been provided?";
            // 
            // cmbEvidence
            // 
            this.cmbEvidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvidence.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEvidence.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbEvidence.FormattingEnabled = true;
            this.cmbEvidence.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbEvidence.Location = new System.Drawing.Point(955, 1140);
            this.cmbEvidence.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbEvidence.Name = "cmbEvidence";
            this.cmbEvidence.Size = new System.Drawing.Size(521, 57);
            this.cmbEvidence.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(1904, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 73);
            this.label4.TabIndex = 29;
            this.label4.Text = "Refund status:";
            // 
            // cmbRefundStatus
            // 
            this.cmbRefundStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRefundStatus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRefundStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbRefundStatus.FormattingEnabled = true;
            this.cmbRefundStatus.Items.AddRange(new object[] {
            "Not requested",
            "Not applicable",
            "Requested by customer",
            "Offer sent from system",
            "Processing",
            "Received by customer"});
            this.cmbRefundStatus.Location = new System.Drawing.Point(2349, 444);
            this.cmbRefundStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbRefundStatus.Name = "cmbRefundStatus";
            this.cmbRefundStatus.Size = new System.Drawing.Size(521, 57);
            this.cmbRefundStatus.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(1904, 694);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(550, 73);
            this.label5.TabIndex = 31;
            this.label5.Text = "User account status:";
            // 
            // cmbAccStatus
            // 
            this.cmbAccStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccStatus.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccStatus.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbAccStatus.FormattingEnabled = true;
            this.cmbAccStatus.Items.AddRange(new object[] {
            "Active",
            "Closed - voluntary",
            "Suspended",
            "Blocked"});
            this.cmbAccStatus.Location = new System.Drawing.Point(2509, 701);
            this.cmbAccStatus.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cmbAccStatus.Name = "cmbAccStatus";
            this.cmbAccStatus.Size = new System.Drawing.Size(521, 57);
            this.cmbAccStatus.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(1904, 916);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(472, 73);
            this.label6.TabIndex = 33;
            this.label6.Text = "Additional notes:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(1917, 1047);
            this.rtbNotes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(1113, 393);
            this.rtbNotes.TabIndex = 34;
            this.rtbNotes.Text = "";
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateRecord.Location = new System.Drawing.Point(3325, 1297);
            this.btnUpdateRecord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(528, 212);
            this.btnUpdateRecord.TabIndex = 35;
            this.btnUpdateRecord.Text = "Edit and save";
            this.btnUpdateRecord.UseVisualStyleBackColor = false;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // pbxBackToDashboard
            // 
            this.pbxBackToDashboard.Location = new System.Drawing.Point(40, 31);
            this.pbxBackToDashboard.Margin = new System.Windows.Forms.Padding(13, 10, 13, 10);
            this.pbxBackToDashboard.Name = "pbxBackToDashboard";
            this.pbxBackToDashboard.Size = new System.Drawing.Size(216, 172);
            this.pbxBackToDashboard.TabIndex = 36;
            this.pbxBackToDashboard.TabStop = false;
            this.pbxBackToDashboard.Click += new System.EventHandler(this.pbxBackToDashboard_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblID.Location = new System.Drawing.Point(1411, 212);
            this.lblID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(292, 146);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "*ID*";
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBlockUser.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBlockUser.Location = new System.Drawing.Point(3325, 964);
            this.btnBlockUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(528, 212);
            this.btnBlockUser.TabIndex = 39;
            this.btnBlockUser.Text = "Block customer account";
            this.btnBlockUser.UseVisualStyleBackColor = false;
            this.btnBlockUser.Click += new System.EventHandler(this.btnBlockUser_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCustID.Location = new System.Drawing.Point(587, 574);
            this.txtCustID.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(521, 56);
            this.txtCustID.TabIndex = 41;
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCustID.Location = new System.Drawing.Point(91, 574);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(915, 183);
            this.lblCustID.TabIndex = 42;
            this.lblCustID.Text = "Customer ID:";
            // 
            // btnUnblockUser
            // 
            this.btnUnblockUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUnblockUser.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnblockUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUnblockUser.Location = new System.Drawing.Point(3325, 642);
            this.btnUnblockUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnblockUser.Name = "btnUnblockUser";
            this.btnUnblockUser.Size = new System.Drawing.Size(528, 212);
            this.btnUnblockUser.TabIndex = 43;
            this.btnUnblockUser.Text = "Unblock customer account";
            this.btnUnblockUser.UseVisualStyleBackColor = false;
            this.btnUnblockUser.Click += new System.EventHandler(this.btnUnblockUser_Click);
            // 
            // ManageSuspiciousCaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(3957, 1576);
            this.Controls.Add(this.btnUnblockUser);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnBlockUser);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.pbxBackToDashboard);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.rtbNotes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAccStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbRefundStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEvidence);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbReason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCaseStatus);
            this.Controls.Add(this.txtAccountProvider);
            this.Controls.Add(this.lblAccountProvider);
            this.Controls.Add(this.lblSusCase);
            this.Controls.Add(this.lblCustID);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ManageSuspiciousCaseDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSuspiciousCaseDetails";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashboard)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbReason;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEvidence;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRefundStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAccStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbNotes;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.PictureBox pbxBackToDashboard;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnBlockUser;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Button btnUnblockUser;
    }
}