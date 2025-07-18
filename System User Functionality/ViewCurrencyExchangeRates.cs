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
        public ViewCurrencyExchangeRates()
        {
            InitializeComponent();
            pbxBackToDashbaord.Image = Image.FromFile(@"arrow.png");
            LoadDGVData();
        }

        private void pbxBackToDashbaord_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new SystemUserDashboard());
        }
    }
}
