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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblExchangeRates = new System.Windows.Forms.Label();
            this.dgvCurrencyExchangeRates = new System.Windows.Forms.DataGridView();
            this.lblExchangeInfo = new System.Windows.Forms.Label();
            this.pbxBackToDashbaord = new System.Windows.Forms.PictureBox();
            this.chtExchangeRatesHistory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cmbCurrencies = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyExchangeRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashbaord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtExchangeRatesHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExchangeRates
            // 
            this.lblExchangeRates.AutoSize = true;
            this.lblExchangeRates.Font = new System.Drawing.Font("Candara", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExchangeRates.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblExchangeRates.Location = new System.Drawing.Point(4, 89);
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
            this.lblExchangeInfo.Location = new System.Drawing.Point(12, 177);
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
            // chtExchangeRatesHistory
            // 
            chartArea4.Name = "ChartArea1";
            this.chtExchangeRatesHistory.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chtExchangeRatesHistory.Legends.Add(legend4);
            this.chtExchangeRatesHistory.Location = new System.Drawing.Point(705, 249);
            this.chtExchangeRatesHistory.Name = "chtExchangeRatesHistory";
            this.chtExchangeRatesHistory.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chtExchangeRatesHistory.Series.Add(series4);
            this.chtExchangeRatesHistory.Size = new System.Drawing.Size(750, 400);
            this.chtExchangeRatesHistory.TabIndex = 26;
            this.chtExchangeRatesHistory.Text = "chart1";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnFilter.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilter.Location = new System.Drawing.Point(954, 203);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(1);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(133, 35);
            this.btnFilter.TabIndex = 31;
            this.btnFilter.Text = "Check history";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblFilter.Location = new System.Drawing.Point(700, 168);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(508, 29);
            this.lblFilter.TabIndex = 30;
            this.lblFilter.Text = "Select currency below to check currency history:";
            // 
            // cmbCurrencies
            // 
            this.cmbCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrencies.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurrencies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbCurrencies.FormattingEnabled = true;
            this.cmbCurrencies.Items.AddRange(new object[] {
            "Euro (€)",
            "Australian Dollar ($)",
            "US Dollar ($)",
            "Japanese Yen (¥)",
            "Canadian Dollar ($)",
            "Pakistani Rupee (Rs)",
            "Indian Rupee (IR)",
            "Swiss Franc (Fr)",
            "New Zealand Dollar ($)"});
            this.cmbCurrencies.Location = new System.Drawing.Point(705, 209);
            this.cmbCurrencies.Name = "cmbCurrencies";
            this.cmbCurrencies.Size = new System.Drawing.Size(245, 27);
            this.cmbCurrencies.TabIndex = 29;
            // 
            // ViewCurrencyExchangeRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1484, 661);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.cmbCurrencies);
            this.Controls.Add(this.chtExchangeRatesHistory);
            this.Controls.Add(this.pbxBackToDashbaord);
            this.Controls.Add(this.lblExchangeInfo);
            this.Controls.Add(this.dgvCurrencyExchangeRates);
            this.Controls.Add(this.lblExchangeRates);
            this.Name = "ViewCurrencyExchangeRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Exchange Rates";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencyExchangeRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBackToDashbaord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtExchangeRatesHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExchangeRates;
        private System.Windows.Forms.DataGridView dgvCurrencyExchangeRates;
        private System.Windows.Forms.Label lblExchangeInfo;
        private System.Windows.Forms.PictureBox pbxBackToDashbaord;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtExchangeRatesHistory;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cmbCurrencies;
    }
}