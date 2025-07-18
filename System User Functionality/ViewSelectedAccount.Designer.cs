namespace MoneyMovePrototype
{
    partial class ViewSelectedAccount
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
            this.lblSelectedAccount = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.pbxBackToDashboard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectedAccount
            // 
            this.lblSelectedAccount.AutoSize = true;
            this.lblSelectedAccount.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedAccount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblSelectedAccount.Location = new System.Drawing.Point(31, 86);
            this.lblSelectedAccount.Name = "lblSelectedAccount";
            this.lblSelectedAccount.Size = new System.Drawing.Size(711, 59);
            this.lblSelectedAccount.TabIndex = 1;
            this.lblSelectedAccount.Text = "Selected account: *account name*";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCurrency.Location = new System.Drawing.Point(36, 182);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(111, 29);
            this.lblCurrency.TabIndex = 5;
            this.lblCurrency.Text = "Currency:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBalance.Location = new System.Drawing.Point(36, 253);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(99, 29);
            this.lblBalance.TabIndex = 6;
            this.lblBalance.Text = "Balance:";
            // 
            // pbxBackToDashboard
            // 
            this.pbxBackToDashboard.Location = new System.Drawing.Point(14, 10);
            this.pbxBackToDashboard.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxBackToDashboard.Name = "pbxBackToDashboard";
            this.pbxBackToDashboard.Size = new System.Drawing.Size(81, 72);
            this.pbxBackToDashboard.TabIndex = 25;
            this.pbxBackToDashboard.TabStop = false;
            this.pbxBackToDashboard.Click += new System.EventHandler(this.pbxBackToDashboard_Click);
            // 
            // ViewSelectedAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.pbxBackToDashboard);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblSelectedAccount);
            this.Name = "ViewSelectedAccount";
            this.Text = "View Selected Account Details";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectedAccount;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.PictureBox pbxBackToDashboard;
    }
}