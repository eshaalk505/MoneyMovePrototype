using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MoneyMovePrototype
{
    public partial class ViewCurrencyExchangeRates : Form
    {
        private void LoadDGVData()
        {
            string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT [Currency],[Currency Code],[Exchange Rate] FROM dbo.[CurrencyAccountsTable] WHERE [Exchange Rate] != '£1'";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvCurrencyExchangeRates.DataSource = table;
                }
            }
        }
        private void ConfigureChart()
        {
            string currency = cmbCurrencies.Text;
            switch (currency)
            {
                case "Euro (€)":
                    //euro exchange rates from https://www.exchangerates.org.uk/GBP-EUR-exchange-rate-history.html
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea euroArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(euroArea);
                    Series euro = new Series("Euro")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    euro.Points.AddXY("26 May", 1.190);
                    euro.Points.AddXY("31 May", 1.187);
                    euro.Points.AddXY("05 June", 1.194);
                    euro.Points.AddXY("10 June", 1.186);
                    euro.Points.AddXY("15 June", 1.168);
                    euro.Points.AddXY("20 June", 1.171);
                    euro.Points.AddXY("25 June", 1.174);
                    euro.Points.AddXY("30 June", 1.165);
                    euro.Points.AddXY("05 July", 1.158);
                    euro.Points.AddXY("10 July", 1.158);
                    euro.Points.AddXY("15 July", 1.151);
                    euro.Points.AddXY("20 July", 1.153);
                    chtExchangeRatesHistory.Series.Add(euro);
                    break;

                case "Australian Dollar ($)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    //Aus dollar rates from https://www.exchangerates.org.uk/GBP-AUD-exchange-rate-history.html
                    Series aud = new Series("Australian Dollar")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    aud.Points.AddXY("26 May", 2.093);
                    aud.Points.AddXY("31 May", 2.091);
                    aud.Points.AddXY("05 June", 2.086);
                    aud.Points.AddXY("10 June", 2.069);
                    aud.Points.AddXY("15 June", 2.089);
                    aud.Points.AddXY("20 June", 2.080);
                    aud.Points.AddXY("25 June", 2.096);
                    aud.Points.AddXY("30 June", 2.087);
                    aud.Points.AddXY("05 July", 2.083);
                    aud.Points.AddXY("10 July", 2.060);
                    aud.Points.AddXY("15 July", 2.053);
                    aud.Points.AddXY("20 July", 2.062);
                    chtExchangeRatesHistory.Series.Add(aud);
                    break;

                case "US Dollar ($)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea usdArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(usdArea);
                    //US dollar rates from https://www.exchangerates.org.uk/GBP-USD-exchange-rate-history.html
                    Series usd = new Series("US Dollar")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    usd.Points.AddXY("26 May", 1.357);
                    usd.Points.AddXY("31 May", 1.346);
                    usd.Points.AddXY("05 June", 1.353);
                    usd.Points.AddXY("10 June", 1.350);
                    usd.Points.AddXY("15 June", 1.357);
                    usd.Points.AddXY("20 June", 1.346);
                    usd.Points.AddXY("25 June", 1.372);
                    usd.Points.AddXY("30 June", 1.374);
                    usd.Points.AddXY("05 July", 1.365);
                    usd.Points.AddXY("10 July", 1.350);
                    usd.Points.AddXY("15 July", 1.338);
                    usd.Points.AddXY("20 July", 1.342);
                    chtExchangeRatesHistory.Series.Add(usd);
                    break;

                case "Japanese Yen (¥)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea yenArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(yenArea);
                    //Yen rates from https://www.exchangerates.org.uk/GBP-JPY-exchange-rate-history.html
                    Series yen = new Series("Japanese Yen")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    yen.Points.AddXY("26 May", 195.1);
                    yen.Points.AddXY("31 May", 194.9);
                    yen.Points.AddXY("05 June", 195);
                    yen.Points.AddXY("10 June", 195.7);
                    yen.Points.AddXY("15 June", 195.5);
                    yen.Points.AddXY("20 June", 196.6);
                    yen.Points.AddXY("25 June", 198.5);
                    yen.Points.AddXY("30 June", 197.5);
                    yen.Points.AddXY("05 July", 197.3);
                    yen.Points.AddXY("10 July", 199);
                    yen.Points.AddXY("15 July", 198.5);
                    yen.Points.AddXY("20 July", 199.4);
                    chtExchangeRatesHistory.Series.Add(yen);
                    break;

                case "Canadian Dollar ($)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea cadArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(cadArea);
                    //CAD rates from https://www.exchangerates.org.uk/GBP-CAD-exchange-rate-history.html
                    Series cad = new Series("Canadian Dollar")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    cad.Points.AddXY("26 May", 1.864);
                    cad.Points.AddXY("31 May", 1.850);
                    cad.Points.AddXY("05 June", 1.856);
                    cad.Points.AddXY("10 June", 1.846);
                    cad.Points.AddXY("15 June", 1.844);
                    cad.Points.AddXY("20 June", 1.848);
                    cad.Points.AddXY("25 June", 1.875);
                    cad.Points.AddXY("30 June", 1.869);
                    cad.Points.AddXY("05 July", 1.859);
                    cad.Points.AddXY("10 July", 1.855);
                    cad.Points.AddXY("15 July", 1.836);
                    cad.Points.AddXY("20 July", 1.841);
                    chtExchangeRatesHistory.Series.Add(cad);
                    break;

                case "Pakistani Rupee (Rs)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea pakArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(pakArea);
                    //CAD rates from https://www.exchangerates.org.uk/GBP-PKR-exchange-rate-history.html
                    Series pkr = new Series("Pakistani Rupees")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    pkr.Points.AddXY("26 May", 382.66);
                    pkr.Points.AddXY("31 May", 379.26);
                    pkr.Points.AddXY("05 June", 383.08);
                    pkr.Points.AddXY("10 June", 380.86);
                    pkr.Points.AddXY("15 June", 383.82);
                    pkr.Points.AddXY("20 June", 382.03);
                    pkr.Points.AddXY("25 June", 388.55);
                    pkr.Points.AddXY("30 June", 389.67);
                    pkr.Points.AddXY("05 July", 387.52);
                    pkr.Points.AddXY("10 July", 386.65);
                    pkr.Points.AddXY("15 July", 381.11);
                    pkr.Points.AddXY("20 July", 382.06);
                    chtExchangeRatesHistory.Series.Add(pkr);
                    break;

                case "Indian Rupee (IR)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea indArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(indArea);
                    //CAD rates from https://www.exchangerates.org.uk/GBP-INR-exchange-rate-history.html
                    Series inr = new Series("Indian Rupees")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    inr.Points.AddXY("26 May", 115.54);
                    inr.Points.AddXY("31 May", 115.18);
                    inr.Points.AddXY("05 June", 116.60);
                    inr.Points.AddXY("10 June", 115.65);
                    inr.Points.AddXY("15 June", 116.82);
                    inr.Points.AddXY("20 June", 116.53);
                    inr.Points.AddXY("25 June", 117.53);
                    inr.Points.AddXY("30 June", 117.70);
                    inr.Points.AddXY("05 July", 117.17);
                    inr.Points.AddXY("10 July", 116.48);
                    inr.Points.AddXY("15 July", 115.10);
                    inr.Points.AddXY("20 July", 115.51);
                    chtExchangeRatesHistory.Series.Add(inr);
                    break;

                case "Swiss Franc (Fr)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea sfrArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(sfrArea);
                    //SFR rates from https://www.exchangerates.org.uk/GBP-CHF-exchange-rate-history.html
                    Series sfr = new Series("Swiss Franc")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    sfr.Points.AddXY("26 May", 1.113);
                    sfr.Points.AddXY("31 May", 1.107);
                    sfr.Points.AddXY("05 June", 1.113);
                    sfr.Points.AddXY("10 June", 1.111);
                    sfr.Points.AddXY("15 June", 1.101);
                    sfr.Points.AddXY("20 June", 1.101);
                    sfr.Points.AddXY("25 June", 1.099);
                    sfr.Points.AddXY("30 June", 1.089);
                    sfr.Points.AddXY("05 July", 1.085);
                    sfr.Points.AddXY("10 July", 1.082);
                    sfr.Points.AddXY("15 July", 1.073);
                    sfr.Points.AddXY("20 July", 1.075);
                    chtExchangeRatesHistory.Series.Add(sfr);
                    break;

                case "New Zealand Dollar ($)":
                    chtExchangeRatesHistory.Series.Clear();
                    chtExchangeRatesHistory.ChartAreas.Clear();
                    ChartArea nzArea = new ChartArea("MainArea");
                    chtExchangeRatesHistory.ChartAreas.Add(nzArea);
                    //SFR rates from https://www.exchangerates.org.uk/GBP-CHF-exchange-rate-history.html
                    Series nzd = new Series("New Zealand Dollar")
                    {
                        ChartType = SeriesChartType.Line,
                        BorderWidth = 2
                    };
                    nzd.Points.AddXY("26 May", 2.261);
                    nzd.Points.AddXY("31 May", 2.257);
                    nzd.Points.AddXY("05 June", 2.247);
                    nzd.Points.AddXY("10 June", 2.230);
                    nzd.Points.AddXY("15 June", 2.254);
                    nzd.Points.AddXY("20 June", 2.253);
                    nzd.Points.AddXY("25 June", 2.262);
                    nzd.Points.AddXY("30 June", 2.252);
                    nzd.Points.AddXY("05 July", 2.253);
                    nzd.Points.AddXY("10 July", 2.249);
                    nzd.Points.AddXY("15 July", 2.251);
                    nzd.Points.AddXY("20 July", 2.255);
                    chtExchangeRatesHistory.Series.Add(nzd);
                    break;

                case " ":
                    MessageBox.Show("Error, please select a currency to view exchange rate history");
                    break;
            }
        }
        public ViewCurrencyExchangeRates()
        {
            InitializeComponent();
            pbxBackToDashbaord.Image = Image.FromFile(@"arrow.png");
            LoadDGVData();
            chtExchangeRatesHistory.Titles.Add("Currency Exchange Rates over Time (against 1 GBP)");
            chtExchangeRatesHistory.ChartAreas[0].AxisX.Title = "Date";
            chtExchangeRatesHistory.ChartAreas[0].AxisY.Title = "Equivalent of £1";

            chtExchangeRatesHistory.Series.Clear();
            chtExchangeRatesHistory.ChartAreas.Clear();
            ChartArea area = new ChartArea("Main Area");
            chtExchangeRatesHistory.ChartAreas.Add(area);
        }

        private void pbxBackToDashbaord_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new SystemUserDashboard());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigureChart();

            }
            catch (Exception)
            {

                MessageBox.Show("Error in fetching information, please check your connection and try again","Error",MessageBoxButtons.OK);
            }
        }
    }
}
