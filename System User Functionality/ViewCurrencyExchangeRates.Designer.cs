namespace MoneyMovePrototype
{
    partial class ViewCurrencyExchangeRates
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
            this.lblExchangeRates = new System.Windows.Forms.Label();
            this.dgvCurrencyExchangeRates = new System.Windows.Forms.DataGridView();
            this.lblExchangeInfo = new System.Windows.Forms.Label();
            this.pbxBackToDashbaord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyExchangeRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashbaord)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExchangeRates
            // 
            this.lblExchangeRates.AutoSize = true;
            this.lblExchangeRates.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangeRates.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExchangeRates.Location = new System.Drawing.Point(20, 101);
            this.lblExchangeRates.Name = "lblExchangeRates";
            this.lblExchangeRates.Size = new System.Drawing.Size(756, 59);
            this.lblExchangeRates.TabIndex = 1;
            this.lblExchangeRates.Text = "View recent currency exchange rates";
            // 
            // dgvCurrencyExchangeRates
            // 
            this.dgvCurrencyExchangeRates.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCurrencyExchangeRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrencyExchangeRates.Location = new System.Drawing.Point(40, 285);
            this.dgvCurrencyExchangeRates.Name = "dgvCurrencyExchangeRates";
            this.dgvCurrencyExchangeRates.Size = new System.Drawing.Size(472, 310);
            this.dgvCurrencyExchangeRates.TabIndex = 2;
            // 
            // lblExchangeInfo
            // 
            this.lblExchangeInfo.AutoSize = true;
            this.lblExchangeInfo.Font = new System.Drawing.Font("Candara", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangeInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExchangeInfo.Location = new System.Drawing.Point(33, 195);
            this.lblExchangeInfo.Name = "lblExchangeInfo";
            this.lblExchangeInfo.Size = new System.Drawing.Size(628, 42);
            this.lblExchangeInfo.TabIndex = 3;
            this.lblExchangeInfo.Text = "All below rates are equivalent to 1 GBP (£)";
            // 
            // pbxBackToDashbaord
            // 
            this.pbxBackToDashbaord.Location = new System.Drawing.Point(14, 13);
            this.pbxBackToDashbaord.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbxBackToDashbaord.Name = "pbxBackToDashbaord";
            this.pbxBackToDashbaord.Size = new System.Drawing.Size(81, 72);
            this.pbxBackToDashbaord.TabIndex = 25;
            this.pbxBackToDashbaord.TabStop = false;
            this.pbxBackToDashbaord.Click += new System.EventHandler(this.pbxBackToDashbaord_Click);
            // 
            // ViewCurrencyExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.pbxBackToDashbaord);
            this.Controls.Add(this.lblExchangeInfo);
            this.Controls.Add(this.dgvCurrencyExchangeRates);
            this.Controls.Add(this.lblExchangeRates);
            this.Name = "ViewCurrencyExchangeRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Exchange Rates";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyExchangeRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashbaord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExchangeRates;
        private System.Windows.Forms.DataGridView dgvCurrencyExchangeRates;
        private System.Windows.Forms.Label lblExchangeInfo;
        private System.Windows.Forms.PictureBox pbxBackToDashbaord;
    }
}