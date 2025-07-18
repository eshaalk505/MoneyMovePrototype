using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public partial class SystemUserDashboard : Form
    {
        private void LoadDGVData()
        {
            dgvCurrentAccounts.DefaultCellStyle.Font = new Font("Candara", 10);
            dgvCurrentAccounts.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvCurrentAccounts.ColumnHeadersDefaultCellStyle.Font = new Font("Candara", 11, FontStyle.Bold);
            dgvCurrentAccounts.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query="SELECT cau.[Account Name], ca.[Currency Code],ca.[Currency Symbol],cau.[Balance In Currency] FROM dbo.[CurrencyAccountsToUsersTable] AS cau INNER JOIN CurrencyAccountsTable AS ca ON cau.[Currency Account ID] = ca.[ID] WHERE cau.[User ID] = @userID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userID", SessionManager.Instance._idOfUser);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvCurrentAccounts.DataSource = table;
                }
            }
        }
        public SystemUserDashboard()
        {
            InitializeComponent();
            lblWelcomeDashboard.Text = "Welcome back " + SessionManager.Instance._forenameOfUser + "!";
            pbxBackToWelcomePage.Image = Image.FromFile(@"arrow.png");
            LoadDGVData();

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormManagement.LogoutFromSystem();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new AboutMoneyMove(this));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new ViewCurrencyExchangeRates());
        }

        private void btnDesignatedAccount_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new SetDesignatedAccount());
        }

        private void viewAccountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrencyAccount accountToView = new CurrencyAccount(Convert.ToString(dgvCurrentAccounts.SelectedCells[0].Value), Convert.ToString(dgvCurrentAccounts.SelectedCells[1].Value), Convert.ToString(dgvCurrentAccounts.SelectedCells[2].Value), Convert.ToDecimal(dgvCurrentAccounts.SelectedCells[3].Value));
            FormManagement.NavigateToNextForm(this, new ViewSelectedAccount(accountToView));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new CreateNewCurrencyAccount());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new TransferFunds());
        }

        private void pbxBackToWelcomePage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will log you out. Are you sure you would like to proceed?", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new SystemUserLoginPage());
            }
        }
    }
}