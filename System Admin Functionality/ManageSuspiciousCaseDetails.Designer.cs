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
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSusCase
            // 
            this.lblSusCase.AutoSize = true;
            this.lblSusCase.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSusCase.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSusCase.Location = new System.Drawing.Point(29, 89);
            this.lblSusCase.Name = "lblSusCase";
            this.lblSusCase.Size = new System.Drawing.Size(494, 59);
            this.lblSusCase.TabIndex = 2;
            this.lblSusCase.Text = "Suspicious case number";
            // 
            // lblAccountProvider
            // 
            this.lblAccountProvider.AutoSize = true;
            this.lblAccountProvider.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountProvider.Location = new System.Drawing.Point(34, 206);
            this.lblAccountProvider.Name = "lblAccountProvider";
            this.lblAccountProvider.Size = new System.Drawing.Size(180, 29);
            this.lblAccountProvider.TabIndex = 5;
            this.lblAccountProvider.Text = "Customer name:";
            // 
            // txtAccountProvider
            // 
            this.txtAccountProvider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAccountProvider.Location = new System.Drawing.Point(220, 208);
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
            this.cmbCaseStatus.Location = new System.Drawing.Point(220, 296);
            this.cmbCaseStatus.Name = "cmbCaseStatus";
            this.cmbCaseStatus.Size = new System.Drawing.Size(198, 27);
            this.cmbCaseStatus.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(34, 294);
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
            this.label2.Location = new System.Drawing.Point(34, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
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
            this.cmbReason.Location = new System.Drawing.Point(220, 389);
            this.cmbReason.Name = "cmbReason";
            this.cmbReason.Size = new System.Drawing.Size(198, 27);
            this.cmbReason.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(34, 476);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 29);
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
            this.cmbEvidence.Location = new System.Drawing.Point(358, 478);
            this.cmbEvidence.Name = "cmbEvidence";
            this.cmbEvidence.Size = new System.Drawing.Size(198, 27);
            this.cmbEvidence.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(714, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
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
            this.cmbRefundStatus.Location = new System.Drawing.Point(881, 208);
            this.cmbRefundStatus.Name = "cmbRefundStatus";
            this.cmbRefundStatus.Size = new System.Drawing.Size(198, 27);
            this.cmbRefundStatus.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(714, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
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
            this.cmbAccStatus.Location = new System.Drawing.Point(941, 294);
            this.cmbAccStatus.Name = "cmbAccStatus";
            this.cmbAccStatus.Size = new System.Drawing.Size(198, 27);
            this.cmbAccStatus.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(714, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 33;
            this.label6.Text = "Additional notes:";
            // 
            // rtbNotes
            // 
            this.rtbNotes.Location = new System.Drawing.Point(719, 439);
            this.rtbNotes.Name = "rtbNotes";
            this.rtbNotes.Size = new System.Drawing.Size(420, 167);
            this.rtbNotes.TabIndex = 34;
            this.rtbNotes.Text = "";
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateRecord.Location = new System.Drawing.Point(1247, 544);
            this.btnUpdateRecord.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(198, 89);
            this.btnUpdateRecord.TabIndex = 35;
            this.btnUpdateRecord.Text = "Edit and save";
            this.btnUpdateRecord.UseVisualStyleBackColor = false;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // pbxBackToDashboard
            // 
            this.pbxBackToDashboard.Location = new System.Drawing.Point(15, 13);
            this.pbxBackToDashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxBackToDashboard.Name = "pbxBackToDashboard";
            this.pbxBackToDashboard.Size = new System.Drawing.Size(81, 72);
            this.pbxBackToDashboard.TabIndex = 36;
            this.pbxBackToDashboard.TabStop = false;
            this.pbxBackToDashboard.Click += new System.EventHandler(this.pbxBackToDashboard_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblID.Location = new System.Drawing.Point(529, 89);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(116, 59);
            this.lblID.TabIndex = 37;
            this.lblID.Text = "*ID*";
            // 
            // ManageSuspiciousCaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
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
    }
}