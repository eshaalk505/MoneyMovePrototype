using MoneyMovePrototype.System_Admin_Functionality;
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
    public partial class SystemAdminDashboard : Form
    {
        private void LoadDGVData()
        {
            dgvSusCases.DefaultCellStyle.Font = new Font("Candara", 10);
            dgvSusCases.DefaultCellStyle.ForeColor = Color.MidnightBlue;
            dgvSusCases.ColumnHeadersDefaultCellStyle.Font = new Font("Candara", 11, FontStyle.Bold);
            dgvSusCases.ColumnHeadersDefaultCellStyle.ForeColor = Color.MidnightBlue;
            string connectionString = "Server=moneymoveserver.database.windows.net;Database=MoneyMoveDatabase;User Id=CloudSA51e7d7d1;Password=uglyDuckling15!;Encrypt=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT st.[ID], ud.[Forename], ud.[Surname],st.[Status],st.[Reason for Suspicion],st.[Evidence Provided],st.[Refund Status],st.[User Account Status],st.[Additional Notes] FROM dbo.[UserDetailsTable] AS ud INNER JOIN SuspiciousTransactions AS st ON ud.[ID] = st.[Customer ID]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvSusCases.DataSource = table;
                }
            }
        }
        public SystemAdminDashboard()
        {
            InitializeComponent();
            pbxBackToWelcomePage.Image = Image.FromFile(@"arrow.png");
            lblWelcomeDashboard.Text = "Welcome back " + SessionManager.Instance._forenameOfUser + "!";
            LoadDGVData();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement.LogoutFromSystem();
        }

        private void aboutMoneyMoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagement.NavigateToNextForm(this, new AboutMoneyMove(this));
        }

        private void viewCaseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SuspiciousCase selectedCase = new SuspiciousCase(Convert.ToInt32(dgvSusCases.SelectedCells[0].Value), Convert.ToString(dgvSusCases.SelectedCells[1].Value), Convert.ToString(dgvSusCases.SelectedCells[2].Value), Convert.ToString(dgvSusCases.SelectedCells[3].Value), Convert.ToString(dgvSusCases.SelectedCells[4].Value), Convert.ToBoolean(dgvSusCases.SelectedCells[5].Value), Convert.ToString(dgvSusCases.SelectedCells[6].Value), Convert.ToString(dgvSusCases.SelectedCells[7].Value), Convert.ToString(dgvSusCases.SelectedCells[8].Value));
                FormManagement.NavigateToNextForm(this, new ManageSuspiciousCaseDetails(selectedCase));
            }
            catch (Exception)
            {

                MessageBox.Show("Error in retrieving information. Please check your connection and try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormManagement.LogoutFromSystem();
        }

        private void SystemAdminDashboard_Load(object sender, EventArgs e)
        {
            pbxBackToWelcomePage.Image = Image.FromFile(@"arrow.png");

        }

        private void pbxBackToWelcomePage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will log you out, are you sure you would like to proceed?", "Confirm Action", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                FormManagement.MoveBackToPreviousForm(this, new SystemAdminLoginPage());
            }
        }

        private void btnViewTransactionHistory_Click(object sender, EventArgs e)
        {
            try
            {
                FormManagement.NavigateToNextForm(this, new ViewTransactionHistory());

            }
            catch (Exception)
            {

                MessageBox.Show("Error in retrieving information. Please check your connection and try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
