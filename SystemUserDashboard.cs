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
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\eshaa\\Documents\\Year 2\\Software Engineering Concepts + Methods\\MoneyMovePrototype\\MoneyMoveDB.mdf\";Integrated Security=True";
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
            LoadDGVData();

        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result= MessageBox.Show("Are you sure you want to log out? Any unsaved changes will be lost and the site will close down.", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SessionManager.Instance.FinishSession();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new AboutMoneyMove());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new ViewCurrencyExchangeRates());
        }

        private void btnDesignatedAccount_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new SetDesignatedAccount());
        }
    }
}