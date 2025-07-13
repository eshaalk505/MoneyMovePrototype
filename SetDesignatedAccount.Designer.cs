namespace MoneyMovePrototype
{
    partial class SetDesignatedAccount
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
            this.lblEnterDetails = new System.Windows.Forms.Label();
            this.lblAccountInfoNote = new System.Windows.Forms.Label();
            this.lblAccountProvider = new System.Windows.Forms.Label();
            this.cmbAccountProvider = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetAccount = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.lblOtherAccount = new System.Windows.Forms.Label();
            this.txtAccountProvider = new System.Windows.Forms.TextBox();
            this.lblExpDateFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterDetails
            // 
            this.lblEnterDetails.AutoSize = true;
            this.lblEnterDetails.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDetails.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEnterDetails.Location = new System.Drawing.Point(26, 33);
            this.lblEnterDetails.Name = "lblEnterDetails";
            this.lblEnterDetails.Size = new System.Drawing.Size(676, 59);
            this.lblEnterDetails.TabIndex = 1;
            this.lblEnterDetails.Text = "Input the required details below:";
            // 
            // lblAccountInfoNote
            // 
            this.lblAccountInfoNote.AutoSize = true;
            this.lblAccountInfoNote.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInfoNote.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountInfoNote.Location = new System.Drawing.Point(30, 126);
            this.lblAccountInfoNote.Name = "lblAccountInfoNote";
            this.lblAccountInfoNote.Size = new System.Drawing.Size(963, 36);
            this.lblAccountInfoNote.TabIndex = 3;
            this.lblAccountInfoNote.Text = "Note: if you have a designated UK account already set, this will be overwritten";
            // 
            // lblAccountProvider
            // 
            this.lblAccountProvider.AutoSize = true;
            this.lblAccountProvider.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAccountProvider.Location = new System.Drawing.Point(30, 223);
            this.lblAccountProvider.Name = "lblAccountProvider";
            this.lblAccountProvider.Size = new System.Drawing.Size(296, 29);
            this.lblAccountProvider.TabIndex = 4;
            this.lblAccountProvider.Text = "Select UK account provider:";
            // 
            // cmbAccountProvider
            // 
            this.cmbAccountProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccountProvider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbAccountProvider.FormattingEnabled = true;
            this.cmbAccountProvider.Items.AddRange(new object[] {
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
            this.cmbAccountProvider.Location = new System.Drawing.Point(332, 227);
            this.cmbAccountProvider.Name = "cmbAccountProvider";
            this.cmbAccountProvider.Size = new System.Drawing.Size(121, 27);
            this.cmbAccountProvider.TabIndex = 5;
            this.cmbAccountProvider.SelectedIndexChanged += new System.EventHandler(this.cmbAccountProvider_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(29, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Card number (16 digits):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(670, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Expiration date:";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtExpDate.Location = new System.Drawing.Point(852, 228);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(132, 27);
            this.txtExpDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(670, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Security code (CVV):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(670, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name on card:";
            // 
            // btnSetAccount
            // 
            this.btnSetAccount.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSetAccount.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetAccount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSetAccount.Location = new System.Drawing.Point(1234, 531);
            this.btnSetAccount.Margin = new System.Windows.Forms.Padding(1);
            this.btnSetAccount.Name = "btnSetAccount";
            this.btnSetAccount.Size = new System.Drawing.Size(198, 89);
            this.btnSetAccount.TabIndex = 16;
            this.btnSetAccount.Text = "Set UK Account";
            this.btnSetAccount.UseVisualStyleBackColor = false;
            this.btnSetAccount.Click += new System.EventHandler(this.btnSetAccount_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNum.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtCardNum.Location = new System.Drawing.Point(290, 342);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(238, 27);
            this.txtCardNum.TabIndex = 17;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtName.Location = new System.Drawing.Point(836, 339);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(238, 27);
            this.txtName.TabIndex = 18;
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSec.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtSec.Location = new System.Drawing.Point(896, 412);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(101, 27);
            this.txtSec.TabIndex = 19;
            // 
            // lblOtherAccount
            // 
            this.lblOtherAccount.AutoSize = true;
            this.lblOtherAccount.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherAccount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOtherAccount.Location = new System.Drawing.Point(60, 277);
            this.lblOtherAccount.Name = "lblOtherAccount";
            this.lblOtherAccount.Size = new System.Drawing.Size(318, 19);
            this.lblOtherAccount.TabIndex = 20;
            this.lblOtherAccount.Text = "Please enter the account provider name here:";
            // 
            // txtAccountProvider
            // 
            this.txtAccountProvider.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountProvider.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtAccountProvider.Location = new System.Drawing.Point(255, 299);
            this.txtAccountProvider.Name = "txtAccountProvider";
            this.txtAccountProvider.Size = new System.Drawing.Size(198, 27);
            this.txtAccountProvider.TabIndex = 21;
            // 
            // lblExpDateFormat
            // 
            this.lblExpDateFormat.AutoSize = true;
            this.lblExpDateFormat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDateFormat.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExpDateFormat.Location = new System.Drawing.Point(701, 274);
            this.lblExpDateFormat.Name = "lblExpDateFormat";
            this.lblExpDateFormat.Size = new System.Drawing.Size(231, 19);
            this.lblExpDateFormat.TabIndex = 22;
            this.lblExpDateFormat.Text = "Please use the following format:";
            // 
            // SetDesignatedAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.lblExpDateFormat);
            this.Controls.Add(this.txtAccountProvider);
            this.Controls.Add(this.lblOtherAccount);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCardNum);
            this.Controls.Add(this.btnSetAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExpDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAccountProvider);
            this.Controls.Add(this.lblAccountProvider);
            this.Controls.Add(this.lblAccountInfoNote);
            this.Controls.Add(this.lblEnterDetails);
            this.Name = "SetDesignatedAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Set My Designated UK Bank Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDetails;
        private System.Windows.Forms.Label lblAccountInfoNote;
        private System.Windows.Forms.Label lblAccountProvider;
        private System.Windows.Forms.ComboBox cmbAccountProvider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetAccount;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.Label lblOtherAccount;
        private System.Windows.Forms.TextBox txtAccountProvider;
        private System.Windows.Forms.Label lblExpDateFormat;
    }
}