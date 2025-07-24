namespace MoneyMovePrototype.System_User_Functionality
{
    partial class VerifyOTP
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
            this.lblEnterOTP = new System.Windows.Forms.Label();
            this.txtEnteredOTP = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnterOTP
            // 
            this.lblEnterOTP.AutoSize = true;
            this.lblEnterOTP.Font = new System.Drawing.Font("Candara", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterOTP.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblEnterOTP.Location = new System.Drawing.Point(24, 30);
            this.lblEnterOTP.Name = "lblEnterOTP";
            this.lblEnterOTP.Size = new System.Drawing.Size(619, 45);
            this.lblEnterOTP.TabIndex = 9;
            this.lblEnterOTP.Text = "Please enter the generated OTP below:";
            // 
            // txtEnteredOTP
            // 
            this.txtEnteredOTP.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnteredOTP.Location = new System.Drawing.Point(32, 150);
            this.txtEnteredOTP.Name = "txtEnteredOTP";
            this.txtEnteredOTP.Size = new System.Drawing.Size(305, 31);
            this.txtEnteredOTP.TabIndex = 10;
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerify.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerify.Location = new System.Drawing.Point(631, 330);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(1);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(113, 82);
            this.btnVerify.TabIndex = 11;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // VerifyOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.txtEnteredOTP);
            this.Controls.Add(this.lblEnterOTP);
            this.Name = "VerifyOTP";
            this.Text = "Verify account with One-Time Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterOTP;
        private System.Windows.Forms.TextBox txtEnteredOTP;
        private System.Windows.Forms.Button btnVerify;
    }
}