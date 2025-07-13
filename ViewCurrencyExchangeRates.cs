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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\eshaa\\Documents\\Year 2\\Software Engineering Concepts + Methods\\MoneyMovePrototype\\MoneyMoveDB.mdf\";Integrated Security=True";
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
            LoadDGVData();
        }
    }
}
