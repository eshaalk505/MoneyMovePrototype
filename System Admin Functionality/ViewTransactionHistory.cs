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

namespace MoneyMovePrototype.System_Admin_Functionality
{
    public partial class ViewTransactionHistory : Form
    {
        string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";

        private void LoadDGVData()
        {
            dgvTransactionHistory.DefaultCellStyle.Font = new Font("Candara", 10);
            dgvTransactionHistory.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.Font = new Font("Candara", 11, FontStyle.Bold);
            dgvTransactionHistory.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT [Customer],[Target Account Name],[Source Account Name], [Amount Transferred in Target Account Currency], [Transaction Date] FROM dbo.[TransactionHistoryTable]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvTransactionHistory.DataSource = table;
                }
            }
        }

        public ViewTransactionHistory()
        {
            InitializeComponent();
            pbxBackToWelcomePage.Image = Image.FromFile(@"arrow.png");
            LoadDGVData();
        }

        private void pbxBackToWelcomePage_Click(object sender, EventArgs e)
        {
            FormManagement.MoveBackToPreviousForm(this, new SystemAdminDashboard());
        }
    }
}
