namespace MoneyMovePrototype
{
    partial class AboutMoneyMove
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
            this.lblAboutMM = new System.Windows.Forms.Label();
            this.lblAboutDescription = new System.Windows.Forms.Label();
            this.pbxBackToPreviousPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToPreviousPage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAboutMM
            // 
            this.lblAboutMM.AutoSize = true;
            this.lblAboutMM.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutMM.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAboutMM.Location = new System.Drawing.Point(30, 101);
            this.lblAboutMM.Name = "lblAboutMM";
            this.lblAboutMM.Size = new System.Drawing.Size(406, 59);
            this.lblAboutMM.TabIndex = 2;
            this.lblAboutMM.Text = "About MoneyMove";
            // 
            // lblAboutDescription
            // 
            this.lblAboutDescription.AutoSize = true;
            this.lblAboutDescription.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutDescription.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAboutDescription.Location = new System.Drawing.Point(33, 189);
            this.lblAboutDescription.Name = "lblAboutDescription";
            this.lblAboutDescription.Size = new System.Drawing.Size(25, 29);
            this.lblAboutDescription.TabIndex = 4;
            this.lblAboutDescription.Text = "*";
            // 
            // pbxBackToPreviousPage
            // 
            this.pbxBackToPreviousPage.Location = new System.Drawing.Point(14, 13);
            this.pbxBackToPreviousPage.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxBackToPreviousPage.Name = "pbxBackToPreviousPage";
            this.pbxBackToPreviousPage.Size = new System.Drawing.Size(81, 72);
            this.pbxBackToPreviousPage.TabIndex = 25;
            this.pbxBackToPreviousPage.TabStop = false;
            this.pbxBackToPreviousPage.Click += new System.EventHandler(this.pbxBackToPreviousPage_Click);
            // 
            // AboutMoneyMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.pbxBackToPreviousPage);
            this.Controls.Add(this.lblAboutDescription);
            this.Controls.Add(this.lblAboutMM);
            this.Name = "AboutMoneyMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About MoneyMove";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToPreviousPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutMM;
        private System.Windows.Forms.Label lblAboutDescription;
        private System.Windows.Forms.PictureBox pbxBackToPreviousPage;
    }
}